using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    public class Title
    {
        public string BookTitle = "";

        public Title(string bookTitle)
        {
            BookTitle = bookTitle;
        }

        public void Show()
        {
            Console.WriteLine(BookTitle);
        }
    }
}