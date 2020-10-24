using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace animals
{
    public class FileIn
    {
       private StreamWriter sw = null;     
        private string fileName;
        public FileIn(string fileName)
        {
            this.fileName = fileName;
            try
            {
                new StreamWriter(fileName);
            } catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

    }
}
