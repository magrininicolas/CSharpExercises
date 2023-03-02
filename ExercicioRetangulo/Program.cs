namespace ExercicioRetangulo
{
  class Program
  {
    static void Main(string[] args)
    {

      Retangulo ret = new();

      Console.Write("Digite a largura do retângulo: ");
      ret.Largura = double.Parse(Console.ReadLine());
      Console.Write("Digite a altura do retângulo: ");
      ret.Altura = double.Parse(Console.ReadLine());

      Console.Write("Área = " + ret.Area().ToString("F2"));
      Console.WriteLine();
      Console.Write("Perímetro = " + ret.Perimetro().ToString("F2"));
      Console.WriteLine();
      Console.Write("Diagonal = " + ret.Diagonal().ToString("F2"));

    }
  }
}