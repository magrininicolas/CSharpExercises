namespace ExercicioEstoque
{
  class Program
  {
    static void Main(string[] args)
    {
      Produto p = new();

      Console.WriteLine("Entre os dados do produto: ");
      Console.Write("Nome: ");
      p.Nome = Console.ReadLine();
      Console.Write("Preço: ");
      p.Preco = double.Parse(Console.ReadLine());
      Console.Write("Quantidade no estoque: ");
      p.Quantidade = int.Parse(Console.ReadLine());
      
      Console.WriteLine(p);

      Console.WriteLine();
      Console.Write("Digite o número de produtos que serão adicionados: ");
      int qte = int.Parse(Console.ReadLine());
      p.AdicionarProdutos(qte);
      Console.WriteLine("Dados atualizados: " + p);

      Console.WriteLine();
      Console.Write("Digite o número de produtos que serão removidos: ");
      qte = int.Parse(Console.ReadLine());
      p.RemoverProdutos(qte);
      Console.WriteLine("Dados atualizados: " + p);
    }
  }
}