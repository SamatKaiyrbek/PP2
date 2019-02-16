using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        public string name, id;//глобально обьявил переменные name id
        public int year;// глобально обьявил переменные year

        public Student(string name, string id)//конструктор с 2 знач.
        {
            this.name = name;
            this.id = id;
        }
        public string Info()// метод для возврата значения name and id
        {
            return name + " " + id;
        }
        public int Year(int year)// возвращает incremented year 
        {
            return year;// increment year
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Samat", "18BD111225");//создаем аналог класса Student в классе Program
            Console.WriteLine(student.Info());//возращаем и выводим Student()
            Console.WriteLine(student.Year(1));
            Console.ReadKey();
        }
    }
}