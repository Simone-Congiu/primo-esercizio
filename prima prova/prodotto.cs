using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prima_prova
{
    internal class prodotto
    {
        public string Nome { get; set; }
        public double Prezzo { get; set; }
        public double Quantita { get; set; }


        public double CalcolaTotale()
        {
            return Prezzo * Quantita;
        }
    }
}
