using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

class Pedido{
    static void Main(){
        
        string descricao;
        //double valor_unitario;
        //int quantidade;

        List<string> pedidos = new List<string>();
        
        Console.WriteLine("Qual o seu pedido? ");
        descricao = Console.ReadLine();
        pedidos.Add(descricao);

        while (!String.IsNullOrEmpty(descricao))
        {
            Console.WriteLine("Qual o seu pedido? ");
            descricao = Console.ReadLine();
            pedidos.Add(descricao);

        }

        foreach (object o in pedidos)
        {
            Console.WriteLine(o);
        }

    }
}