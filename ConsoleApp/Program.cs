using System;

class Program
{
    static void Main(string[] args)
    {
        //Chame aqui um dos métodos para testá-lo. 

    }

    private static void Exemplo9Switch()
    {
        int opcao = Int32.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Foi escolhida a opção 1.");
                break;
            case 2:
                Console.WriteLine("Foi escolhida a opção 2.");
                break;
            default:
                Console.WriteLine("Foi escolhida outra opção.");
                break;
        }
    }

    private static void Exemplo8DoWhile()
    {
        int i = 100;
        //do-while: SEMPRE realiza a primeira execução.
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 5);
    }

    private static void Exemplo7While()
    {
        int n = 0;
        while (n < 5)
        {
            Console.Write("Informe um valor inteiro: ");
            int idade = Int32.Parse(Console.ReadLine());

            if (idade >= 18 && idade < 65) //ATENÇÃO: A condição SEMPRE entre parênteses.
            {
                Console.WriteLine("Adulto.");
                Console.WriteLine("");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Menor de idade.");
            }
            else
            {
                Console.WriteLine("Terceira idade.");
            }

            n++;
        }
    }

    private static void Exemplo6For()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Informe um valor inteiro: ");
            int idade = Int32.Parse(Console.ReadLine());

            if (idade >= 18 && idade < 65) //ATENÇÃO: A condição SEMPRE entre parênteses.
            {
                Console.WriteLine("Adulto.");
                Console.WriteLine("");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Menor de idade.");
            }
            else
            {
                Console.WriteLine("Terceira idade.");
            }
        }
    }

    private static void Exemplo5IfElse()
    {
        Console.Write("Informe um valor inteiro: ");
        int idade = Int32.Parse(Console.ReadLine());

        if (idade >= 18 && idade < 65) //ATENÇÃO: A condição SEMPRE entre parênteses.
        {
            Console.WriteLine("Adulto.");
            Console.WriteLine("");
        }
        else if (idade < 18)
        {
            Console.WriteLine("Menor de idade.");
        }
        else
        {
            Console.WriteLine("Terceira idade.");
        }
    }

    private static void Exemplo4Matematica()
    {
        int x = 5;
        int y = 3;
        Console.WriteLine(Math.Pow(x, y));      // potência cúbica (5 elevado a 3) 
        Console.WriteLine(Math.Pow(x, 1.0 / y));  // raiz cúbica (5 elevado a 1/3) 
    }

    private static void Exemplo3CalcularSalario()
    {
        Console.Write("Informe o valor do salário: R$");
        double salario = Double.Parse(Console.ReadLine());
        Console.Write("Informe o reajuste (em %): ");
        double reajuste = Double.Parse(Console.ReadLine());
        double novoSalario = Math.Round(salario * (1 + reajuste / 100), 2);
        string novoSalarioFormat = string.Format("{0:0,0.00}", novoSalario);
        Console.WriteLine("Com um reajuste de " + reajuste + "%, o novo salário será de R$" + novoSalarioFormat);

        //Outros recursos que os colegas mandaram:
        // https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
        // https://docs.microsoft.com/pt-br/dotnet/api/system.double.tostring?view=netframework-4.7
    }

    private static void Exemplo2()
    {
        //Trabalhando com números
        // Docs: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

        // int ou Int32? Tanto faz:
        int a = 100;
        Int32 b = 200;

        Console.WriteLine(a + b);
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