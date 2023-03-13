namespace Course.Entities
{
  class OutsourcedEmployee : Employee
  {
    public double AddtionalCharge { get; set; }

    public OutsourcedEmployee() { }

    public OutsourcedEmployee(string name, int hours, double valueperhour, double additionalcharge) : base(name, hours, valueperhour)
    {
      AddtionalCharge = additionalcharge;
    }

    public override double Payment()
    {
      return base.Payment() + 1.1 * AddtionalCharge;
    }
  }
}