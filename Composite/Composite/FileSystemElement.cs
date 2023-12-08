using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Composite
{
    public abstract class FileSystemElement
    {
        public  string Name { get; }
        public FileSystemElement (string name)
        {
            Name = name;
        }
        public abstract int GetCount();
    }

    public class DirectoryElement : FileSystemElement
    {
        private List<FileSystemElement> _elements  = new ();
        public IEnumerable<FileSystemElement> Elements => _elements;
        public DirectoryElement(string name) : base(name)
        {

        }
        public void AddElement (FileSystemElement element)
        {
            _elements.Add(element);
        }
        public void RemoveElement (string name)
        {
            _elements.RemoveAll(e=>e.Name.Equals(name));
        }
        public override int GetCount()
        {
            int count = 0;
            foreach (FileSystemElement element in Elements)
            {
                 count += element.GetCount();
            }
            return count;
        }
    }

    public class FileElement : FileSystemElement
    {
        public FileElement(string name) : base(name)
        {
        }

        public override int GetCount() => 1;
       
    }
}