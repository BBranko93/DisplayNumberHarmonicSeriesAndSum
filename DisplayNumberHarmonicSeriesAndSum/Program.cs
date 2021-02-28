using System;

namespace DisplayNumberHarmonicSeriesAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            float i, sum = 0;
            int n;
            Console.WriteLine("Please enter number of terms : ");
            n = int.Parse(Console.ReadLine());
            
            for(i = 1; i <= n; i++)
            {
                
                sum = sum + 1 / i;
                Console.Write("1/" + i + " + ");
           
            }
            Console.WriteLine("\nSum of series up to " + n + " terms : " + sum);
        }
    }
}
