using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    public class Author
    {
        public string BookAuthor = "";

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
