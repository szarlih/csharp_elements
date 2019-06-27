using TextToolsLib;

namespace CsharpElements
{
    class FileContentTool
    {
        private IFileLoader loader;

        public string Content { get; private set; }

        public FileContentTool(string path)
        {
            loader = new TxtFileLoader();
            Content = loader.Load(path);
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
    }
}
