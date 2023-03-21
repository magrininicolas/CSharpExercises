namespace Entities
{
  class Contract
  {
    public int Number { get; set; }
    public DateTime ContractDate { get; set; }
    public double ContractValue { get; set; }
    public List<Installment> Installments = new List<Installment>();

    public Contract() { }

    public Contract(int number, DateTime contractDate, double contractValue)
    {
      Number = number;
      ContractDate = contractDate;
      ContractValue = contractValue;
    }

    public void AddInstallment(Installment installment)
    {
      Installments.Add(installment);
    }
  }
}