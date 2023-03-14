namespace Course.Entities
{
  class NaturalPerson : Person
  {
    public double HealthExpenses { get; set; }

    public NaturalPerson(string name, double annualIncome, double healthExpenses) : base(name, annualIncome)
    {
      HealthExpenses = healthExpenses;
    }

    public override double IncomeTax()
    { 
      double tax = 0.0; 
      if(AnnualIncome < 20000) tax = AnnualIncome * 0.15;
      if(AnnualIncome >= 20000) tax = AnnualIncome * 0.25;
      if(HealthExpenses > 0) tax -= HealthExpenses * 0.5;
      return tax;
    }
  }
}