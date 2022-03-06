using System;
namespace FindMaxProblemUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Find Maximum Problem using Generics");
            //FindMaxFrom3Integers obj1 = new FindMaxFrom3Integers();
            //obj1.FindMaxNo();
            FindMaxFrom3Floats obj2 = new FindMaxFrom3Floats();
            obj2.FindMaxNo();
            //FindMaxFrom3Strings obj3 = new FindMaxFrom3Strings();
            //obj3.FindMaxNo();
        }
    }
}