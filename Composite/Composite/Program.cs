using System;
namespace Composite
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var root = new DirectoryElement("root");
            var subFolder1 = new DirectoryElement("folder1");
            var subFolder2 = new DirectoryElement("folder2");

            var file1 = new FileElement("file1");
            var file2 = new FileElement("file2");
            var file3 = new FileElement("file3");
            var file4 = new FileElement("file4");


            root.AddElement(subFolder1);
            subFolder1.AddElement(subFolder2);


            subFolder1.AddElement(file1);
            subFolder1.AddElement(file2);
            root.AddElement(file3);
            subFolder2.AddElement(file4);

            Console.WriteLine($"Le root count est {root.GetCount()}");
        }
    }
}