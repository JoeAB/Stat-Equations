using System.IO;
using System;

class Deviation
{
    public static double GetStandardDeviation(Double[] dataSet, double mean)
    {
        double summationSquared = 0;
        foreach(double value in dataSet)
        {
            summationSquared += Math.Pow(value - mean, 2);
        }
        return Math.Sqrt(summationSquared / (dataSet.Length - 1 ));
    }
    static void Main()
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
            Console.WriteLine("Mean of the data set is "+mean);
            Console.WriteLine("STD of the data set is "+GetStandardDeviation(dataSet,mean));
    }
}
