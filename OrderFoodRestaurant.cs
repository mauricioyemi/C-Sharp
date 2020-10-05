using System;
using System.Collections.Generic;

class ItemPedido{
    string descricao;
    double valor_unitario;
    int quantidade;
}

class Pedido{

   private static void Main(){

       var Pedidos = new List<object>();
       Pedidos.Add("Xis");
       Pedidos.Add(20);
       Pedidos.Add(1);

       foreach (var pedido in Pedidos)
       {
           Console.WriteLine(pedido);
       }
   
        
    }
}
