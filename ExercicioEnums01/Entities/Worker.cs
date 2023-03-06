using Course.Entities.Enums;

namespace Course.Entities
{
  class Worker
  {
    private double _baseSalary;
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public string DepartmentName { get; set; }
    public List<HourContract> Contracts { get; set; } = new List<HourContract>();

    public Worker() { }

    public Worker(string name, WorkerLevel level, double baseSalary, string department)
    {
      Name = name;
      Level = level;
      _baseSalary = baseSalary;
      DepartmentName = department;
    }

    public double BaseSalary
    {
      get { return _baseSalary; }
      set { if (value != null) _baseSalary = value; }
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