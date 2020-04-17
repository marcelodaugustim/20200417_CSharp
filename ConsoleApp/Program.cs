using System;

class Program
{
    static void Main(string[] args)
    {
        Exemplo1(); 
    }

    private static void Exemplo1()
    {
        //Exemplo do uso de entradas e saídas
        //Console.Write(): dá a saída SEM pular linha depois.
        Console.Write("Informe seu nome: ");
        //Console.ReadLine(): lê toda a entrada (até o usuário dar enter).
        string nome = Console.ReadLine();
        //Console.WriteLine: dá a saída e pula uma linha depois.
        Console.WriteLine("Seja bem-vindo, " + nome + ".");
    }
}