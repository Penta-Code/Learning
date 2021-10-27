using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    internal class Author
    {
        private string BookAuthor = "";

        public Author(string bookAuthor)
        {
            BookAuthor = bookAuthor;
        }

        public void Show()
        {
            Console.WriteLine(BookAuthor);
        }
    }
}
