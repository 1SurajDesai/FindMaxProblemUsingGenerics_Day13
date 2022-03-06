using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxProblemUsingGenerics
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] value;

        public GenericMaximum(T[] value)
        {
            this.value = value;

        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T maxValues(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public void printMaxValue()
        {
            var max = maxValues(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
