using Composite.FileSystem;

namespace Composite
{
    public class File : IFileManager
    {
        public string FileName { get; set; }

        public File(string fileName)
        {
            this.FileName = fileName;
        }

        public void ls()
        {
            Console.WriteLine(this.FileName);
        }
    }
}
