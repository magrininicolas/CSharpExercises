using Course.Entities;
using System.IO;
using System.Collections.Generic;

Console.Write("Enter path for folder: ");
string sourceFilePath = Console.ReadLine();

try
{
  List<Product> list = new List<Product>();

  Console.Write("How many products will you register? ");
  int n = int.Parse(Console.ReadLine());

  for(int i = 1; i <= n; i++)
  {
    Console.WriteLine($"Enter #{i} product's data: ");
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());
    list.Add(new Product(name, price, quantity));
  }

  using(StreamWriter swFile1 = File.AppendText(@$"{sourceFilePath}/file1.csv"))
  {
    foreach(Product p in list)
    {
      swFile1.WriteLine(p);
    }
  }

  Directory.CreateDirectory($"{sourceFilePath}/out");
  using(StreamWriter swFile2 = File.AppendText(@$"{sourceFilePath}/out/summary.csv"))
  {
    foreach(Product p in list)
    {
      swFile2.WriteLine($"{p.Name}, {p.TotalPrice().ToString("F2")}");
    }
  }

  string[] lines = File.ReadAllLines(@$"{sourceFilePath}/out/summary.csv");
  foreach(string line in lines) Console.WriteLine($"\n{line}");
}
catch(IOException e)
{
  Console.WriteLine($"An error has occurred: {e.Message}");
}
