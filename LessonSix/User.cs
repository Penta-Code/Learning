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
        //public int age;

        public void Info()
        {
            Console.WriteLine($"Info:\n{name}");
        }
    }
}