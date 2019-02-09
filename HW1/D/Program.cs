using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "[*]"; // один экземпляр star triangle
            int a = int.Parse(Console.ReadLine()); // вводим число
            for (int i=1; i <= a; i++ ) // исполбзуем loop в loop - е 
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(s); // выводим возрастающее каждой итерацией star triangle
                }
                Console.WriteLine(); // переход в следующую строку
            }
            Console.ReadLine();   
        }
    }
}
