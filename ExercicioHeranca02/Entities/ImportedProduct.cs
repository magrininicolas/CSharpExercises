namespace Course.Entities
{
  class ImportedProduct : Product
  {
    public double CustomsFee { get; set; }

    public ImportedProduct() { }

    public ImportedProduct(string name, double price, double customsfee) : base(name, price)
    {
      CustomsFee = customsfee;
    }

    public double TotalPrice() 
    {
      return Price + CustomsFee;
    }

    public override string PriceTag()
    {
      return $"{Name} ${TotalPrice().ToString("F2")} (Customs fee: ${CustomsFee.ToString("F2")})";
    }
  }
}