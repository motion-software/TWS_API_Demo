using System;
using IBApi;
using System.Threading;

namespace TWS_API_Demo
{
    class Program
    {
        public static int contractId = 0;
        public const string _host = "127.0.0.1";
        public const int _port = 7497;
        public const string _symbol = "AAPL";

        public static int Main(string[] args)
        {

            EWrapperImpl testImpl = new EWrapperImpl();
            EClientSocket clientSocket = testImpl.ClientSocket;
            EReaderSignal readerSignal = testImpl.Signal;
            //! [connect]
            clientSocket.eConnect(_host, _port, 0);
            //! [connect]
            //! [ereader]
            //Create a reader to consume messages from the TWS. The EReader will consume the incoming messages and put them in a queue
            var reader = new EReader(clientSocket, readerSignal);
            reader.Start();
            //Once the messages are in the queue, an additional thread need to fetch them
            new Thread(() => { while (clientSocket.IsConnected()) { readerSignal.waitForSignal(); reader.processMsgs(); } }) { IsBackground = true }.Start();

            clientSocket.reqMarketDataType(3);
            int tickerId = 100;
            getStockPrice(clientSocket, _symbol, tickerId);



            int tickerId_Option = 200;
            string expDate = "20190418";
            getContractDetails(clientSocket, _symbol, tickerId_Option, expDate);


            Thread.Sleep(500);


            Console.WriteLine("Contract Id set to: " + contractId);
            int tickerId_Option_Price = 300;
            getOptionPrice(clientSocket, _symbol, tickerId_Option_Price, contractId);


            while (contractId == 0)
            {
            }

            Console.ReadKey();
            clientSocket.cancelMktData(tickerId);
            clientSocket.cancelMktData(tickerId_Option);
            Console.WriteLine("Disconnecting...");
            clientSocket.eDisconnect();
            return 0;

        }

        private static void getStockPrice(EClientSocket client, string symbol, int tickerId)
        {
            Console.WriteLine(">> getStockPrice from tickerId: " + tickerId);
            Contract contract = new Contract {Symbol = symbol, SecType = "STK", Exchange = "SMART", Currency = "USD"};
            client.reqMktData(tickerId, contract, "", false, false, null);
            Thread.Sleep(10);
        }

        private static void getOptionPrice(EClientSocket client, string symbol, int tickerId, int conId)
        {
            Console.WriteLine(">> getOptionPrice from tickerId: " + tickerId);
            Contract contract = new Contract
            {
                Symbol = symbol,
                Strike = 230,
                Right = "CALL",
                SecType = "OPT",
                Exchange = "SMART",
                IncludeExpired = true,
                Currency = "USD",
                ConId = conId
            };
            client.reqMktData(tickerId, contract, "", false, false, null);
        }

        private static void getContractDetails(EClientSocket client, string symbol, int tickerId, string expDate)
        {
            Console.WriteLine(">> getContractDetails from tickerId: " + tickerId);
            Contract contract = new Contract
            {
                Symbol = symbol,
                SecType = "OPT",
                Exchange = "SMART",
                Currency = "USD",
                LastTradeDateOrContractMonth = expDate
            };
            //contract.Exchange = "BOX";

            client.reqContractDetails(tickerId, contract);
            Thread.Sleep(10);
        }
    }
}