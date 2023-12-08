namespace Factory
{
    public class ProduitFactory
    {
        private const  int TYPE_PRODUITA1 = 1;
        private const  int TYPE_PRODUITA2 = 2;
        public  int TYPE_PUBLIQUE_PRODUITA1 = 1;
        public  int TYPE_PUBLIQUE_PRODUITA2 = 2;

        // public const int rien = 2;

        public ProduitA getProduitA(int typeProduitA)
        {
            ProduitA? produitA = null;

            switch (typeProduitA)
            {
                case TYPE_PRODUITA1:
                    produitA=new ProduitA1();
                    break;
                case TYPE_PRODUITA2:
                    produitA=new ProduitA2();
                    break;
                default:
                    throw new ArgumentException("Ce type de produit n'existe pas ");

            }
            return produitA;
        }
    }
}
