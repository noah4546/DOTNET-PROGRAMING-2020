using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseFile> files = new List<BaseFile>();

            files.Add(new CompressedTextFile("Test.txt", "Compress this data!"));
            files.Add(new WordFile("Test.docx"));
            files.Add(new CompressedTextFile("Test1.txt", "Compress this data!"));
            files.Add(new WordFile("Test1.docx"));
            files.Add(new CompressedTextFile("Test2.txt", "Compress this data!"));
            files.Add(new WordFile("Test2.docx"));

            foreach (BaseFile file in files)
            {
                Console.WriteLine(file.Name);

                if (file is ICompressible fileIc)
                    fileIc.Compress();
                if (file is IStorable fileIs)
                    fileIs.Store(file.Name);
                if (file is IPrintable fileIp)
                    fileIp.Print();

                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
