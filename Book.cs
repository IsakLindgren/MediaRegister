using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MediaRegister
{
    internal class Book : Media
    {

        private string _Author;
        private int _NrOfPages;

        public Book(string title, string author, int pages)
        {
            _Title = title;
            _Author = author;
            _NrOfPages = pages;
            _MediaType = 0;
        }

        public override string ToString()
        {
            string bookString = _Title + " (" + _Author + ", " + _NrOfPages + " sidor" + ")";
            return bookString;
        }

        public override string GetCreator()
        {
            return _Author;
        }
        public override int GetLength()
        {
            return _NrOfPages;
        }
    }
}