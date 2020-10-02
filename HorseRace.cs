// Programa em C# para indicar os ganhadores em uma corrida de cavalos

using System;

namespace horserace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int tamanho = 5; //você pode mudar a quantidade de cavalos na corrida
            string[] nomes = new string[tamanho];
            int[] tempo = new int[tamanho];

            for (int i = 0; i < tamanho; i++){
                Console.Write("Informe o nome do cavalo.......: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Informe o tempo do cavalo......: ");
                tempo[i] = int.Parse(Console.ReadLine());
            }

            for (int i = tamanho-1; i >= 1; i--){
                for (int j = 0; j < i; j++){
                    if (tempo[j] > tempo[j+1]){
                        int trocaTempo = tempo[j];
                        tempo[j] = tempo[j+1];
                        tempo[j+1] = trocaTempo;

                        string trocaNome = nomes[j];
                        nomes[j] = nomes[j+1];
                        nomes[j+1] = trocaNome;
                    }
                }
            }
            for(int i = 0; i < 3; i++){
                Console.WriteLine("O {0}º colocado foi {1} com o tempo {2} segundos",i+1,nomes[i],tempo[i]);
            }
        }
    }
}