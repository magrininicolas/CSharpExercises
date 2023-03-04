using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;

namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter department's name: ");
      string deptName = Console.ReadLine();
      Console.WriteLine("Enter worker's data: ");
      Console.Write("Name: ");
      string name = Console.ReadLine();
      Console.Write("Level (Junior/MidLevel/Senior): ");
      WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
      Console.Write("Base salary: ");
      double baseSalary = double.Parse(Console.ReadLine());

      Worker worker = new Worker(name, level, baseSalary, deptName);

      Console.Write("How many contracts to this worker? ");
      int N = int.Parse(Console.ReadLine());

      for (int i = 1; i <= N; i++)
      {
        Console.WriteLine($"Enter #{i} contract data: ");
        Console.Write("Date (DD/MM/YYYY): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Value per hour: ");
        double valuePerHour = double.Parse(Console.ReadLine());
        Console.Write("Contract's duration (hours): ");
        int hours = int.Parse(Console.ReadLine());
        HourContract contract = new HourContract(date, valuePerHour, hours);
        worker.AddContract(contract);
      }
      Console.WriteLine();
      Console.Write("Enter month and year to calculate income (MM/YYYY): ");
      string monthAndYear = Console.ReadLine();
      int month = int.Parse(monthAndYear.Substring(0, 2));
      int year = int.Parse(monthAndYear.Substring(3));

      Console.WriteLine("Worker's data: ");
      Console.WriteLine($"Name: {name}");
      Console.WriteLine($"Department: {deptName}");
      Console.WriteLine($"Income for: {month}/{year}: {worker.Income(month, year)}");
    }
  }
}