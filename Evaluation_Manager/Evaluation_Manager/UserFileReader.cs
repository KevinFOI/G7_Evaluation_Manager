using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    internal class UserFileReader
    {
        public string filePath;

        public UserFileReader(string p_filePath)
        {
            filePath = p_filePath;
        }

        public string Readfile()
        {
            string data;
            StreamReader reader = null;
            reader = new StreamReader(filePath);
            data = reader.ReadToEnd();
            Console.WriteLine(data);
            reader.Close();
            return data;
        }
    }
}