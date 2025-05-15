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
        static void getInput()
        {
           
        }
        //b
        static void getSeries(int[] list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        //c
        static void ReverceSeries(int[] list)
        { 
            for (int i = getLength(list) -1; i >= 0 ; i--)
            {
                Console.Write(list[i]+" ");  
            }
            Console.WriteLine();
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
            Console.WriteLine();

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
        static void Main(string[] args)
        {

            bool boli = true;
            do {
                Console.WriteLine(
                        "a - Enter new series\n" +
                        "b - Show series\n" +
                        "c - Reverse series\n" +
                        "d - Sort series\n" +
                        "e - Max value\n" +
                        "f - Min value\n" +
                        "g - Average\n" +
                        "h - Series length\n" +
                        "i - Sum of series\n" +
                        "j - Exit");
                string input = Console.ReadLine();
                
                int[] x = new int[] { 2, 4, 9, 3, 1, -6, 7 };
                switch (input)
                {
                    case "a":
                        getInput();
                        break;

                    case "b":
                        getSeries(x);
                        break;

                    case "c":
                        ReverceSeries(x);
                        break;

                    case "d":
                        sortSeries(x);
                        break;

                    case "e":
                        Console.WriteLine(getMax(x));
                        break;

                    case "f":
                        Console.WriteLine(getMin(x));
                        break;

                    case "g":
                        Console.WriteLine(getAverage(x));
                        break;

                    case "h":
                        Console.WriteLine(getLength(x));
                        break;

                    case "i":
                        Console.WriteLine(getSumOfTheSeries(x));
                        break;

                    case "j":
                        boli = false;
                        Console.WriteLine("Baybay :) ");
                        break;
                }
            }
            while (boli == true);

        }
    
    }
}

