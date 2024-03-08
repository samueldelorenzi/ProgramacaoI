bool rodar = true;
string ? denovo = "";
float operando1 = 0;
float operando2 = 0;
float result = 0;
string operador = "+";
bool isValid1 = false;
bool isValid2 = false;
bool isValid3 = false;
while(rodar)
{
    Console.WriteLine("Bem-vindo a calculadora simples, 4 operações para dois operandos.");

    while (! isValid1)
    {   
        Console.WriteLine("Digite o primeiro operando:");
        isValid1 = float.TryParse(Console.ReadLine(), out operando1);
    }
    
    while (! isValid2)
    {
        Console.WriteLine("Qual operação gostaria de executar? (* , / , + , -)");
        operador = Console.ReadLine() ?? "+";
        if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
        {
            isValid2 = false;
        }
        else
        {
            isValid2 = true;
        }
           
    }
    
    while (! isValid3)
    {
        Console.WriteLine("Digite o segundo operando:");
        isValid3 = float.TryParse(Console.ReadLine(), out operando2);
    }
    Console.WriteLine($"Operação: {operando1} {operador} {operando2}");
    switch(operador)
    {
        case "+":
            result = operando1 + operando2;
        break;
        case "-":
            result = operando1 - operando2;
        break;
        case "/":
            result = operando1 / operando2;
        break;
        case "*":
            result = operando1 * operando2;
        break;
    }
    Console.WriteLine($"Resultado: {result}");
    Console.WriteLine("Rodar novamente?");
    denovo = Console.ReadLine();
    rodar = false;
}



