using System;
namespace Bridge
{
    internal class Client
    {
         static void Main(string[] args)
        {
            //Ici nous pouvons maintenant creer n'importe quel Forme de n'importe quel couleur
            Shape s1 = new Triangle(new BlueColor());
            Console.WriteLine($"Nous venons de creer une {s1.GetShape()} de couleur {s1.GetColor()}\n");


            



        }
    }
}