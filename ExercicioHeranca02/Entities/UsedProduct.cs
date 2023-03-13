namespace Course.Entities
{
  class UsedProduct : Product
  {
    public DateTime ManufactureDate { get; set; }

    public UsedProduct() { } 

    public UsedProduct(string name, double price, DateTime manufacturedate) : base(name, price)
    {
      ManufactureDate = manufacturedate;
    }

    public override string PriceTag()
    {
      return $"{Name} (used) ${Price.ToString("F2")} (Manufacture date: {ManufactureDate})";
    }
  }
}