using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;

namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter client data: ");
      Console.Write("Name: ");
      string clientName = Console.ReadLine();
      Console.Write("Email: ");
      string email = Console.ReadLine();
      Console.Write("Birth date (DD/MM/YYYY): ");
      DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
      Client client = new Client(clientName, email, birthDate);
      Console.WriteLine("Enter order data: ");
      Console.Write("Status: ");
      OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
      DateTime orderMoment = DateTime.Now;
      Order order = new Order(orderMoment, status, client);
      Console.Write("How many items to this order? ");
      int n = int.Parse(Console.ReadLine());
      for (int i = 1; i <= n; i++)
      {
        Console.WriteLine($"Enter #{i} item data: ");
        Console.Write("Product name: ");
        string productName = Console.ReadLine();
        Console.Write("Product price: ");
        double productPrice = double.Parse(Console.ReadLine());
        Console.Write("Quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        Product product = new Product(productName, productPrice);
        OrderItem item = new OrderItem(quantity, productPrice, product);
        order.AddItem(item);
      }
      Console.WriteLine();
      Console.WriteLine("ORDER SUMMARY: ");
      Console.WriteLine(order);
    }
  }
}