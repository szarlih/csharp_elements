using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsharpElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "testowy.txt";

            FileContentTool tool = new FileContentTool(path);
           // Console.WriteLine(tool.Content);

            tool.TryLoad(path);
            Console.WriteLine(tool.Content);

            XmlSerializer sr = new XmlSerializer(typeof(FileContentTool));
            using (Stream s = File.Create("fileContentTool.xml"))
            {
                sr.Serialize(s, tool);
            }

            using (Stream s = File.OpenRead("fileContentTool.xml"))
            {
                FileContentTool newTool = (FileContentTool)sr.Deserialize(s);
            }

                Console.WriteLine("{0} words found", tool.CountWords());

            var wordCount = tool.CountWordOccurences("test");
            var taskWordCount = Task.Run(() => tool.CountWordOccurences("test"));

            while(!taskWordCount.IsCompleted)
            Console.WriteLine("test occured {0}", taskWordCount.Result);

            Console.ReadKey();
        }
    }
}
