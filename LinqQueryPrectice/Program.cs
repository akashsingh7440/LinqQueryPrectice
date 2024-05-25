// See https://aka.ms/new-console-template for more information
using LinqQueryPrectice.DataProvider;
using LinqQueryPrectice.QueryLogic;
using LinqQueryPrectice.View;

Console.WriteLine("Hello, World!");

LinqDataProvider translator = new LinqDataProvider();
ConsolePrint linqPrectice = new ConsolePrint();

QueryExecutor queryExecutor = new QueryExecutor(translator, linqPrectice);
queryExecutor.CreateAndRunQuery();
