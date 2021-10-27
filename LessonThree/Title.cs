using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    internal class Title
    {
        private string BookTitle = "";

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
