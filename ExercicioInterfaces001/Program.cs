using Entities;
using Services;
using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine());
Console.Write("Enter number of installments: ");
int installments = int.Parse(Console.ReadLine());

Contract myContract = new Contract(number, date, contractValue);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(myContract, installments);

using(StreamWriter sw = File.AppendText(@"/home/nicolas/Desktop/installments.csv"))
{
  foreach(Installment installment in myContract.Installments)
  {
    sw.WriteLine(installment);
  }
}

Console.WriteLine("Installments: ");
foreach(Installment installment in myContract.Installments)
{
  Console.WriteLine(installment);
}