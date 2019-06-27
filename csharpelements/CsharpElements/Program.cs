using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "testowy.txt";

            FileContentTool tool = new FileContentTool(path);
            Console.WriteLine(tool.Content);

            tool.TryLoad(path);
            Console.WriteLine(tool.Content);

            Console.ReadKey();
        }
    }
}
