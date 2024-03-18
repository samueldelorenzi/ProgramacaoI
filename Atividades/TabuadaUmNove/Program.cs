using System;

class Program
{
    static void Main()
    {
        string operador="";
        Console.WriteLine("Bem vindo a calculadora de tabuada");
        while (operador != "+" & operador != "-" & operador != "*" & operador != "/")
        {
            Console.WriteLine("Escolha seu operador aritmético");
            operador = Console.ReadLine() ?? "*";
        }
        int resultado;
        int multiplicacao;
        string[,] array = new string[9,9];

        switch (operador)
        {
            case "+":
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j<10; j++)
                    {
                        resultado=i+j;
                        array[j-1,i-1] = $"{i} + {j} = {resultado}";
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write($"{array[i,j]}\t"); 
                    }
                    Console.WriteLine("");
                }
            break;
            case "-":
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j<10; j++)
                    {
                        resultado=i-j;
                        array[j-1,i-1] = $"{i} - {j} = {resultado}";
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write($"{array[i,j]}\t"); 
                    }
                    Console.WriteLine("");
                }
            break;
            case "*":
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j<10; j++)
                    {
                        resultado=i*j;
                        array[j-1,i-1] = $"{i} * {j} = {resultado}";
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write($"{array[i,j]}\t"); 
                    }
                    Console.WriteLine("");
                }
            break;
            case "/":
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j<10; j++)
                    {
                        multiplicacao=i*j;
                        resultado=multiplicacao/i;
                        array[j-1,i-1] = $"{multiplicacao} / {i} = {resultado}";
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write($"{array[i,j]}\t"); 
                    }
                    Console.WriteLine("");
                }
            break;
        }
    }
}
