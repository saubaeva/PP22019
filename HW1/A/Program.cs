using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static bool Prime(int n) //буленовая функция проверяющая простое ли число
        {
            bool b = true;
            if (n <= 1)
            {
                b = false;
            }
            for (int i = 2; i < n; i++)
            {
                if ( n % i == 0)// Если найдется число на которое делится проверяющееся число, то функция возвращает false, то есть число не простое
                {
                    b = false;
                    return b;
                }
            }
            return b;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // вводим количество элементов массива
            int[] arr = new int[n];
            string s = Console.ReadLine(); // вводим элементы массива через строку
            string[] ss = s.Split(' '); // разделяем каждое число на отдельные элементы массива
            for ( int i=0; i < ss.Length; i++) // конвертируем стринговые числа в интиджер
            {
                arr[i] = int.Parse(ss[i]);
            }
            List<int> b = new List<int>(); // обьявляем интовый массив
            foreach (int q in arr) // пробегаемся по массиву
            {
                if (Prime(q)) // проверяем простые числа и вводим их в другой массив
                {
                    b.Add(q);
                }
            }
            Console.WriteLine(b.ToArray().Length); // Выводим количество простых числа через пробел
            for ( int i=0; i < b.ToArray().Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.ReadLine(); // это чтобы консоль не закрывалась сразу
        }
    }
}
