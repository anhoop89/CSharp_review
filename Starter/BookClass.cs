using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter
{
    internal class BookClass
    {
        public string title;
        public string author;
        public int pages;

        // constructor - automatically called  when creating an object
        public BookClass(){
            pages = 0;
            author = "none";
            title = "none";

        }

        public void DisplayBookData()
        {
            if (title != null)
            {
                title = title.Trim();
            }
            if (author != null)
            {
                author = author.Trim();
            }
        }

    }
}
