using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements__if_else_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            if (num > 0)
            {
                Console.WriteLine("Number is Postive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }
    }
}
