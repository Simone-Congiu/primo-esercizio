using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prima_prova
{
    internal class dipendente
    {
        
        public string nome { get; set; }
        public string cognome { get; set; }

        public string mansione {get; set; }

        public double partemia { get; set; }

        public double partedellostato = 0.7;



        public string NomeCognomeMansione()
        {
            return "Nome:"+ nome +" "+ cognome + " " + "Mansione:" + mansione;
        }

        public double stipendio()
        {
            return partemia * partedellostato;
        }

                  


    }
}
