using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FarManager
{
    class FarManager
    {
        public int cursor; //Создание переменных
        public string path;
        public int size;
        public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;

        public FarManager(string path) //придаем значение созданным переменным 
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path);
            size = directory.GetFileSystemInfos().Length;
            ok = true;
        }

        public void Color(FileSystemInfo fs, int index)//Указываем применяемые цвета в разных случаях. Файл папка или наведен курсор 
        {
            if (cursor == index)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                currentFs = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public void Show()//Показывает файлы и папки, обновляет консоль, чекает скрытые файлы 
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            for (int i = 0, k = 0; i < fs.Length; i++)
            {
                if (ok == false && fs[i].Name[0] == '.') // если есть скрытые то пропускает
                {
                    continue;
                }
                Color(fs[i], k);
                Console.Write(i+1+".");
                Console.WriteLine(fs[i].Name);
                k++;
            }
        }
        public void Up() // функция для создания поднятия курсора вверх
        {
            cursor--;
            if (cursor < 0)
                cursor = size - 1;
        }
        public void Down() // go to downward 
        {
            cursor++;
            if (cursor == size)
                cursor = 0;
        }
        public void Opentxt(string path) // function to open the file
            
        {
            Console.BackgroundColor=ConsoleColor.Blue;
            Console.Clear();
            StreamReader sr = new StreamReader(path);
            string s=sr.ReadToEnd();
            Console.WriteLine(s);
            ConsoleKeyInfo n = Console.ReadKey();
                     if (n.Key == ConsoleKey.Backspace)
                     {
                        sr.Close();
                        return;
                     }
                     else
                        Opentxt(path);
        }

        public void Calc() //Изменяет размер массива с дайректориями взависимости скрытых файлов 
        {
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            size = fs.Length;
            if (ok == false)
                for (int i = 0; i < fs.Length; i++)
                    if (fs[i].Name[0] == '.')
                        size--;
        }
        public void Start()// Основная функция где проходит процессы 
        {
            ConsoleKeyInfo ck = Console.ReadKey();
            while (ck.Key != ConsoleKey.Escape)// until button the escape
            {
                Calc();
                Show();
                ck = Console.ReadKey();
                if (ck.Key == ConsoleKey.UpArrow)
                    Up();
                if (ck.Key == ConsoleKey.DownArrow)
                    Down();
                if (ck.Key == ConsoleKey.RightArrow)
                {
                    ok = false;
                    cursor = 0;
                }
                if (ck.Key == ConsoleKey.LeftArrow)
                {
                    ok = true;
                    cursor = 0;
                }
                if (ck.Key == ConsoleKey.Enter)
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = currentFs.FullName;
                    }
                    else if(currentFs.Name.EndsWith(".txt"))
                        Opentxt(currentFs.FullName);
                }
                if (ck.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    path = directory.Parent.FullName;
                }
                if (ck.Key == ConsoleKey.Delete)
                {
                    string path1 = currentFs.FullName; //Записываем полную дайректорию файла
                    if (currentFs.GetType() == typeof(DirectoryInfo))//Удаляем в зависимости папка это или файл 
                    {
                        Directory.Delete(path1, true);
                    }
                    else
                    {
                        File.Delete(path1);
                    }
                }
                if (ck.Key == ConsoleKey.R)
                {
                    string path1 = directory.FullName;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("Create new name");
                    string name = Console.ReadLine();
                    if (currentFs.GetType() == typeof(FileInfo))
                    {
                        string sourcefile = currentFs.FullName;
                        string destfile = path1 + @"\" + name;
                        File.Move(sourcefile, destfile);
                    }
                    else
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        string sourcedir = currentFs.FullName;
                        string destdir = Path.Combine(path1, name);
                        Directory.Move(sourcedir, destdir);
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/User/PP2/HW2/task1"; // путь файла
            FarManager fm = new FarManager(path); 
            fm.Start();// вызываем функцию
        }
    }
}