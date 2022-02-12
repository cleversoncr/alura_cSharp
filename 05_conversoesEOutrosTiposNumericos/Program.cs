using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Executando o projeto 5");

    //O double tem uma precisão maior após a virgula
    double salario = 1200.50;

    //O int é um tipo de variável que suporta valores de até 32 bits
    int salarioEmInteiro = (int)salario; //casting

    //O long é uma variável de 64 bits
    long idade = 130000000000;

    //O short é um tipo de variável de 16 bits
    short quantidadeProdutos = 15000;

    //A precisão pós virgula do float é inferior a do double | O sufixo f diz para o C# que queremos utilizar o float
    float altura = 1.76f;

    Console.WriteLine($"Conversão {salarioEmInteiro}");
    Console.WriteLine(idade);
    Console.WriteLine(quantidadeProdutos);
    Console.WriteLine(altura);
  }
}