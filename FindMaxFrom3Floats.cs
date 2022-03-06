using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblemUsingGenerics
{
    public class FindMaxFrom3Floats
    {
        public void FindMaxNo()
        {
            Double num1, num2, num3;
            Console.WriteLine("Enter a first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a third number:");
            num3 = Convert.ToDouble(Console.ReadLine());

            if (num1.CompareTo(num2) == 1 && num1.CompareTo(num3) == 1)
            {
                Console.WriteLine("{0} is maximum ", num1);
            }
            else if (num2.CompareTo(num1) == 1 && num2.CompareTo(num3) == 1)
            {
                Console.WriteLine("{0} is maximum ", num2);

            }
            else
            {
                Console.WriteLine("{0} is maximum ", num3);
            }



        }
    }
}
