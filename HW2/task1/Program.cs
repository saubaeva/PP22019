using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        public static bool Polyndrom(string q) // boolean function to check for palindrom
        {
            bool qw = true;
            for ( int i= 0;i <= q.Length / 2; i++) // go to the middle of the text and check the first and the last element for similarity
            {
                if (q[i] != q[q.Length - 1 - i]) // if they are not then it is not a polyndrom
                {
                    qw = false;
                    return qw;
                } 
            }
            return qw; // if they are equal then function return true value
        }
        static void Main(string[] args)
        {
            string file = File.ReadAllText(@"C:\Users\User\PP2\HW2\task1\text.txt"); // string variable file takes the value of the text in this path
            if (Polyndrom(file)) // check for polyndrom
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");

            Console.ReadKey();

        }
    }
}
