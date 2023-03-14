using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Shape> list = new List<Shape>();

      Console.Write("Enter the number of shapes: ");
      int n = int.Parse(Console.ReadLine());

      for(int i = 1; i<=n; i++)
      {
        Console.Write($"Shape #{i} data");
        Console.Write("Rectangle or circle (r/c)? ");
        char resp = char.Parse(Console.ReadLine());
        Console.Write("Color (black/blue/red): ");
        Color color = Color.Parse<Color>(Console.ReadLine());
        if(resp == 'r')
        {
          Console.Write("Width: ");
          double width = double.Parse(Console.ReadLine());
          Console.Write("Height: ");
          double height = double.Parse(Console.ReadLine());
          list.Add(new Rectangle(width, height, color));
        }
        else if(resp == 'c') 
        {
          Console.Write("Radius: ");
          double radius = double.Parse(Console.ReadLine());
          list.Add(new Circle(radius, color));
        }
      }

      Console.WriteLine("\nShape Areas: ");
      foreach(Shape fig in list) 
      {
        Console.WriteLine($"Color: {fig.Color}, Area: {fig.Area()}");
      }
    }
  }
}