using System.IO;

namespace TextToolsLib
{
    public interface IFileLoader
    {
        string FileContent { get; }

        string Load(string path);

        bool TryLoad(string path);
    }
}
