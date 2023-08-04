// See https://aka.ms/new-console-template for more information
using Interfaces;

Console.WriteLine("Hello, World!");

SaverAccount saverAccount = new SaverAccount();

saverAccount.PayIn(100);
saverAccount.PayIn(200);
saverAccount.PayIn(150);
saverAccount.Withdraw(120);
saverAccount.Withdraw(1200);
Console.WriteLine(saverAccount);