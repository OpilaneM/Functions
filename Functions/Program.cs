using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta esimene arv");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teine arv");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vali tehe (sisesta '+','-','*',  või '/'");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    subtractTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    multiplyTwoNumbers(userNumberOne, userNumberTwo);
                    break;

                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
            Console.Read();

        }
        public static void DivideTwoNumbers(double x, double y)
        {

            double result = x / y;
            Console.WriteLine(result);
            Console.Read();
        }       
        
        public static void subtractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
            Console.Read();

        }
        public static void multiplyTwoNumbers (double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
            Console.Read();

        }
    }
}
