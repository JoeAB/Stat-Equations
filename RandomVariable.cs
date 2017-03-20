using System.IO;
using System;
class RandomVariable
{
    //variance
    public static double GetSigmaSquared(double[] dataSet,double[] frequencies, double mu, int numObservations)
    {
        double sigmaSquared = 0;
        double current = 0;
        for(int i = 0; i <dataSet.Length; i++)
        {
            current = (frequencies[i] / numObservations) * Math.Pow(dataSet[i] - mu, 2);
            //Console.WriteLine(current);
            sigmaSquared += current;
        }
        return sigmaSquared;
    }
    //standard deviation
    public static double GetSigma(double sigmaSquared)
    {
        return Math.Sqrt(sigmaSquared);
    }
    //mean 
    public static double GetMu(double[] dataSet,double[] frequencies, int numObservations)
    {
        double mu = 0;
        for(int i= 0; i < dataSet.Length; i++)
        {
               mu+= dataSet[i] * (frequencies[i]/numObservations) ;
        }
        return mu;
    }
    static void Main()
    {
        double[] dataSet = new double[]{0,1,2,3,4};
        double[] freq = new double[]{2,5,6,4,3};
        int num = 20;
        double mu = GetMu(dataSet, freq, num);
        double sigmaSquared = GetSigmaSquared(dataSet, freq,mu, num);
        double sigma = GetSigma(sigmaSquared);
        Console.WriteLine(sigma);
    }
}