using System;

namespace C__Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // calcular quantidade de gasolina necessária para viagem

            int kilomLitro,disPercorrida,litrosComb;
            Console.WriteLine("Que distância você vai viajar?");
            disPercorrida = int.Parse(Console.ReadLine());
            kilomLitro = 12;
            litrosComb = disPercorrida / kilomLitro;
            
            Console.WriteLine("Você vai precisar de {0} litros de gasolina",litrosComb);
        }
    }
}
