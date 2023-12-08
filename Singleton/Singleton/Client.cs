
using System;
namespace Singleton
{
    internal class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nCeci est la premiere instance que le programme cree \n");
            Singleton monInstance = Singleton.getInstance(2,4);
            monInstance.Affiche();
            Console.WriteLine($"La somme est : {monInstance.Somme()}");

            Console.WriteLine("\nCeci est la deuxieme instance que le programme cree");
            Singleton s1 = Singleton.getInstance(8, 3);
            s1.Affiche();
            Console.WriteLine("on peut remarquer que S1 contient toujours les valeurs de la premiere instance pourtant nous avons bien " +
                "passe 8 et 3 dans la nouvelle instance que nous voulions creer");


            // Singleton s2 = Singleton.getInstance(5, 9);
            // s2.Affiche();
        }
    }

}

