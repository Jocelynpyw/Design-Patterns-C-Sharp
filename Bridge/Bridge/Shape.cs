using System.Drawing;

namespace Bridge
{
    public abstract class Shape
    {
        //Ce constructeur permet de faire le lien entre Les Formes et les couleus
        protected readonly IColor Color;
        public Shape (IColor color)
        {
            this.Color = color;
        }
        public abstract string GetShape();
        public abstract string GetColor();




    }

    public class Circle : Shape
    {
        
        public Circle(IColor color) : base(color)
        {
            
        }

        public override string GetShape()
        {
            return "Cercle";
        }
        public override string GetColor()
        {
            return Color.GetColor;
        }
        

    }

    public class Rectangle : Shape
    {
        public Rectangle(IColor color) : base(color)
        {
        }

        public override string GetShape()
        {
            return "Rectangle";
        }
        public override string GetColor()
        {
            return Color.GetColor;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(IColor color) : base(color)
        {
        }

        public override string GetShape()
        {
            return "Trianle";
        }
        public override string GetColor()
        {
            return Color.GetColor;
        }
    }
}