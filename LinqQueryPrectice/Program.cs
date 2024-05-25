// See https://aka.ms/new-console-template for more information
using LinqQueryPrectice.DataProvider;
using LinqQueryPrectice.QueryLogic;
using LinqQueryPrectice.View;

Console.WriteLine("Hello, World!");

LinqDataProvider dataProvider = new LinqDataProvider();
ConsolePrint consolePrinter = new ConsolePrint();

QueryExecutor queryExecutor = new QueryExecutor(dataProvider, consolePrinter);
queryExecutor.CreateAndRunQuery();
