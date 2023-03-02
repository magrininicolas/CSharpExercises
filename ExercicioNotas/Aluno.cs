namespace Notas
{
  class Aluno
  {
    public string Nome;
    public double Nota1, Nota2, Nota3;

    public double CalculaNotaFinal()
    {
      return Nota1 + Nota2 + Nota3;
    }

    public bool SituacaoAluno()
    {
      if (CalculaNotaFinal() >= 60) return true;
      else return false;
    }

    public double PontuacaoRestante()
    {
      if (SituacaoAluno()) return 0.0;
      else return 60.0 - CalculaNotaFinal();
    }
  }
}