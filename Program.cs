using System;

// Program em C# console - Fazer pedidos em um restaurante

namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido lista = new Pedido();

            string resposta="s";
            
            do{
                ItemPedido pedido = new ItemPedido();
                
                Console.WriteLine("Qual lanche você gostaria? ");
                pedido.descricao = Console.ReadLine();
                
                Console.WriteLine("Qual o valor do lanche? ");
                pedido.valor_unitario = Double.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade? ");
                pedido.quantidade = Int32.Parse(Console.ReadLine());

                lista.adicionar(pedido);

                Console.WriteLine("Deseja fazer um novo pedido? (s/n)");
                resposta = Console.ReadLine();

                if (resposta == "n")
                {
                    Console.WriteLine("O total do pedido é: R$ {0}\n", lista.totalizar());
                }
                
            } while (resposta == "s");
        }
    }
}
