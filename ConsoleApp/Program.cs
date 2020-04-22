using System;

class Program
{
    static void Main(string[] args)
    {
        // Anos em que o F.C. Barcelona foi campeão europeu
        int[] anosTitulosBarcelona = new int[5] { 1990, 2006, 2009, 2011, 2015 };
        int[] anosTitulosRealMadrid = new int[] { };

        // Tamanho do vetor:
        int numeroTitulosBarcelona = anosTitulosBarcelona.Length;
        int numeroTitulosRealMadrid = anosTitulosRealMadrid.Length; 
        Console.WriteLine("O Barcelona possui "+ numeroTitulosBarcelona);
        Console.WriteLine("O Real Madrid possui " + numeroTitulosRealMadrid);

        for (int i = 0; i < numeroTitulosBarcelona; i++)
        {
            Console.WriteLine(anosTitulosBarcelona[i]);
        }

        // Editar valores do array:
        anosTitulosBarcelona[0] = 1992;

        /*
        int[] v = new int[10] { 99, 85, 7, 0, -8, 9, 10, 5, 55, -50 };

        
        if (v[i] > v[i + 1])
        {
            int temp = v[i + 1];
            v[i + 1] = v[i];
            v[i] = temp;
        }
        */

    }

    private static void ExercicioReajusteSalario()
    {
        /*
        * Crie um algoritmo que calcule e mostre o novo valor de um salário a partir das seguintes regras: 
        * salários de até R$ 1.000,00 inclusive recebem 30% de aumento, 
        * salários de até R$ 2.000,00 inclusive recebem 25%, 
        * salários de até R$ 3.000,00 inclusive recebem 20%, 
        * salários de até R$ 4.000,00 inclusive recebem 15% e 
        * salários acima de R$ 4.000,00 recebem 10%. 
        */

        //Entrada: valor do salário.
        Console.Write("Informe o valor do salário: R$");
        decimal salario = Decimal.Parse(Console.ReadLine());
        decimal salarioAjustado = 0.0m;

        //Estrutura condicional:
        if (salario <= 1000)
        {
            salarioAjustado = salario * 1.3m;
        }
        else if (salario <= 2000)
        {
            salarioAjustado = salario * 1.25m;
        }
        else if (salario <= 3000)
        {
            salarioAjustado = salario * 1.2m;
        }
        else if (salario <= 4000)
        {
            salarioAjustado = salario * 1.15m;
        }
        else
        {
            salarioAjustado = salario * 1.1m;
        }
        //Saída: valor ajustado do salário.
        Console.WriteLine("O novo salário será de {0:0,0.00}", salarioAjustado);
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