using System;
namespace TeresaSA
{
    public class ArmadoCoche
    {
        /*private static int motor = 1;
        private static int carroceria = 1;*/
        private static int llantas = 4;
        private static int adornos = 2;
        private int[] cantidades;
        private Pedido[] pedido;
        private int coches;

        public ArmadoCoche(Pedido[] pedido)
        {
            this.pedido = pedido;
            this.cantidades = new int[4];
        }

        public void calcularCoches()
        {
            int i = 0;
            foreach (int cantidad in cantidades)
            {
                cantidades[i] = pedido[i].Cantidad;
                i++;
            }

            cantidades[2]/=llantas; //esto es un poco "hardcodeado"
            cantidades[3] /= adornos;

            Array.Sort(cantidades);

            coches = cantidades[0];
        }

        public override string ToString()
        {
            return string.Format("\nCoches que se pueden armar = {0}", coches);
        }
    }
}
