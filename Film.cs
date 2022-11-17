using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaRegister
{
    internal class Film : Media
    {

        private string _Director;
        private int _Length;

        public Film(string title, string director, int length)
        {
            _Title = title;
            _Director = director;
            _Length = length;
            _MediaType = 1;
        }

        public override string ToString()
        {
            string filmString = _Title + " (" + _Director + ", " + _Length + " min" + ")";
            return filmString;
        }

        public override string GetCreator()
        {
            return _Director;
        }
        public override int GetLength()
        {
            return _Length;
        }
    }
}
