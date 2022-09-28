using System;

class dados
{
    public static void Main(string[]args)
    {
        string nome;
        string endereco;
        double cpf;

        Console.WriteLine("qual o seu nome?");
        nome = Console.ReadLine();
        Console.WriteLine("qual o seu endereço?");
        endereco = Console.ReadLine();
        Console.WriteLine("qual o seu CPF?");
        cpf =int.Parse (Console.ReadLine());

        Console.WriteLine("Ola! seja bem-vindo ao nosso sistema");
        Console.WriteLine("dados do usuario:");
        Console.WriteLine("nome:"+nome);
        Console.WriteLine("CPF:"+cpf);
        Console.WriteLine("endereço:"+endereco);



    }

}