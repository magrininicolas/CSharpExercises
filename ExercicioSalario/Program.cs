namespace ExercicioFuncionario
{
  class Program
  {
    static void Main(string[] args)
    {

      Funcionario f1 = new();

      Console.Write("Nome: ");
      f1.Nome = Console.ReadLine();
      Console.Write("Salário bruto: ");
      f1.SalarioBruto = double.Parse(Console.ReadLine());
      Console.Write("Imposto: ");
      f1.Imposto = double.Parse(Console.ReadLine());

      Console.Write("Funcionário: " + f1);

      Console.WriteLine();
      Console.Write("Digite a porcentagem de aumento do salário: ");
      int porcentagem = int.Parse(Console.ReadLine());
      
      f1.AumentaSalario(porcentagem);

      Console.WriteLine("Dados atualizados: " + f1);
      
    }
  }
}