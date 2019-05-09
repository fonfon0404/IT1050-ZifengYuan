using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Book
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Author { get; internal set; }

        internal void Display()
        {
            Console.WriteLine("About the Book");
            Console.WriteLine();
            Console.Write("Title:  ");
            Console.WriteLine(Title);
            Console.Write("Author: ");
            Console.WriteLine(Author);
            Console.Write("Year:   ");
            Console.WriteLine(Year);
        }

    }
}