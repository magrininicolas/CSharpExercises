namespace ExercicioBanco
{
  class Program
  {
    static void Main(string[] args)
    {
      ContaBancaria c1 = new(0, "Nicolas");

      Console.Write("Digite o número da conta bancária: ");
      int numeroConta = int.Parse(Console.ReadLine());
      Console.Write("Digite o nome do titular da conta: ");
      c1.TitularConta = Console.ReadLine();
      Console.Write("Haverá depósito inicial? (s/n): ");
      char resposta = char.Parse(Console.ReadLine());

      if (resposta == 's' || resposta == 'S')
      {
        Console.Write("Digite o valor do depósito inicial: ");
        double valorDepositoInicial = double.Parse(Console.ReadLine());
        c1.Deposito(valorDepositoInicial);
        c1 = new(numeroConta, c1.TitularConta, valorDepositoInicial);
      } else { c1 = new(numeroConta, c1.TitularConta); }
      
      Console.WriteLine($"Dados da conta: {c1}");

      Console.WriteLine();
      Console.Write("Entre um valor para depósito: ");
      double valorDeposito = double.Parse(Console.ReadLine());
      c1.Deposito(valorDeposito);
      Console.WriteLine($"Dados da conta atualizados: {c1}");

      Console.WriteLine();
      Console.Write("Entre um valor para saque: ");
      double valorSaque = double.Parse(Console.ReadLine());
      c1.Saque(valorSaque);
      Console.WriteLine($"Dados da conta atualizados: {c1}");
    }
  }
}