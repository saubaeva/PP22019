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
            for ( int i=0; i < a; i++) // a times print out
            {
                q += s;
            }
            return q;
        }
        static void qweqwe(DirectoryInfo dir, int a) // function to get the folder
        {
            FileInfo[] files = dir.GetFiles(); // All the files in the folder are entered into the array
            DirectoryInfo[] dires = dir.GetDirectories(); // Also, we enter all folders in the array
            foreach (FileInfo file in files) // display the names of all the content files
            {
                Console.Write(Space(a)); // write with spaces
                Console.WriteLine(file.Name); // to write files with names
            }
            foreach(DirectoryInfo dire in dires) 
            {
                Console.Write(Space(a));
                Console.WriteLine(dire.Name);//display the folder names, and immediately call the same function
                qweqwe(dire, a + 1); //each time we add the value a to make the hierarchy
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\User\PP2"); // create a variable for a class DirectoryInfo
            qweqwe(dir, 0); // function to display the contents of a folder
            Console.ReadKey();
        }
    }
}
