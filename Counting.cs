using System.IO;
using System;

class Counting
{
    public static int GetNCR(int n, int r)
    {
        int numerator = GetFactorial(n);    
        int denominator = GetFactorial(r) * GetFactorial(n-r);
        return numerator / denominator;
    }
    public static int GetNPR(int n, int r)
    {
        int numerator = GetFactorial(n);    
        int denominator = GetFactorial(n-r);
        return numerator / denominator; 
    }
    public static int GetFactorial(int n)
    {
        if(n!=1)
            return n * GetFactorial(n-1);
        else
            return 1;
    }
    static void Main()
    {
        Console.WriteLine("Enter a value for n");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a value for r");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("NRC = "+ GetNCR(n, r));
        Console.WriteLine("NPR - "+ GetNPR(n, r));
    }
}
