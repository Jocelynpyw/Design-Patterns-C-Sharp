using System;

namespace Strategie
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Exemple d'utilisation des différentes stratégies de remise
            IStrategieRemise strategieRegulier = new StrategieRemiseRegulier();
            IStrategieRemise strategieFidele = new StrategieRemiseFidele();
            IStrategieRemise strategieVIP = new StrategieRemiseVIP();

            ContexteRemise contexte1 = new ContexteRemise(strategieRegulier);
            ContexteRemise contexte2 = new ContexteRemise(strategieFidele);
            ContexteRemise contexte3 = new ContexteRemise(strategieVIP);

            Console.WriteLine("Client régulier :");
            contexte1.AppliquerRemise(100);

            Console.WriteLine("\nClient fidèle :");
            contexte2.AppliquerRemise(100);

            Console.WriteLine("\nClient VIP :");
            contexte3.AppliquerRemise(100);
        }
    }
}