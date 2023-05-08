// See https://aka.ms/new-console-template for more information
using TaxCalculationConsoleApplication;

Console.WriteLine("Income Tax Calculation");

Tax tax = new();
Console.WriteLine($"Total tax = {tax.CalculateTax(10, 5000)}");

Console.ReadKey();