using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Book

    {
        public string title;
        public int pages;
        public string category;
        public string author;
        public int releaseDate;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                pages = value;
                if (pages < 0)
                {
                    pages = 1;
                }
            }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                releaseDate = value;
                if (releaseDate < 1450 | releaseDate > 2021)
                {
                    releaseDate = -1;
                }
            }
        }
        public override string ToString()
        {
            return ($"{title}\n{pages}\n{category}\n{author}\n{releaseDate}");
        }
    }
}