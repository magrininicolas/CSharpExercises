namespace Notas{
  class Program{
    static void Main (string[] args){
      Aluno aluno = new();

      Console.Write("Nome do aluno: ");
      aluno.Nome = Console.ReadLine();
      Console.WriteLine("Digite as três notas do aluno: ");
      aluno.Nota1 = double.Parse(Console.ReadLine());
      aluno.Nota2 = double.Parse(Console.ReadLine());
      aluno.Nota3 = double.Parse(Console.ReadLine());

      Console.Write("NOTA FINAL = " + aluno.CalculaNotaFinal().ToString("F2"));
      Console.WriteLine();

      if(aluno.SituacaoAluno()){
        Console.WriteLine("APROVADO");
      } else {
        Console.WriteLine("REPROVADO");
        Console.WriteLine("FALTARAM " + aluno.PontuacaoRestante().ToString("F2") + " PONTOS.");
      }
    }
  }
}