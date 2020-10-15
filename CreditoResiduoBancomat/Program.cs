using System;
using System.IO;

namespace CreditoResiduoBancomat
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo, spese, importospesa, totspesa = 0;

            Console.Write("inserisci il saldo del tuo portafoglio:");
            saldo = double.Parse(Console.ReadLine());
            Console.Write("inserisci il numero di spese che vuoi fare:");
            spese = double.Parse(Console.ReadLine());
            while (totspesa < spese)
            {
                Console.Write("inserisci l'importo della spesa: ");
                importospesa = double.Parse(Console.ReadLine());
                if (importospesa > saldo)
                {
                    Console.WriteLine("saldo non sufficiente");
                }
                else
                {
                    saldo = saldo - importospesa;
                    Console.WriteLine($"dopo la tua spesa ti rimarranno:{saldo}");
                }
                totspesa++;
            }
            Console.WriteLine($"Hai eseguito {totspesa} acquisti, saldo rimanente:{saldo}");
            Console.ReadLine();




        }
    }
}
