namespace Bridge
{
    public interface IColor
    {
       public string GetColor { get; }
    }

    public class  RedColor : IColor
    {
        public string GetColor => "Rouge ";
    }

    public class BlueColor : IColor
    {
        public string GetColor => "Bleu";
    }


}