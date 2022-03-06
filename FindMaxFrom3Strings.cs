using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblemUsingGenerics
{
    public class FindMaxFrom3Strings
    {
        public void FindMaxNo()
        {
            string str1, str2, str3;
            Console.WriteLine("Enter a first string:");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter a second string");
            str2 = Console.ReadLine();
            Console.WriteLine("Enter a third string:");
            str3 = Console.ReadLine();

            if (str1.Length.CompareTo(str2.Length) == 1 && str1.Length.CompareTo(str3.Length) == 1)
            {
                Console.WriteLine("{0} is maximum ", str1);
            }
            else if (str2.Length.CompareTo(str1.Length) == 1 && str2.Length.CompareTo(str3.Length) == 1)
            {
                Console.WriteLine("{0} is maximum ", str2);

            }
            else
            {
                Console.WriteLine("{0} is maximum ", str3);
            }



        }
    }
}
