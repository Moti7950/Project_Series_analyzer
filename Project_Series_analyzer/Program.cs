using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Series_analyzer
{
    internal class Program
    {
        static void getSeries()
        { }
        static void reverceSeries()
        { }
        static int getMax(int[] list)
        {
            int max = list[0];
            foreach (int i in list)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        static int getMin(int[] list)
        {
            int min = list[0];
            foreach (int i in list)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }

            static void getAverage()
        { }
        static void getLength()
        { }
        static void getSumOfTheSeries()
        { }
        static void orgivingSeries()
        { }
        static void Exit()
        { }
        static void Main(string[] args)
        {
            Console.WriteLine(getMin(new int[] { 2, 4, 6, 3, 1, -6, 7 }));
            Console.WriteLine(getMax(new int[] { 2, 4, 9, 3, 1, -6, 7 }));
        }
    
    }
}
