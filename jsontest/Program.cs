using QuickType;

namespace ConsoleApplication1
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Dropbox\DrunkData.json";
            if (File.Exists(path))
            {
                TextReader textReader = File.OpenText(path);
                string jsondata = textReader.ReadToEnd();
                GettingStarted data = GettingStarted.FromJson(jsondata);
            }
        }
    }
}
