using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaLampadina
{
    public class Lampadina
    {
        public const int STATOSPENTA = 0;
        public const int STATOACCESA = 1;
        public const int STATOROTTA = -1;
        private const int CLICK_PRIMA_DI_ROTTURA = 30;

        private int stato = STATOROTTA;
        private int nClick = 0;

        public Lampadina()
        { }



        public int Click()
        {
            nClick++;
            if (nClick >= CLICK_PRIMA_DI_ROTTURA)
            {
                stato = STATOROTTA;
            }
            else
            {
                stato = 1 - stato;
            }
            return stato;


        }

        public string Descrizione()
        {

            if (stato == STATOACCESA)
            {
                return "La lampadina è accesa";
            }
            else if (stato == STATOSPENTA)
            {
                return "La lampadina è spenta";

            }
            else
                return "La lampadina è rotta";



        }

    }
}
