using System;
using System.IO;

namespace TextToolsLib
{
    public class TxtFileLoader : IFileLoader
    {
        private const string fileNotExist = "File not exists";
        public string FileContent { get; private set; }

        public string Load(string path)
        {
            FileContent = string.Empty;

            StreamReader stream = null;

            try
            {
                    stream = new StreamReader(path);
                    FileContent = stream.ReadToEnd();
            }
            catch(Exception ex)
            {
                FileContent = ex.Message;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }

            return FileContent;
        }

        public bool TryLoad(string path)
        {
            bool state;
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(path);
                FileContent = reader.ReadToEnd();
                state = true;
            }
            catch
            {
                FileContent = fileNotExist;
                state = false;
            }
            finally
            {
                if(reader != null)
                    reader.Close();
            }

            return state;
        }
    }
}