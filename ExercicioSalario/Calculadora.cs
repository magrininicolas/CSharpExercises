namespace ExercicioFuncionario{
  class Calculadora{
    public static double SalarioLiquido(double salario, double iof){
      return salario - iof;
    }
    
    public static double AumentaSalario(int porcentagem, double salario){
      return salario += (salario * porcentagem / 100.0);
    }
  }
}