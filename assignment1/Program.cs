using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        public delegate void num(int m);
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());
            ClassMethods c = new ClassMethods();
            num nm = c.printnumber;
            nm += c.printMoney;
            nm += c.printHeximal;
            nm(number);
        }
    }
}
