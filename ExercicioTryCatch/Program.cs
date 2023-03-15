using Course.Entities;
using Course.Entities.Exceptions;

Console.WriteLine("Enter account data: ");
Console.Write("Number: ");
int accNumber = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string holder = Console.ReadLine();
Console.Write("Initial balance: ");
double balance = double.Parse(Console.ReadLine());
Console.Write("Withdraw limit: ");
double withdrawLimit = double.Parse(Console.ReadLine());
Account acc = new Account(accNumber, holder, balance, withdrawLimit);

Console.Write("Enter a amount for withdraw: ");
double amount = double.Parse(Console.ReadLine());

try
{
  acc.Withdraw(amount);
  Console.Write($"New balance: {acc.Balance.ToString("F2")}");
}
catch (OperationException e)
{
  Console.WriteLine($"Withdraw error: {e.Message}!");
}