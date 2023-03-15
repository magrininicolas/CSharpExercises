namespace Course.Entities.Exceptions
{
  class OperationException : InvalidOperationException
  {
    public OperationException(string message) : base(message) { }
  }
}