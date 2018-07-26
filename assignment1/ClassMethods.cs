using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class ClassMethods
    {
        int intvalue;
        decimal decimalvalue;
        int hxvalue;

        public void printnumber(int number)
        {
            intvalue = number;
            Console.WriteLine("Given value:" + intvalue.ToString("n1", CultureInfo.InvariantCulture));
        }
        public void printMoney(int number)
        {
            intvalue = number;
            Console.WriteLine("Given Amount:" + decimalvalue.ToString("C", CultureInfo.CurrentCulture));

        }

        public void printHeximal(int number)
        {
            hxvalue = number;
            Console.WriteLine("hexadecimal:" + hxvalue.ToString("x"));
        }


    }
}
