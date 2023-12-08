namespace Singleton
{
    public sealed class Singleton
    {
        //Variable instance qui va contenir l'instance de notre classe
        private static Singleton? instance = null;

        //Autres attributs classiques
        private int x;
        private int y;

        //Surchage de notre classe pour la rendre polymorphe
        private Singleton()
        {
            instance = this;
        }

        private Singleton(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Methodes renvoyant une instance de la classe Singleton 
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public static Singleton getInstance(int x, int y)
        {
            if (instance == null)
            {
                instance = new Singleton(x, y);
            }
            return instance;

        }

        //Autres methodes classiques et non statiques 
        public int Somme()
        {
            return this.x + this.y;
        }

     


        public void Affiche()
        {
            Console.WriteLine($"\n Je suis une instance mes valeurs sont : x = {this.x} et y = {this.y}" );
        }

    }

}