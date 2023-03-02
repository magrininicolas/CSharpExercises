namespace ConverteMoeda
{
  class Conversor
  {

    public static double ConversorDolar(double cotacao, double quantiaDolares)
    {
      return quantiaDolares * cotacao + (quantiaDolares * cotacao * 0.06);
    }

  }
}