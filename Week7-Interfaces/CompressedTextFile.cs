using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Interfaces
{
    class CompressedTextFile : BaseFile, ICompressible, IStorable
    {
        private byte[] compressedData, uncompressedData;
        public bool IsCompressed { get; set; }

        public CompressedTextFile(string name, string data) : base(name) 
        {
            uncompressedData = Encoding.UTF8.GetBytes(data);
        }

        public void Compress()
        {
            Console.WriteLine($"CompressedTextFile.Compress method for {Name}");
        }

        public void Decompress()
        {
            Console.WriteLine($"CompressedTextFile.Decompress method for {Name}");
        }

        public void Load(string name)
        {
            Console.WriteLine($"CompressedTextFile.Load method for {Name}");
        }

        public void Store(string name)
        {
            Console.WriteLine($"CompressedTextFile.Store method for {Name}");
        } 
    }
}
