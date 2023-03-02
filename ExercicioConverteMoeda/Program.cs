namespace ConverteMoeda
{
  class Program
  {
    static void Main()
    { 

      Console.Write("Qual a cotação do dólar? ");
      double cotacaoAtual = double.Parse(Console.ReadLine());

      Console.Write("Quantos dólares você vai comprar? ");
      double quantidadeDolares = double.Parse(Console.ReadLine());

      Console.Write("Valor a ser pago em reais = " + Conversor.ConversorDolar(cotacaoAtual, quantidadeDolares).ToString("F2"));
    }
  }
}