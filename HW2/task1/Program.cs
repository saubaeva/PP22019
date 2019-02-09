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
        public static bool Polyndrom(string q) // like a function to chech for palindrom
        {
            bool qw = true;
            for ( int i= 0;i <= q.Length / 2; i++)
            {
                if (q[i] != q[q.Length - 1 - i]) // check first and last symbol 
                {
                    qw = false;
                    return qw;
                } 
            }
            return qw;
        }
        static void Main(string[] args)
        {
            string file = File.ReadAllText(@"C:\Users\User\HW2\task1\text.txt"); // read from the file
            if (Polyndrom(file))
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");

            Console.ReadKey();

        }
    }
}
