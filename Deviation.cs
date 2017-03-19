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
    public static double GetCorrelation(Double[] xSet,Double[] ySet, double xMean, double yMean)
    {
        double summationProduct = 0;

        for(int i = 0; i < xSet.Length; i++)
        {
            Console.WriteLine((xSet[i] - xMean) * (ySet[i] - yMean));
            summationProduct += (xSet[i] - xMean) * (ySet[i] - yMean);
        }
        double xSTD = GetStandardDeviation(xSet, xMean);
        double ySTD = GetStandardDeviation(ySet, yMean);
        double numerator = summationProduct / (xSet.Length -1);
        double denominator = xSTD * ySTD;
        return (numerator / denominator);
    }
    public static double GetCoefficientVariance(double std, double mean)
	{
		return std / mean;
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
