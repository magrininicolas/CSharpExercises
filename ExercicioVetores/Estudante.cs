namespace ExercicioVetor{
  class Hospede{
    public string Name { get; set; }
    public string Email { get; set; }

    public Hospede(string name, string email){
      Name = name;
      Email = email;
    }

    public override string ToString()
    {
      return $"{Name}, {Email}";
    }
  }
}