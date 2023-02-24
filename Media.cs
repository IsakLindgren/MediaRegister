using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaRegister
{
    internal class Media
    {

        protected string _Title;

        // mediatype is to sort into books(0) and Films(1)
        public int _MediaType;

        public static List<Media> media = new List<Media>();

        public static string Write()
        {
            
            string result = string.Empty;

            foreach (var media in media)
            {

                string mediaString = media.ToString() + Environment.NewLine;

                string tmp = result;

                result = tmp + mediaString;

            }

            return result;
        }

        public static string Write(int mediatype)
        {

            string result = string.Empty;

            foreach (var media in media)
            {
                if (media._MediaType == mediatype)
                {
                    string mediaString = media.ToString() + Environment.NewLine;

                    string tmp = result;

                    result = tmp + mediaString;
                }

            }

            return result;
        }
        public string GetTitle()
        {
            return _Title;
        }
        public virtual string GetCreator()
        {
            return String.Empty;
        }
        public virtual int GetLength()
        {
            return 0;
        }

    }
}
