// Cale J Reinking
using System;
using System.Security.Cryptography.X509Certificates;

namespace Methods_Participation
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1 = 2;
                double num2 = 5;
            var name = Console.ReadLine();
            var summation = Add(num1, num2);
            Console.WriteLine(summation.ToString("C5"));
        }
        public static double Add(double firstnumber, double secondnumber)
        {
            double sum = 0;
            sum = firstnumber + secondnumber;
        }
            
    }
}
