using System.Collections;
using System.Linq.Expressions;

bool finalizar = false;
Hashtable hashtable = new();

Console.WriteLine("Ficha cadastral:");

while (finalizar==false)
{
    string ? nome = "";
    string ? email = "";
    string ? nascimento = "";
    string ? sexo = "";
    string ? rua = "";
    string ? bairro = "";
    string ? numero = "";
    string ? cep = "";
    string ? cidade = "";
    string ? pais = "";
    string ? estado = "";

    while (nome=="")
    {
        Console.WriteLine("Digite o nome:");
        nome = Console.ReadLine() ?? "";
    }
    while (email=="")
    {
        Console.WriteLine("Digite o email:");
        email = Console.ReadLine() ?? "";
    }
    while (nascimento=="")
    {
        Console.WriteLine("Digite o nascimento:");
        nascimento = Console.ReadLine() ?? "";
    }
    while (sexo=="")
    {
        Console.WriteLine("Digite o sexo:");
        sexo = Console.ReadLine() ?? "";
    }
    while (rua=="")
    {
        Console.WriteLine("Digite a rua:");
        rua = Console.ReadLine() ?? "";
    }
    while (bairro=="")
    {
        Console.WriteLine("Digite o bairro:");
        bairro = Console.ReadLine() ?? "";
    }
    while (numero=="")
    {
        Console.WriteLine("Digite o numero:");
        numero = Console.ReadLine() ?? "";
    }
    while (cep=="")
    {
        Console.WriteLine("Digite o CEP:");
        cep = Console.ReadLine() ?? "";
    }
    while (cidade=="")
    {
        Console.WriteLine("Digite a cidade:");
        cidade = Console.ReadLine() ?? "";
    }
    while (estado=="")
    {
        Console.WriteLine("Digite o estado:");
        estado = Console.ReadLine() ?? "";
    }
    while (pais=="")
    {
        Console.WriteLine("Digite o país:");
        pais = Console.ReadLine() ?? "";
    }

    Console.WriteLine($"Usuário cadastrado: \n Nome: {nome} \n Email: {email} \n Data de nascimento: {nascimento} \n Sexo: {sexo} \n Rua: {rua} \n Bairro: {bairro} \n Número: {numero} \n Cidade: {cidade} \n Estado: {estado} \n País: {pais} ");
    finalizar = true;
}
