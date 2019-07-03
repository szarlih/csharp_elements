using System;
using System.Threading;
using System.Threading.Tasks;
using TextToolsLib;

namespace CsharpElements
{
    public class FileContentTool
    {
        private IFileLoader loader;

        public string Content { get; set; }

        public FileContentTool(string path)
        {
            loader = new TxtFileLoader();
            Content = loader.Load(path);
        }

        public FileContentTool()
        {
            loader = new TxtFileLoader();
            Content = string.Empty;
        }

        public void TryLoad(string path)
        {
            if(loader.TryLoad(path))
            {
                Content = loader.FileContent;
            }
            else
            {
                Content = "Failure";
            }
        }

        public int CountWords()
        {
            return WordCounter.Count(Content);
        }

        public async Task<int> CountWordOccurences(string word)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            return await WordCounter.CountWordOcurrence(Content, word);
        }
    }
}
