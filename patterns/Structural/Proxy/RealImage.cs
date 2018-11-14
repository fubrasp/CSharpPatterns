using System;
namespace patterns.Structural.Proxy
{
    public class RealImage : Image
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk(_fileName);
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {_fileName}");
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine($"Loading {fileName}");
        }
    }
}
