using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

class Pedido{
    static void Main(){
        
        string descricao="";
        string valor_unitario=""; // declarar valor_unitario como double
        string quantidade=""; // declarar quantidade como int

        List<string> pedidos = new List<string>();
        
        // Como criar uma lista para guardar os valores de valor_unitario?
        
        Console.Write("\nQual o seu pedido? ");
        descricao = Console.ReadLine();
        pedidos.Add(descricao);

        Console.Write("\nQual o valor? ");
        valor_unitario = Console.ReadLine();
        pedidos.Add(valor_unitario); 

        Console.Write("\nQuantidade? ");
        quantidade = Console.ReadLine();
        pedidos.Add(quantidade);

        while (!String.IsNullOrEmpty(descricao))
        {
            Console.Write("\nQual o seu pedido? ");
            descricao = Console.ReadLine();
            pedidos.Add(descricao);

            Console.Write("\nQual o valor? ");
            valor_unitario = Console.ReadLine();
            pedidos.Add(valor_unitario);

            Console.Write("\nQuantidade? ");
            quantidade = Console.ReadLine();
            pedidos.Add(quantidade);

        }

        Console.WriteLine("\nConfirme seu pedido:\n");

        foreach (object o in pedidos)
        {
            Console.WriteLine("\n" + o); // Preciso melhorar a formatação da saída na tela.
        }
                // Como mostrar o valor total do pedido?
    }
}
