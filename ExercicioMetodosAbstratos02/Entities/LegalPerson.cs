namespace Course.Entities
{
  class LegalPerson : Person
  {
    public int NumberOfEmployees { get; set; }

    public LegalPerson(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
    {
      NumberOfEmployees = numberOfEmployees;
    }

    public override double IncomeTax() 
    {
      if(NumberOfEmployees > 10) return AnnualIncome * 0.14;
      return AnnualIncome * 0.16;
    }
  }
}