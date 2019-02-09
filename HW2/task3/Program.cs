using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        static string Space(int a) // function to deal with the spaces
        {
            string s = "      ";
            string q = "";
            for ( int i=0; i < a; i++)
            {
                q += s;
            }
            return q;
        }
        static void qweqwe(DirectoryInfo dir, int a) // function to get the folder
        {
            FileInfo[] files = dir.GetFiles(); // to get files
            DirectoryInfo[] dires = dir.GetDirectories(); // represent a file or directory
            foreach (FileInfo file in files) // to handle to each file
            {
                Console.Write(Space(a)); // write with spaces
                Console.WriteLine(file.Name); // to write files with names
            }
            foreach(DirectoryInfo dire in dires) 
            {
                Console.Write(Space(a));
                Console.WriteLine(dire.Name);
                qweqwe(dire, a + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\User\HW2"); // choose the folder to show the files
            qweqwe(dir, 0);
            Console.ReadKey();
        }
    }
}
