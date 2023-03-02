namespace ExercicioEstoque
{
  class Produto
  {

    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEstoque()
    {
      return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade)
    {
      Quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
      Quantidade -= quantidade;
    }

    public override string ToString()
    {
      return "Produto: " + Nome + ", $" + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: $" + ValorTotalEstoque().ToString("F2");
    }
  }
}