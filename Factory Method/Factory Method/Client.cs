using System;

namespace Factory
{
    internal class Client
    {
        static void Main(string[] args)

        {
            ProduitFactory produiFactory = new ProduitFactory();
            ProduitA? produitA = null;

            produitA = produiFactory.getProduitA(produiFactory.TYPE_PUBLIQUE_PRODUITA1);
            produitA.methodeA();

            produitA = produiFactory.getProduitA(produiFactory.TYPE_PUBLIQUE_PRODUITA2);
            produitA.methodeA();


        }
    }
}
