using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MediaRegister
{
    public static class extensions
    {

        public static int DecimalToInt(this decimal value)
        {
            return Decimal.ToInt32(value);
        }

        public static string Write(int filterVal)
        {
            string result = string.Empty;
            switch (filterVal)
            {
                case 0:
                    result = Media.Write();
                    break;

                case 1:
                    result = Media.Write(0);
                    break;

                case 2:
                    result = Media.Write(1);
                    break;

                default:
                    result = Media.Write();
                    break;

            }
            return result;
        }

    }
}