// See https://aka.ms/new-console-template for more information
using Chain_Of_Responsiblity;

Console.WriteLine("Hello, Chain of responsiblity pattern!");

LogProcessor logProcessor = new InfoLogProcessor(new DebugLogProcessor(new ErrorLogProcessor(null)));
logProcessor.Log(LogProcessor.ERROR, "Exception Happened");
logProcessor.Log(LogProcessor.DEBUG, "Debug this");
logProcessor.Log(LogProcessor.ERROR, "Just for info");

Console.ReadKey();
