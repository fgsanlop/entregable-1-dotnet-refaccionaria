using System;
namespace TeresaSA
{ 
    public class Componente
    {
        private int id;
        private string nombre;
        private float precioUSD;

        public Componente(int id, string nombre, float precioUSD)
        {
            this.id = id;
            this.nombre = nombre;
            this.precioUSD = precioUSD;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public float PrecioUSD
        {
            get
            {
                return precioUSD;
            }
        }

        public override string ToString()
        {
            return string.Format("[Componente: id={0}, nombre={1}, precio dolar={2}]", id, nombre, precioUSD);
        }
    }
}
