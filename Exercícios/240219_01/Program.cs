using System;

//trabalhando com variáveis c#
//declarando variavel sem inicializacao
string ? message1 = null;
//iniciar variavel como nula
string ? message2 = null ;
//inicializar string vazia
string message3 = System.String.Empty ; // "" ;
//strinmg com valor implicito
var message4 = "Uma mensagem" ;

Console.WriteLine(message4); // ( ) parenteses = metodo

//concatenando strings
string concat = (message1 == null ? "" : message1) + " " + (message2 == null ? "" : message2) + " " + message3 + " " + message4 ;
Console.WriteLine( "\n" + concat );

Console.WriteLine(
    "A temperatura hoje {0:D} é {1} °C"
    , DateTime.Now
    , 23
); 

string ? nome = string.Empty;
Console.WriteLine("Qual seu nome?");
nome = Console.ReadLine();
string resultado = $"Oi, {nome}! Pare de jaguarice!";
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine(resultado);
Console.ResetColor();