using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonSix
{
    internal class User
    {
        public string name;
        public string surname;
        public int age;
        public readonly string fillingDate;

        public User(string name, string surname, int age, string date)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.fillingDate = date;
        }

        public void Info()
        {
            Console.WriteLine($"User info:\n{name}\n{surname}\n{age}\n{fillingDate}");
        }

        //public override string ToString()
        //{
        //    return $"User info:\n{name}\n{surname}\n{age}\n{fillingDate}";
        //}
    }
}
