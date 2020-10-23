using LibreriaLampadina;
using System;

namespace MainLampadina
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampadina l = new Lampadina();


            for (int i = 0; i < 500; i++)
            {

                Console.WriteLine(" ________________");
                Console.WriteLine("\n| MENU LAMPADINA |");
                Console.WriteLine(" ________________");
                Console.WriteLine("Vuoi eseguire un click o sapere lo stato attuale della Lampadina? (click/stato)");
                string risposta = Console.ReadLine();

                if (risposta == "click")
                {
                    l.Click();
                    Console.WriteLine("Lo stato della lampadina è stato aggiornato");
                    
                }
                else if (risposta == "stato")
                {
                    Console.WriteLine(l.Descrizione());
                    
                }
                else
                {
                    Console.WriteLine("Risposta non valida");
                    
                }
            }

           
        }
    }
}
