using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title = "LOTR";
            LOTR.Pages = 1137;
            LOTR.Category = "fantasy";
            LOTR.Author = "John Ronald Tolkien";
            LOTR.ReleaseDate = 1937;
            Console.WriteLine(LOTR.ToString());

            Book LOTR2 = new Book();
            Book LOTR3 = new Book("Lord Of The Rings 3", 50);
            Book Hobit = new Book("Hobit", 300, "fantasy", "John Ronald Tolkien", 1937);
            Hobit.category = Book.categoryList[4];
            Console.WriteLine(LOTR2.ToString());
            Console.WriteLine(LOTR3.ToString());
            Console.WriteLine(Hobit.ToString());
        }
    }
}