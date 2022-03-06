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
            //FindMaxFrom3Floats obj2 = new FindMaxFrom3Floats();
            //obj2.FindMaxNo();
            //FindMaxFrom3Strings obj3 = new FindMaxFrom3Strings();
            //obj3.FindMaxNo();
            int[] intArray = { 1, 2, 3, 4 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.printMaxValue();
            double[] doubleArray = { 2.3, 4.5, 6.7, 23.4 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.printMaxValue();
        }
    }
}