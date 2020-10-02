using System;

namespace C__Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // a partir de um número inteiro qualquer, mostrar seu sucessor e antecessor

            int numero,sucessor,antecessor;
            Console.WriteLine("Digite um número inteiro qualquer:");
            numero = int.Parse(Console.ReadLine());
            sucessor = numero + 1;
            antecessor = numero - 1;
            Console.WriteLine("O número anterior é {0}",antecessor);
            Console.WriteLine("O próximo número é {0}",sucessor);   
        }
    }
}
