using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = @"C:\Users\User\PP2\HW2\task4\text1.txt"; // File creation paths
            string w = @"C:\Users\User\PP2\HW2\task4\text2.txt"; // Пути создания файлов
            string asd = "Better late than never"; // text to enter
            StreamWriter dd = new StreamWriter(q); // tool to entry the text
            dd.Write(asd); // entry text
            dd.Close();
            File.Copy(q, w); // Copy the new file
            File.Delete(q); // delete the first file
        }
    }
}
