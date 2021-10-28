using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    public class Book
    {
        public string Title { set; get; }
        public string Author { set; get; }
        public string Content { set; get; }

        public override string ToString()
        {
            return $"Author is {Author}.\nTitle is {Title}.\nContent: {Content}";
        }
    }
}
