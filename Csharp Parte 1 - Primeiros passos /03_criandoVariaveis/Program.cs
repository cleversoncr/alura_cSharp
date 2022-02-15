using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Olá novo teste");

    int idade = 43;
    Console.WriteLine("Minha idade é " + idade + "!");

    idade += 10;
    Console.WriteLine(idade);

    idade -= 50;
    Console.WriteLine(idade);

    idade *= 2;
    Console.WriteLine(idade);

    idade /= 2;
    Console.WriteLine(idade);
  }
}