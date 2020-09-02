using System;
using System.Globalization;

namespace StudentUMLExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            Console.WriteLine(myStudent);
            myStudent.FirstName = "Cale";
            myStudent.LastName = "Reinking";
            myStudent.IsOnProbation = true;
            myStudent.SoonerID = 5;

            Console.WriteLine(myStudent);
            Console.WriteLine();
            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);
            Console.WriteLine();
            myStudent.MakePayment(300);
            Console.WriteLine(myStudent);
        }
    }
}
