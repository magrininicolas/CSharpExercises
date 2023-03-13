using Course.Entities;
using System.Globalization;

namespace Course
{
  class Program
  {
    static void Main(string[] args) 
    {
      List<Product> list = new List<Product>();

      Console.Write("Enter the number of products: ");
      int n = int.Parse(Console.ReadLine());

      for(int i = 1; i <= n; i++) 
      {
        Console.WriteLine($"Product #{i} data:");
        Console.Write("Common, used or imported? (c/u/i) ");
        char resp = char.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());
        switch (resp) 
        {
          case 'c':
          list.Add(new Product(name, price));
          break;
          
          case 'u':
          Console.Write("Manufacture Date: (DD/MM/YYYY): ");
          DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
          list.Add(new UsedProduct(name, price, date));
          break;

          case 'i':
          Console.Write("Customs fee: ");
          double customsfee = double.Parse(Console.ReadLine());
          list.Add(new ImportedProduct(name, price, customsfee));
          break;
        }
      }

      Console.WriteLine("\nPrice tags: ");
      foreach(Product prod in list) 
      {
        Console.WriteLine(prod.PriceTag());
      }
    }
  }
}