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
            LOTR.SetTitle("LOTR");
            LOTR.SetPages(1137);
            LOTR.SetCategory("fantasy");
            LOTR.SetAuthor("John Ronald Tolkien");
            LOTR.SetReleaseDate(1937);
            LOTR.Vypis();
        }
    }
}