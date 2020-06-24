using System;

namespace fixa_21
{
    class Program
    {
        static void Main(string[] args)
        {
             Cliente Joao = new Cliente("João");
            Restaurante bk = new Restaurante("Pizzaria Maracanã");
            Joao.Endereco = "Rua da lagoa, 67";
            bk.Endereco = "Rua da esperança, 88";
            System.Console.WriteLine("Pedido: ");
            Console.WriteLine( bk.MostrarDados() );
            Console.WriteLine( Joao.MostrarDados() );

            Pedido pedido1 = new Pedido();
            pedido1.Cliente = Joao;
            pedido1.Restaurante = bk;
        }
    }
}
