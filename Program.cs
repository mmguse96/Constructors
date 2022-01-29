using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Lab_MorganGuse
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("The Hunger Games");
            Book book3 = new Book("catching fire", "Suzanne Collins");
            Book book4 = new Book("Mockingjay", "Suzanne Collins", 390);

            book1.display();
            book2.display();
            book3.display();
            book4.display();
            book4.Invalidate();
            book4.display();

            Console.ReadLine();
        }
    }

    class Book
    {
        private string _bookTitle;
        private string _author;
        private int _pageCount;

        //properties
        public string Title
        {
            get
            {
                return _bookTitle;
            }
            set
            {
                _bookTitle = value;
            }
        }
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }
        public int Pages
        {
            get
            {
                return _pageCount;
            }
            set
            {
                _pageCount = value;
            }
        }
        public string prettyDisplay
        {
            get
            {
                return _bookTitle + " by " + _author;  
            }
        }

        //constructors
        public Book()
        {
            _bookTitle = "none";
            _author = "ghost";
            _pageCount = 0;
        }
        public Book(string _bookTitle)
        {
            _bookTitle = Title;
            _author = "ghost";
            _pageCount = 0;
        }
        public Book(string _bookTitle, string _author)
        {
            _bookTitle = Title;
            _author = Author;
            _pageCount = 0;
        }
        public Book(string _bookTitle, string _author, int _pageCount)
        {
            _bookTitle = Title;
            _author = Author;
            _pageCount = Pages;
        }

        //methods
        public void Invalidate()
        {
            Title = "";
            Author = "";
            Pages = -1;
        }


        public void display()
        {
            
            Console.WriteLine(prettyDisplay);
            Console.WriteLine("------------------");
            Console.WriteLine("Book Title: " + Title);
            Console.WriteLine("Book Author: " + Author);
            Console.WriteLine("# of Pages: " + Pages);
            Console.WriteLine("");            
            
        }

    }

}
