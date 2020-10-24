using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace animals
{
    class FileOut
    {
        private StreamReader sr = null;
        private string fileName;
        public FileOut(string fileName)
        {
            this.fileName = fileName;
            try
            {
                new StreamReader(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

    }
}

