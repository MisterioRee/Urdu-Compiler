using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPUrduCompiler
{
   public class Filer
    {
        PathConfigs paths = new PathConfigs();
        public string executionFileName;// = paths.executionFile;
        private string fileName;// = "extra.cpp";
        private string fileLocation;// = @"C:\Users\Professor\Dropbox\Zaki Bhai\FYPUrduCompiler\FYPUrduCompiler\bin\Debug\";

        FileStream fileStream;

        public Filer()
        {
            executionFileName = paths.executionFile;
            fileName = paths.sourceFile;
            fileLocation = paths.filesPath;
        }
        public void createFile(List<string> data)
        {           
            if(data.Count>0)
            {
                resetFile();
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileLocation + fileName))
                {
                    foreach (string line in data)
                    {
                        file.WriteLine(line);
                    }
                }                
            }
        }

        public List<string> readFile(string path)
        {
            List<string> fileLines = new List<string>();
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            //fileLines.Add(line);
            while (line != null)
            {
                fileLines.Add(line);
                line = sr.ReadLine();
            }

            return fileLines;
        }

        public void removePrevious()
        {
            if (File.Exists(fileLocation + executionFileName))
            {
                File.Delete(fileLocation + executionFileName);
            }
        }

        private void resetFile()
        {
            fileStream = File.Open(fileLocation+fileName, FileMode.Open);
            fileStream.SetLength(0);
            fileStream.Close();
        }

    }
}
