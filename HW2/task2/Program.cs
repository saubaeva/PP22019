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
        public static bool Prime( int a) //boolean function to check for prime
        {
            if (a <= 1)// if number less than 1, then function return false value
            {
                return false;
            }
            for ( int i=2; i <= a/2; i++) // if the number is divided without balance by 2 or more than the number, then it is not a prime number
            {
                if ( a % i == 0)
                {
                    return false; 
                }
            }
            return true; // else the number is prime
        }
        static void Main(string[] args)
        {
            StreamReader qw = new StreamReader(@"C:\Users\User\PP2\HW2\task2\input.txt"); // to read text from a file
            string arr = qw.ReadToEnd(); // arr variable takes the value of text Text
            string[] arra = arr.Split(' '); // divide a line into parts between characters or lines
            StreamWriter s = new StreamWriter(@"C:\Users\User\PP2\HW2\task2\output.txt"); // method to write to a file

            for ( int i=0; i < arra.Length; i++)
            {
                int we = int.Parse(arra[i]); // convert each massiv symbol to integer

                if (Prime(we)) // check each number
                {
                    s.Write(we); // if yes then print to output
                    s.Write(" ");
                }
            }
            s.Close();
        }
    }
}
