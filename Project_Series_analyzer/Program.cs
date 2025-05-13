using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Series_analyzer
{
    internal class Program
    {
        //check number ?!
        static bool checkNumber(string[] numbers)
        {
            string[] numi = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ".", "-", "," };
            bool check = true;

            foreach (var number in numbers)
            {
                foreach (char c in number)
                {
                    if (!numi.Contains(c.ToString()))
                    {
                        Console.WriteLine("Not a number!!");
                        check = false;
                        break;
                    }
                    //if (c == '.' || c == '-' || c == ',')
                    //{
                    //    if (numi[c])
                    //    {
                    //        Console.WriteLine("Not a number!!");
                    //        check = false;
                    //        break;
                    //    }
                    //}
                }
            }
                    if (check)
                    {
                        Console.WriteLine("Numbers :)");
                    }
             return check;
        }
        //a
        static void getSeries()
        { 
            
        }
        //b
        static void setSeries(int[] list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
        //c
        static void ReverceSeries(int[] list)
        { 
            for (int i = getLength(list) -1; i >= 0 ; i--)
            {
                Console.Write(list[i]+" ");  
            }
        }
        //d
        static void sortSeries(int[] list)
        { 
            for (int i = 0; i < getLength(list); i++)
            {
                for (int j = i + 1; j < getLength(list); j++)
                {
                    if (list[i] > list[j])
                    {
                        int tempi = list[i];
                        list[i] = list[j];
                        list[j] = tempi;
                    }
                }
            }
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

        }
        //e
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
        //f
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

        //g
        static int getAverage(int[] list)
        { 
            int leni = getLength(list);
            int sum = getSumOfTheSeries(list);
            int average = sum / leni;
            return average;

        }
        //h
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
        //i
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
            int[] x = { -8,2, 4, 9,-10, 3, 1, -6 };
            //ReverceSeries(x);
            //List<string> list = new List<string> { "1","2","2"};
            //checkNumber(list.ToArray());
            sortSeries(x);
        }
    
    }
}

