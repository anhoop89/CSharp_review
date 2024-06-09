using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter
{
    internal class BookClass
    {
        private string title;
        private string author;
        private int pages;

        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be empty or null.");
                }
                title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Pages must be a positive number.");
                }
                pages = value;
            }
        }

        // constructor - automatically called  when creating an object
        public BookClass(){
            pages = 0;
            author = "none";
            title = "none";

        }

        // Custom (parameterized) constructor
        public BookClass(string in_title, int in_pages, string in_author)
        {
            Title = in_title;
            Author = in_author;
            Pages = in_pages;
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
