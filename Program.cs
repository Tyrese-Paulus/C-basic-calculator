using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            

            Console.Write("Enter an operation: ");
            string op = Convert.ToString(Console.ReadLine());

            Console.Write("Enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Logic(op, num1, num2));

            Console.ReadLine();
        }

        static int Logic(string operation,int input1,int input2)
        {
            if (operation == "+")
            {
                int result = input1 + input2;
                return result;
            }

            if (operation == "-")
            {
                int result = input1 - input2;
                return result;
            }

            if (operation == "*")
            {
                int result = input1 * input2;
                return result;
            }

            if (operation == "/")
            {
                int result = input1 / input2;
                return result;
            }

            else
            {
                throw new Exception ("Invalid");
            }
        }

    }
}
