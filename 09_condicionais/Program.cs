using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Executando projeto 8 - Condicionais 2");

    int idadeJoao = 16;
    // int quantidadePessoas = 2;
    // bool acompanhado = quantidadePessoas >= 2;
    bool acompanhado = false;

    if (idadeJoao >= 18 || acompanhado == true)
    // if (idadeJoao >= 18 && acompanhado == true)
    {
      Console.WriteLine("Entrada liberada!");
    }
    else
    {
      Console.WriteLine("Entrada proibida!");
    }
    Console.ReadLine();
  }
}
