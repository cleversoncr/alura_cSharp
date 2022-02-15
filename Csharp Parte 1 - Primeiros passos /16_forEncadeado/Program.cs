using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Projeto 16");

    //Utilizando breack
    for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
    {
      for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
      {
        Console.Write("*");
        if (contadorColuna >= contadorLinha)
          break;
      }
      Console.WriteLine();
    }

    //Um faorma diferente
    for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
    {
      for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
        Console.Write("*");

      Console.WriteLine();
    }
    Console.ReadLine();
  }
}
