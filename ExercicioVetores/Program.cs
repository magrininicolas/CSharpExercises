namespace ExercicioVetor
{
  class Program
  {
    static void Main(string[] args)
    {
      Hospede[] hotelVect = new Hospede[10];
      Console.Write("How many rooms will be rented? ");
      int n = int.Parse(Console.ReadLine());
      
      for (int i = 0; i < n; i++){
        Console.WriteLine($"Rent #{i+1}:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write($"Email: ");
        string email = Console.ReadLine();
        Console.Write($"Room: ");
        int room = int.Parse(Console.ReadLine());
        hotelVect[room] = new Hospede(name, email);
      }

      Console.WriteLine();
      Console.WriteLine("Busy rooms: ");
      for(int i = 0; i < hotelVect.Length; i++){
        if(hotelVect[i] != null) { Console.WriteLine($"{i}: {hotelVect[i]}"); }
      }
    }
  }
}