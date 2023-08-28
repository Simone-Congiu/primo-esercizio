using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prima_prova
{
    internal class Program
    {
        static void Main(string[] args)
        {

            dipendente dipendente= new dipendente();
            dipendente.nome = "simone";
            dipendente.cognome = "congiu";
            dipendente.mansione = "web developer";

            dipendente.partemia = 1600;
            
            Console.WriteLine(dipendente.NomeCognomeMansione());
            Console.WriteLine(dipendente.stipendio());



            prodotto uova=new prodotto();
            uova.Prezzo = 0.50;
            uova.Quantita = 10;
           

            prodotto pesce=new prodotto();
            pesce.Prezzo = 2;
            pesce.Quantita = 1;
            Console.WriteLine(uova.CalcolaTotale() + pesce.CalcolaTotale());                             
           
            
            animale cane=new animale();
            cane.specie = "cane";
            cane.pelo = "lungo";
            cane.Nzampe = 4;
            cane.velocità = 20;
            
            
            
            
            
            
            
            Console.ReadLine();



        }
    }
}
