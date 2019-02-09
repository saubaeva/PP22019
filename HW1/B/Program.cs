using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        class Student // Создаем класс с именем "Student"
        {
            private string name; // имя студента
            private string id; // ID студента 
            private int yearofstudy; // год обучения студента 
            public Student(string name, string id) // создаем конструктор с двумя параметрами
            {
                this.name = name; // вводится имя  this пишется чтобы компилятор не перепутал переменные 
                this.id = id; // вводится айди
            }
            public void Increment() // Метод для инкрементирования года обучения обьекта студента
            {
                yearofstudy++;
            }
            public int YearofStudy // Это делается для доступа в приватному свойству yearofstudy
            {
                get
                {
                    return yearofstudy;
                }
                set
                {
                    yearofstudy = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("Aktoty", "18BD110375"); // создаем обьект класса Студент
            s.YearofStudy = 1; // по умолчанию значение равно 1
            s.Increment(); // после метода значение инкрементируются (+1), то есть равно 2
            Console.WriteLine(s.YearofStudy); // Показываю, что метод increment работает (Вывод : 2)

                }
    }
}
