using System;

class Soma
{
    public static void Main(string[] args)
    {

        int numero1;
        int numero2;
        double resultado=0;


       Console.WriteLine ("eae ! vamos iniciar a sua soma de dois numeros . Digite o primeiro numero");
       numero1 =int.Parse(Console.ReadLine());

        Console.WriteLine(" Digite o segundo numero");
        numero2 = int.Parse(Console.ReadLine());

        resultado = numero1 + numero2;

        Console.WriteLine(" o resultado da soma dos dois numeros é " + resultado);


    }
}