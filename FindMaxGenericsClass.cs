using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMaxGenericsClass1
    {
        public class FindMaxGenericsClass<T> where T : IComparable
        {
            public T first, second, third;
            public FindMaxGenericsClass(T first, T second, T third)
            {
                this.first = first;
                this.second = second;
                this.third = third;
            }
            public static T FindMaxValue(T first, T second, T third)
            {
                if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                {
                    Console.WriteLine("{0} is Maximum", first);
                    return first;
                }
                else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                {
                    Console.WriteLine("{0} is  Maximum", second);
                    return second;
                }
                else
                {
                    Console.WriteLine("{0} is Maximum", third);
                    return third;
                }

            }
            public void TestMaximum()
            {
                T max = FindMaxGenericsClass<T>.FindMaxValue(this.first, this.second, this.third);
            }
        }

    }
   



}

