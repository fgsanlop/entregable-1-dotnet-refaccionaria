using System;

namespace TeresaSA
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] cantidad = new int[4];

            Componente[] componentes = new Componente[]
            {
                new Componente(1,"Motor",20f),
                new Componente(2,"Carrocería",15f),
                new Componente(3,"Llantas",1f),
                new Componente(4,"Adornos",1.5f)
            };

            foreach (Componente componente in componentes)
                Console.WriteLine(componente);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Insertar cantidades a pedir para " +
            	              "motor, carroceria, llantas y adornos");

            cantidad[0] = Convert.ToInt32(Console.ReadLine());
            cantidad[1] = Convert.ToInt32(Console.ReadLine());
            cantidad[2] = Convert.ToInt32(Console.ReadLine());
            cantidad[3] = Convert.ToInt32(Console.ReadLine());

            Pedido[] pedidos = new Pedido[]
            {
                new Pedido(componentes[0], cantidad[0]),
                new Pedido(componentes[1], cantidad[1]),
                new Pedido(componentes[2], cantidad[2]),
                new Pedido(componentes[3], cantidad[3]),
            };

            foreach (Pedido pedido in pedidos)
            {
                pedido.calcularMonto();
                pedido.calcularDescuento();
                pedido.calcularTotal();
                Console.WriteLine(pedido);
            }

            ArmadoCoche ac = new ArmadoCoche(pedidos);
            ac.calcularCoches();

            Console.WriteLine(ac);

        }
    }
}
