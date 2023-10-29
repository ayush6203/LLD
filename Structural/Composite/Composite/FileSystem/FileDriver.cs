using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.FileSystem
{
    public class FileDriver
    {
        public static void Drive()
        {
            Directory root = new Directory();
            File movie1 = new File("Move1");
            root.ltFileManager.Add(movie1);

            Directory comedyMovie = new Directory();
            File comedyMovie1 = new File("ComedyMovie1");
            File comedyMovie2 = new File("ComedyMovie2");
            File comedyMovie3 = new File("ComedyMovie3");
            comedyMovie.ltFileManager.Add(comedyMovie1);
            comedyMovie.ltFileManager.Add(comedyMovie2);
            comedyMovie.ltFileManager.Add(comedyMovie3);

            Directory horrorMovie = new Directory();
            File horrorMovie1 = new File("horrorMovie1");
            File horrorMovie2 = new File("horrorMovie2");
            horrorMovie.ltFileManager.Add(horrorMovie1);
            horrorMovie.ltFileManager.Add(horrorMovie2);

            root.ltFileManager.Add(comedyMovie);
            root.ltFileManager.Add(horrorMovie);

            root.ls();
        }
    }
}
