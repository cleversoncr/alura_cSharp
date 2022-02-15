using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Executando projeto 14");

    double valorInvestido = 1000.00;

    for (int i = 1; i <= 12; i++)
    {
      valorInvestido *= 1.0036;
      Console.WriteLine($"Após {i} mês, você terá R${valorInvestido}");
    }
    Console.ReadLine();
  }
}