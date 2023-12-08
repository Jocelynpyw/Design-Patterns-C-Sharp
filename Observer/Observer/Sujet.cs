namespace Observer
{
    public class Sujet
    {
        private List<IObservateur> observateurs = new List<IObservateur>();
        private int etat;
        public int Etat
        {
            get { return etat; }
            set
            {
                etat = value;
                NotifierObservateurs();
            }
        }
        public void AjouterObservateur(IObservateur observateur)
        {
            observateurs.Add(observateur);
        }
        public void SupprimerObservateur(IObservateur observateur)
        {
            observateurs.Remove(observateur);
        }

        public void NotifierObservateurs()
        {
            foreach(var observateur in observateurs)
            {
                observateur.MettreAjour(this);
            }
        }
    }
}