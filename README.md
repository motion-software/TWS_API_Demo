## **Interactive Brokers TWS API C# Demo**
===

[![Interactive brokers](data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAJcAAAAXCAMAAAAx8S2TAAAAyVBMVEX///8AAAB6enr29vb6+vrh4eHYEiJmZmbVAADw8PCvr6/r6+sEBATl5eVgYGBdXV3Q0NDnjI8aGhoVFRWampokJCRCQkKIiIiRkZFXV1cNDQ01NTXZ2dnXABJsbGw8PDzHx8dKSkqioqK8vLwsLCyxDh3qmJv21db88vP76+vwubzcOEDeTVTkdnvmhIjhaG3aJC/rpqjzysuwABTcQ0vMESG9HSmhDBu3ABDIPUS+AAnSVFmYAACjABDFAADaqKqwXGDBYmbMYmZEBJaoAAADtklEQVRIic2Va3ebRhCGZwSIqwADy1VCXFa+JGnk1GnrNk1T+///qL67SLYa6+ikn+h84CDt7swzM+8sREe7pf+l3b2bm+C8vZ8b4Lx9uJ6b4Kz95JhzI5yza+fj3Ajn7J3j3M3NcMZunM1+boYzducsnZu5Id7a7f1y+XluiDP2frN0Tu7UMl+crrruj/gw1bZV0xhn1sKoqqqoeOsnX19yee0sl0u63d/vpw/Rgu1TLGb/B7g6ZiKL+RwX91mWFTW/AeP4kssrlOsT3W+Wm+W/ufSFZgaHWJevt5gFnv53KUxnAl1/n4f/zoWJRNGcn49cbh9ZeSAGWodJYo9kFgmLEot5s4pQmUxyGiqvXV+nVUxjlYh27W9zKreR8rEtyFikLLIXLuKM3NYoc6Jxy1V34Fq3ePOivkQOXWHYGfkLmZeaa/PxwHVz5PI5SaRIuYulSKRHW06rmiuiNO3RsZLrqKnRYLRPJnjxZCJkvGI2Y933GiElC+wNj1wer2jFlWwp47Ir2dNcawZCmHrjNjVpELL3TLZHT1S6Xg939MHZOJ/platGpnlQqBAGfDZEhuSRkiQZYxKMJCUeeY2YOS/gXxz0JRBR/Rq4R/NqbEqFFIIVyIpbpVjV0IxN4vUaRaRRKwX/DmrPiAWyhAuuX74+3NL1/vDhnriUShcIaCq92sEi7uIWiSdgU8KJPXSpM5gxUv7aOuEqEbtEFaqgwBk8qY66cRwXCLpS20c9ABZeOWNVyjDCNJttBC78WqPHxqSv3e7h11dZT1yBccLVJ6ytAlese8Kco17+y7C+clkcoO0WbQ9n2qO+Cp64PBUdVesIi2gubWu9saehJi1Z5sZTXL/tdo+/f8fFp1whimzoJDSXy4FnIHiHSwR+rS4+4UJbR4a4K/ZMdcY8cqFBBy5TJ2IRKohJofx4L01cONK1oL56BNfujy8XuAbemmTavTdxWeqy8gO0tKmhwB5dO+EauFEKKrnHmagfj1yVnOplKXFSWR90P6hCwvpi4sp6PbweXf359eHh8fGv/QtXeMJFQSoHariuBAtTDxoZXNtFKsA1Mm8bTlX30qZb6VMup0pBhsAMJ2pgOC9gEic1F9Ta+d5hHgHlu9xa1gKK0PqyeHDdDH349vfT09Pz8/OXT4dq2iW5UYhiZxHyHnuZkVlKThYIakfKc5xzvh7CUl9Fta00luWy86NINbsIC92NApkUcGPbIazELr+xJqWx8FSJ4MuMSlpBUT1WPF2qTkJfF2/cWe0fo9lEwjggfYcAAAAASUVORK5CYII=)](data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAJcAAAAXCAMAAAAx8S2TAAAAyVBMVEX///8AAAB6enr29vb6+vrh4eHYEiJmZmbVAADw8PCvr6/r6+sEBATl5eVgYGBdXV3Q0NDnjI8aGhoVFRWampokJCRCQkKIiIiRkZFXV1cNDQ01NTXZ2dnXABJsbGw8PDzHx8dKSkqioqK8vLwsLCyxDh3qmJv21db88vP76+vwubzcOEDeTVTkdnvmhIjhaG3aJC/rpqjzysuwABTcQ0vMESG9HSmhDBu3ABDIPUS+AAnSVFmYAACjABDFAADaqKqwXGDBYmbMYmZEBJaoAAADtklEQVRIic2Va3ebRhCGZwSIqwADy1VCXFa+JGnk1GnrNk1T+///qL67SLYa6+ikn+h84CDt7swzM+8sREe7pf+l3b2bm+C8vZ8b4Lx9uJ6b4Kz95JhzI5yza+fj3Ajn7J3j3M3NcMZunM1+boYzducsnZu5Id7a7f1y+XluiDP2frN0Tu7UMl+crrruj/gw1bZV0xhn1sKoqqqoeOsnX19yee0sl0u63d/vpw/Rgu1TLGb/B7g6ZiKL+RwX91mWFTW/AeP4kssrlOsT3W+Wm+W/ufSFZgaHWJevt5gFnv53KUxnAl1/n4f/zoWJRNGcn49cbh9ZeSAGWodJYo9kFgmLEot5s4pQmUxyGiqvXV+nVUxjlYh27W9zKreR8rEtyFikLLIXLuKM3NYoc6Jxy1V34Fq3ePOivkQOXWHYGfkLmZeaa/PxwHVz5PI5SaRIuYulSKRHW06rmiuiNO3RsZLrqKnRYLRPJnjxZCJkvGI2Y933GiElC+wNj1wer2jFlWwp47Ir2dNcawZCmHrjNjVpELL3TLZHT1S6Xg939MHZOJ/platGpnlQqBAGfDZEhuSRkiQZYxKMJCUeeY2YOS/gXxz0JRBR/Rq4R/NqbEqFFIIVyIpbpVjV0IxN4vUaRaRRKwX/DmrPiAWyhAuuX74+3NL1/vDhnriUShcIaCq92sEi7uIWiSdgU8KJPXSpM5gxUv7aOuEqEbtEFaqgwBk8qY66cRwXCLpS20c9ABZeOWNVyjDCNJttBC78WqPHxqSv3e7h11dZT1yBccLVJ6ytAlese8Kco17+y7C+clkcoO0WbQ9n2qO+Cp64PBUdVesIi2gubWu9saehJi1Z5sZTXL/tdo+/f8fFp1whimzoJDSXy4FnIHiHSwR+rS4+4UJbR4a4K/ZMdcY8cqFBBy5TJ2IRKohJofx4L01cONK1oL56BNfujy8XuAbemmTavTdxWeqy8gO0tKmhwB5dO+EauFEKKrnHmagfj1yVnOplKXFSWR90P6hCwvpi4sp6PbweXf359eHh8fGv/QtXeMJFQSoHariuBAtTDxoZXNtFKsA1Mm8bTlX30qZb6VMup0pBhsAMJ2pgOC9gEic1F9Ta+d5hHgHlu9xa1gKK0PqyeHDdDH349vfT09Pz8/OXT4dq2iW5UYhiZxHyHnuZkVlKThYIakfKc5xzvh7CUl9Fta00luWy86NINbsIC92NApkUcGPbIazELr+xJqWx8FSJ4MuMSlpBUT1WPF2qTkJfF2/cWe0fo9lEwjggfYcAAAAASUVORK5CYII=)
[![Traders academy online](https://www.google.com/imgres?imgurl=https%3A%2F%2Ftradersacademy.online%2Fwp-content%2Fthemes%2Ftraders-academy%2Fimages%2Fibkr-traders-academy-logo-wht-text.svg&imgrefurl=https%3A%2F%2Ftradersacademy.online%2F&tbnid=-4Q7Mkx2mjQX9M&vet=10CEYQMyiHAWoXChMImI2x4pXf7gIVAAAAAB0AAAAAEAI..i&docid=ULMCJzushG3sVM&w=800&h=151&q=interactive%20Brokers%20client%20logo&client=avast&ved=0CEYQMyiHAWoXChMImI2x4pXf7gIVAAAAAB0AAAAAEAI)](https://www.google.com/imgres?imgurl=https%3A%2F%2Ftradersacademy.online%2Fwp-content%2Fthemes%2Ftraders-academy%2Fimages%2Fibkr-traders-academy-logo-wht-text.svg&imgrefurl=https%3A%2F%2Ftradersacademy.online%2F&tbnid=-4Q7Mkx2mjQX9M&vet=10CEYQMyiHAWoXChMImI2x4pXf7gIVAAAAAB0AAAAAEAI..i&docid=ULMCJzushG3sVM&w=800&h=151&q=interactive%20Brokers%20client%20logo&client=avast&ved=0CEYQMyiHAWoXChMImI2x4pXf7gIVAAAAAB0AAAAAEAI)

This article will go over how to get a basic implementation of the Interactive Brokers TWS API to retrieve stock and option prices.

## **Dependancies:**

First you need to download the [offline TWS installer](https://www.interactivebrokers.com/en/index.php?f=15875), since creating the account is difficult and we should use the offline installer for the sake of the demo. 

Then you have to download the [TWS API](https://www.interactivebrokers.com/en/index.php?f=5041) if you haven’t already. 

## **Preparation:**

Once downloaded, start a new C# console application project. 
I am calling it TWS_API_Demo.

![C# console application project](https://user-images.githubusercontent.com/25592914/107505574-9516b000-6ba5-11eb-9ce7-39d7351ba799.jpg)

 - Once pressing OK, you will be left with a blank project. 

 - The next step will be adding the The next step will be adding the CSharpAPI project. Copy the client folder (~\TWS API\source\CSharpClient\client) to your solution folder and add it to the solution.

 - Add a refence to this project in your TWS_API_Demo project. Right click on References and click “Add Reference”, choose the CSharpClient project. Check it’s box and press “OK”. The solution explorer should now look like.

 - The next step will be adding the CSharpAPI.dll for TWS API functionality. This dll is located in the TWS API folder. My TWS API folder is in my C drive, it will be in where ever you choose during installation. The location of the file is C:\TWS API\source\CSharpClient\client\bin\Debug\CSharpAPI.dll. In your solution explorer

 Your project should looks like this:
![image](https://user-images.githubusercontent.com/25592914/107507296-08b9bc80-6ba8-11eb-868c-1ac81d8d305a.png)

 - Next we will need to make an implementation of the EWrapper class. The EWrapper is the mechanism through which the TWS delivers information to the API client application. There is a basic one provided in a sample located in C:\TWS API\samples\CSharp\Testbed\EWrapperImpl.cs. Put this file into your current project. Do this by right clicking TWS_tutorial in the solution explorer and “Add – Existing Item”. Find and add EWrapperImpl.cs. You will want to change the namespace in EWrapperImpl.cs from Samples to TWS_API_Demo. Now go to Program.cs and replace the code with…

Once you change the EWrapperImpl.cs file namespace to TWS_API_Demo Your project should look like this:
![image](https://user-images.githubusercontent.com/25592914/107507540-62ba8200-6ba8-11eb-86c8-66907a3a1b45.png)


## **Add the following code that tests an offline stockprices and options:**

				using System;
				using IBApi;
				using System.Threading;

				namespace TWS_API_Demo
				{
					class Program
					{
						public static int contractId = 0;

						public static int Main(string[] args)
						{

							EWrapperImpl testImpl = new EWrapperImpl();
							EClientSocket clientSocket = testImpl.ClientSocket;
							EReaderSignal readerSignal = testImpl.Signal;
							//! [connect]
							clientSocket.eConnect("127.0.0.1", 7497, 0);
							//! [connect]
							//! [ereader]
							//Create a reader to consume messages from the TWS. The EReader will consume the incoming messages and put them in a queue
							var reader = new EReader(clientSocket, readerSignal);
							reader.Start();
							//Once the messages are in the queue, an additional thread need to fetch them
							new Thread(() => { while (clientSocket.IsConnected()) { readerSignal.waitForSignal(); reader.processMsgs(); } }) { IsBackground = true }.Start();

							clientSocket.reqMarketDataType(3);
							int tickerId = 100;
							getStockPrice(clientSocket, "AAPL", tickerId);



							int tickerId_Option = 200;
							string expDate = "20190418";
							getContractDetails(clientSocket, "AAPL", tickerId_Option, expDate);


							Thread.Sleep(500);


							Console.WriteLine("Contract Id set to: " + contractId);
							int tickerId_Option_Price = 300;
							getOptionPrice(clientSocket, "AAPL", tickerId_Option_Price, contractId);


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

As you can see we set up a few things like the EWrapperImpl, the EClientSocket, EReaderSignal.

 - We then connect to TWS Offline with clientSocket.eConnect(“127.0.0.1″, 7497, 0); . Make sure your API settings match. So log into TWS if you haven’t already and make sure your settings in ” File – Global Configuration -API – Settings” look like this…

 - You still needs to have an account for the interactive brokers offline desctop app. Try create it or gtest login with from here https://www.interactivebrokers.co.uk/sso/Login?RL=1
 ![image](https://user-images.githubusercontent.com/25592914/107509793-b5496d80-6bab-11eb-94a9-f16540950dc7.png)

After launching the TWS offline you can see the the AAPL symbol we are trying to handle.

 - Make sure you have the right port and configuration options setted up from the TWS offline menu "File"->"Global Configuration"-> "Settings”
![image](https://user-images.githubusercontent.com/25592914/107508422-a95cac00-6ba9-11eb-9253-6efb7ced3058.png)

 - Then run the TWS_API_Demo and check the console dump
![image](https://user-images.githubusercontent.com/25592914/107509531-5e439880-6bab-11eb-8353-db2cbe393598.png)

---
## See also

 [**binance-trading-bot**](https://github.com/motion-software/binance-trading-bot)


## License

[![CC0](https://licensebuttons.net/p/zero/1.0/88x31.png)](https://creativecommons.org/publicdomain/zero/1.0/)

To the extent possible under law, [Motion Software](https://mts.io) has waived all copyright and related or neighboring rights to this work.