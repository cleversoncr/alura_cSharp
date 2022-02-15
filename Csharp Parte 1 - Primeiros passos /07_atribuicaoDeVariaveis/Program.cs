using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Executando o projeto 6 - atribuicao de variaveis");

    int idade = 43;
    int idadeCleverson = idade;

    idade = 20;

    Console.WriteLine(idade);
    Console.WriteLine(idadeCleverson);

    Console.ReadLine();
  }
}