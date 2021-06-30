using System;
namespace TeresaSA
{
    public class Descuento
    {
        private float montoDescontado;

        //descuento relacionado con cantidad (carroceria, motor)
        public Descuento(int cantidad, float monto) 
        {
            this.montoDescontado = 0f;

            if (cantidad > 100)
            {
                if (cantidad > 500)
                    montoDescontado = monto * 0.10f;
                else
                    this.montoDescontado = monto * 0.05f;
            }
        }

        //descuento relacionado con monto (llantas, adornos)
        public Descuento(float monto, int cantidad)
        {
            this.montoDescontado = 0f;

            if (monto > 1000f)
                this.montoDescontado = monto * (2 / 3);
        }

        public float MontoDescontado
        {
            get
            {
                return montoDescontado;
            }
            set
            {
                montoDescontado = value;
            }
        }

    }
}
