using System.IO;
using System;

class Average
{
        public static double GetPercentile(double[] dataSet, int percentile)
        {
            int length = dataSet.Length;   
            double position = (length + 1) * (percentile / 100.0);
            int pos = Convert.ToInt32(Math.Floor(position));
            double away = position - pos;
            pos--;//decrement due to working with an array
            double added = away * (dataSet[pos+1] - dataSet[pos]);
            return dataSet[pos] + added;
        }
        
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Enter numbers in the data set");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] dataSet = new double[n];
            double sum = 0;
            for(int i = 0; i < dataSet.Length; i++)
            {
                Console.WriteLine("Enter in number "+(i +1));
                dataSet[i] = Convert.ToDouble(Console.ReadLine());
                sum+=dataSet[i];
            }
            Array.Sort(dataSet);
            double mean = sum / n;
            Console.WriteLine(GetPercentile(dataSet,30 ));
            Console.WriteLine("Mean of the data set is "+mean);
            Console.WriteLine("Median of the data set is "+GetPercentile(dataSet,50));
        }
}