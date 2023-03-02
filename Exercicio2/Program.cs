namespace Exercicio2
{
  class Program
  {
    static void Main(string[] args)
    {
      Funcionario f1 = new();
      Funcionario f2 = new();

      Console.WriteLine("Dados do primeiro funcionário: ");
      Console.Write("Nome: ");
      f1.Nome = Console.ReadLine();
      Console.Write("Salário: ");
      f1.Salario = double.Parse(Console.ReadLine());

      Console.WriteLine("Dados do segundo funcionário: ");
      Console.Write("Nome: ");
      f2.Nome = Console.ReadLine();
      Console.Write("Salário: ");
      f2.Salario = double.Parse(Console.ReadLine());
      
      double salarioMedio = (f1.Salario + f2.Salario) / 2.00;

      Console.Write("Salário médio: " + salarioMedio.ToString("F2"));
    }
  }
}