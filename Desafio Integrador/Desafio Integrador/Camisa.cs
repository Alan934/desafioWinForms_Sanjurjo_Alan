using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Integrador
{
    class Camisa : Prenda
    {
        private bool mangaCorta;

        public Camisa (bool mangaCorta)
        {
            this.mangaCorta = mangaCorta;
        }

        public double Rebaja()
        {
            if (mangaCorta == true)
            {
                return Precio * 0.1;
            }
            if (mangaCorta == false)
            {
                return 0;
            }
            return 0;
        }

        public double PrecioFinalCamisa()
        {
            return (PrecioFinal() - Rebaja() );
        }

        
    }
}
