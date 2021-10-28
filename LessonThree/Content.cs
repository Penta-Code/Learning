using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    public class Content
    {
        public string BookContent = "";

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
