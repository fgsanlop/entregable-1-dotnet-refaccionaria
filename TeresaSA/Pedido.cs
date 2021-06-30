using System;
namespace TeresaSA
{
    public class Pedido
    {
        private Componente componente;
        private int cantidad;
        private int tipoDto;
        private float monto;
        private float descuento;
        private float total;

        public Pedido(Componente componente, int cantidad)
        {
            this.componente = componente;

            if (this.componente.Id == 1 || this.componente.Id == 2)
                this.tipoDto = 1;
            else if (this.componente.Id == 3 || this.componente.Id == 4)
                this.tipoDto = 2;

            this.cantidad = cantidad;
            this.monto = 0f;
            this.descuento = 0f;
            this.total = 0f;
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }
        }

        public float usdMxn(float dolares)
        {
            return dolares * 21.32f;
        }

        public void calcularMonto()
        {
            monto = cantidad * componente.PrecioUSD;
        }

        public void calcularDescuento()
        {
            if (tipoDto == 1)
            {
                if (cantidad > 100)
                {
                    if (cantidad > 500)
                        descuento = monto * 0.10f;
                    else
                        descuento = monto * 0.05f;
                }
            }
            else if (tipoDto == 2)
            {
                if (monto > 1000f)
                    descuento = monto * (float)1/3;
            }
        }

        public void calcularTotal()
        {
            total = monto - descuento;
        }

        public override string ToString()
        {
            return string.Format("[Pedido(MXN): " +
                "cantidad={0},\tcomponente={1},\tprecio={2}\tmonto={3:00.00},\tdescuento={4:00.00},\t total={5:00.00}"
                , cantidad, componente.Nombre, usdMxn(componente.PrecioUSD),usdMxn(monto), usdMxn(descuento), usdMxn(total));
        }
    }
}
