using System;

class Program {
  public static void Main (string[] args)
  {
    Console.WriteLine ("Co chcesz zrobić 1-odjąc, 2-dodać, 3-pomnożyć, 4-podzielić");
    int wybor = int.Parse(Console.ReadLine());
    if (wybor == 1)
    {
      Console.WriteLine("Podaj A");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj B");
      int b = int.Parse(Console.ReadLine());
      int wynik = a - b;
      Console.WriteLine($"{a} - {b} = {wynik}");
    }
    if (wybor == 2)
    {
      Console.WriteLine("Podaj A");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj B");
      int b = int.Parse(Console.ReadLine());
      int wynik = a + b;
      Console.WriteLine($"{a} + {b} = {wynik}");
    }
    if (wybor == 3)
    {
      Console.WriteLine("Podaj A");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj B");
      int b = int.Parse(Console.ReadLine());
      int wynik = a * b;
      Console.WriteLine($"{a} x {b} = {wynik}");
    }
    if (wybor == 4)
    {
      Console.WriteLine("Podaj A");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj B");
      int b = int.Parse(Console.ReadLine());
      int wynik = a / b;
      Console.WriteLine($"{a} : {b} = {wynik}");
    }
  }
}