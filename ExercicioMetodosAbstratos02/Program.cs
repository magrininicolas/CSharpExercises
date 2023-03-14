using Course.Entities;

namespace Course
{
  class Program
  {
    static void Main(string[] args) 
    {
      List<Person> list = new List<Person>();

      Console.Write("Enter the number of tax payers: ");
      int n = int.Parse(Console.ReadLine());

      for(int i = 1; i<=n; i++)
      {
        Console.WriteLine($"Tax payer #{i} data: ");
        Console.Write("Individual or company (i/c)? " );
        char resp = char.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Annual income: ");
        double annualIncome = double.Parse(Console.ReadLine());
        Console.Write("Health Expenses (0 if not): ");
        if(resp == 'i') 
        {
          Console.Write("Health Expenses (0 if not): ");
          double healthExpenses = double.Parse(Console.ReadLine());
          list.Add(new NaturalPerson(name, annualIncome, healthExpenses));
        }
        if(resp == 'c') 
        {
          Console.Write("Number of employees: ");
          int numberOfEmployees = int.Parse(Console.ReadLine());
          list.Add(new LegalPerson(name, annualIncome, numberOfEmployees));
        }

      }

      Console.WriteLine("\nTAXES PAID: ");
      foreach(Person p in list)
      {
        Console.WriteLine($"{p.Name}: ${p.IncomeTax().ToString("F2")}");
      }

      double sum = 0.0;
      foreach(Person p in list) 
      {
        sum += p.IncomeTax();
      }

      Console.WriteLine($"\nTOTAL TAXES: {sum.ToString("F2")}");
    }
  }
}