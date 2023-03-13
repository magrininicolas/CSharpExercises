using Course.Entities;

namespace Course
{
  class Program 
  {
    static void Main(string[] args) 
    {
      List<Employee> list = new List<Employee>();


      Console.Write("Enter the number of employees: ");
      int N = int.Parse(Console.ReadLine());

      for(int i = 1; i <= N; i++)
      {
        Console.WriteLine($"Employee #{i} data: ");
        Console.Write("Outsourced (y/n)? ");
        char resp = char.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Value per hour: ");
        double valuePerHour = double.Parse(Console.ReadLine());
        if(resp == 'y' || resp == 'Y') 
        {
          Console.Write("Additional charge: ");
          double addtionalCharge = double.Parse(Console.ReadLine());
          list.Add(new OutsourcedEmployee(name, hours, valuePerHour, addtionalCharge));
        } 
        else if(resp == 'n' || resp == 'N') 
        {
          list.Add(new Employee(name, hours, valuePerHour));
        }
      }

      Console.WriteLine("\nPAYMENTS: ");
      foreach(Employee emp in list)
      {
        Console.WriteLine($"{emp.Name} - ${emp.Payment().ToString("F2")}");
      }
    } 
  }
}