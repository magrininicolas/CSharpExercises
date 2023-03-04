using Course.Entities.Enums;

namespace Course.Entities
{
  class Worker
  {
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    private double BaseSalary { get; set; }
    public string DepartmentName { get; set; }
    public List<HourContract> Contracts { get; set; } = new List<HourContract>();

    public Worker() { }

    public Worker(string name, WorkerLevel level, double baseSalary, string department)
    {
      Name = name;
      Level = level;
      BaseSalary = baseSalary;
      DepartmentName = department;
    }

    public void AddContract(HourContract contract)
    {
      Contracts.Add(contract);
    }

    public void RemoveContract(HourContract contract)
    {
      Contracts.Remove(contract);
    }

    public double Income(int month, int year)
    {
      double sum = BaseSalary;
      foreach (HourContract contract in Contracts)
      {
        if (contract.Date.Year == year && contract.Date.Month == month)
        {
          sum += contract.TotalValue();
        }
      }
      return sum;
    }
  }
}