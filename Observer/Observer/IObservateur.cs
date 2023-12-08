namespace Observer
{
    public interface IObservateur
    {
        void MettreAjour(Sujet sujet);

    }

    // Observateur concret
    public class ObservateurConcret : IObservateur
    {
        public void MettreAjour(Sujet sujet)
        {
            Console.WriteLine($"ObservateurConcret notifié du changement d'état du sujet. Nouvel état : {sujet.Etat}");
        }
    }
}