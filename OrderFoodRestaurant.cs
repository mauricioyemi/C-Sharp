using System;
using System.Collections.Generic;

class ItemPedido{
    string descricao;
    double valor_unitario;
    int quantidade;
}

class Pedido{

   static void Main(){

       List<string> Pedidos = new List<string>();
       Pedidos.Add("Xis");
       Pedidos.Add("Dez pila");
       Pedidos.Add("Dois");

       foreach (var pedido in Pedidos)
       {
           Console.WriteLine(pedido);
       }
   
        
    }
}
