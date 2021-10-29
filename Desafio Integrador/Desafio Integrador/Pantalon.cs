using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Integrador
{
    class Pantalon : Prenda
    {
        private bool bermuda;

        public Pantalon(bool bermuda)
        {
            this.bermuda = bermuda;
        }

        public double Descuento()
        {
            if (bermuda == true)
            {
                return Precio * 0.2;
            }
            if(bermuda == false)
            {
                return 0;
            }
            return 0;
        }

        public double PrecioFinalPantalon()
        {
            return PrecioFinal() - Descuento();
        }

    }
}
