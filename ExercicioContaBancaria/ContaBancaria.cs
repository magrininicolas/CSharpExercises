namespace ExercicioBanco
{
  class ContaBancaria
  {
    public int NumeroConta { get; private set; }
    private string _titularConta;
    public double Saldo { get; private set; }

    public ContaBancaria(int numero, string titular)
    {
      NumeroConta = numero;
      _titularConta = titular;
    }

    public ContaBancaria(int numero, string titular, double depositoIncial) : this(numero, titular)
    {
      Deposito(depositoIncial);
    }

    public string TitularConta
    {
      get { return _titularConta; }
      set { if (value != null && value.Length > 2) _titularConta = value; }
    }

    public void Deposito(double valorDeposito) { Saldo += valorDeposito; }

    public void Saque(double valorSaque) { Saldo -= valorSaque + 5.0; }

    public override string ToString()
    {
      return $"Conta {NumeroConta}, Titular: {_titularConta}, Saldo: ${Saldo.ToString("F2")}";
    }
  }
}