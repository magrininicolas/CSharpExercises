namespace ExercicioFuncionario
{
  class Funcionario
  {
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido(){
      return SalarioBruto - Imposto;
    }
    
    public double AumentaSalario(int porcentagem){
      return SalarioBruto += (SalarioBruto * porcentagem / 100.0);
    }

    public override string ToString()
    {
      return Nome + ", $" + SalarioLiquido().ToString("F2");
    }
  }
}