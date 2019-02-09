using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        public static bool Prime( int a) //function to check
        {
            if (a <= 1)
            {
                return false;
            }
            for ( int i=2; i <= a/2; i++)
            {
                if ( a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader qw = new StreamReader(@"C:\Users\User\HW2\task2\input.txt"); // to read text from a file
            string arr = qw.ReadToEnd(); // method on the StreamReader to read an entire text file into a string
            string[] arra = arr.Split(' '); // divide a line into parts between characters or lines
            StreamWriter s = new StreamWriter(@"C:\Users\User\HW2\task2\output.txt"); // method to write to a file

            for ( int i=0; i < arra.Length; i++)
            {
                int we = int.Parse(arra[i]); // convert each massiv symbol to integer

                if (Prime(we)) // chect each number
                {
                    s.Write(we); // if yes then print to output
                    s.Write(" ");
                }
            }
            s.Close();
        }
    }
}
