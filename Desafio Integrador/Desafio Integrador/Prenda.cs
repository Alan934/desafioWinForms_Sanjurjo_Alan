using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Integrador
{
    class Prenda
    {
        private double precio;
        private bool standard;
        private bool premium;
        private int cantidad;

        public double Precio { get => precio; set => precio = value; }
        public bool Standard { get => standard; set => standard = value; }
        public bool Premium { get => premium; set => premium = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; } 

        public double CalidadPrenda()
        {
            if (premium == true)
            {
                return precio * 0.3;
            }
            if (standard == true)
            {
                return 0;
            }
            return 0;
        }

        public double PrecioFinal()
        {
            return (precio + CalidadPrenda() ) * cantidad;
        }

    }
}
