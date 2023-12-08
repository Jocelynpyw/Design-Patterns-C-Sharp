using System;

namespace Observer
{
    internal class Client
    {
        public static void Main(string[] args)
        {
            Sujet sujet = new Sujet();
            ObservateurConcret observateur1 = new ObservateurConcret();
            ObservateurConcret observateur2 = new ObservateurConcret();

            sujet.AjouterObservateur(observateur1);
            sujet.AjouterObservateur(observateur2);

            sujet.Etat = 10; // Les observateurs seront notifiés du changement d'état
        }
    }
}