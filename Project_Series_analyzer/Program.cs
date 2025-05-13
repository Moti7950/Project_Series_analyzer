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
        static void ReverceSeries(int[] list)
        { 
            for (int i = getLength(list) -1; i >= 0 ; i--)
            {
                Console.Write(list[i] +" ");  
            }
        }
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

        static int getAverage(int[] list)
        { 
            int leni = getLength(list);
            int sum = getSumOfTheSeries(list);
            int average = sum / leni;
            return average;

        }
        static int getLength(int[] list)
        {
            int leni = 0;
            foreach (int i in list)
            {
                if (i != 0)
                {
                    leni++;
                }
            }
            return leni;
        }
        static int getSumOfTheSeries(int[] list)
        {
            int sum = 0;
                foreach ( int i in list)
                {
                    if (i != 0)
                    {
                        sum += i;
                    }
                }
            return sum;
        }
        static void orgivingSeries()
        { 
            
        }
        static void Exit()
        {
        }
        static void Main(string[] args)
        {

            //Console.WriteLine(getMin(new int[] { 2, 4, 6, 3, 1, -6, 7 }));
            //Console.WriteLine(getMax(new int[] { 2, 4, 9, 3, 1, -6, 7 }));
            //Console.WriteLine(getLength(new int[] { }));
            //Console.WriteLine(getSumOfTheSeries(new int[] { 2, 4, 9, 3, 1, -6, 7 }));
            //Console.WriteLine(getSumOfTheSeries(new int[] {}));
            //Console.WriteLine(getAverage(new int[] { 2, 4, 9, 3, 1, -6, 7 }));
            int[] x = { 2, 4, 9, 3, 1, -6, 7 };
            ReverceSeries(x);


        }
    
    }
}

