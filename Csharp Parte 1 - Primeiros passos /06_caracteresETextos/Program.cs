using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

    //character
    char primeiraLetra = 'a';
    Console.WriteLine(primeiraLetra);

    primeiraLetra = (char)65;
    Console.WriteLine(primeiraLetra);

    primeiraLetra = (char)(primeiraLetra + 1);
    Console.WriteLine(primeiraLetra);

    string titulo = $"Alura Cursos de tecnologia {2020}";
    string cusosProgramacao = " - .NET" +
    " - Java" +
    " - JavaScript";

    string cusosProgramacao2 =
@"- .NET
- Java
- JavaScript";

    Console.WriteLine(titulo);
    Console.WriteLine(cusosProgramacao);
    Console.WriteLine(cusosProgramacao2);


    Console.ReadLine();
  }
}