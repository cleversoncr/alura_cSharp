using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Executando projeto 9 - Escopo");

    int idadeJoao = 16;
    bool acompanhado = false;
    string mensagemAdicional;

    if (acompanhado == true)
    {
      mensagemAdicional = "João está acompanhado!";
    }
    else
    {
      mensagemAdicional = "João não está acompanhado!";
    }

    if (idadeJoao >= 18 || acompanhado == true)
    {
      Console.WriteLine("Entrada liberada!");
      Console.WriteLine(mensagemAdicional);
    }
    else
    {
      Console.WriteLine("Entrada proibida!");
    }
    Console.ReadLine();
  }
}