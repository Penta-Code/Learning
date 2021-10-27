using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    internal class Content
    {
        private string BookContent = "";

        public Content(string bookContent)
        {
            BookContent = bookContent;
        }

        public void Show()
        {
            Console.WriteLine(BookContent);
        }
    }
}
