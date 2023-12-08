namespace Factory
{
    public abstract class ProduitA
    {
        public abstract void methodeA();
    }

    public class ProduitA1 : ProduitA
    {
        public override void methodeA()
        {
            Console.WriteLine("Je suis le produit de type A1");
            Console.WriteLine("ProduitA1.methodeA()");
        }
    }

    public class ProduitA2 : ProduitA
    {
         public override void methodeA()
        {
            Console.WriteLine("Je suis le produit de type A2");
            Console.WriteLine("ProduitA2.methodeA()");
        }
   
    }
   
}
