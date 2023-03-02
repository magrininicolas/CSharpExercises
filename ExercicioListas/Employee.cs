namespace ListExercise{
  class Employee{
    private int _id;
    public string Name { get; set; }
    public double Salary { get; private set; }

    public Employee() { }

    public Employee(int id, string name, double salary) {
      _id = id;
      Name = name;
      Salary = salary;
    } 

    public int Id {
      get { return _id; }
      set{
        if(value != null && value.ToString().Length == 3) _id = value;
      }
    }

    public void IncreaseSalary(double percentage){ Salary += Salary * percentage / 100.0; }

    public override string ToString() { return $"{_id}, {Name}, {Salary.ToString("F2")}"; }
  }
}