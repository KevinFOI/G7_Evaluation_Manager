using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Evaluation_Manager
{
    internal class UserFileParser
    {
        public string[] stringParser(string text)
        {
            List<string> list = new List<string>();
            string[] lines = text.Split('\n');

            foreach (string line in lines)
            {
                string[] parts = line.Split('=');
                if (parts.Length == 2)
                {
                    string value = parts[1].Trim();
                    list.Add(value);

                }
            }
            return list.ToArray();
        }
    }
}
