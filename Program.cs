using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number (a): ");
            var a =  Console.ReadLine();
            int successufulnum1;
            bool isSuccessufulNum1 = int.TryParse(a, out successufulnum1);

            if (!isSuccessufulNum1)
            {
                Console.Write("Please enter the number (a)!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.Write("Enter the first number (b): ");
            var b = Console.ReadLine();
            int successufulnum2;
            bool isSuccessufulNum2 = int.TryParse(b, out successufulnum2);

            if (!isSuccessufulNum2)
            {
                Console.Write("Please enter the number (b)!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            int tempNum = successufulnum1;
            successufulnum1 = successufulnum2;
            successufulnum2 = tempNum;

            Console.WriteLine("We are swaping the number a with number b!");
            Console.WriteLine("Now number a is: " + successufulnum1);
            Console.WriteLine("And number b is: " + successufulnum2);
            Console.ReadLine();
        }
    }
}
