using System;
using System.Collections.Generic;
using System.Text;

namespace StudentUMLExample
{
    class Student
    {
        //Hold alt + Shift to write on multiple lines
        public int SoonerID { get; set; }
       public string FirstName          { get; set; }
         public string LastName             { get; set; }
           public bool IsOnProbation          { get; set; }
           public double GPA                  { get; set; }
        //Do not need get set for private
        private double BursarBalance;
        
        public Student()
        {
            SoonerID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 1000;

        }
        public Student(int id, string fName, string lName, double BursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }
        public void MakePayment(double amount)
        {
            if (amount > 0)
            {
                BursarBalance = BursarBalance - amount;
                 // BursarBalance -= amount;
            }
            else
            {
                throw new Exception();
            }
        }
        /// <summary>
        /// Made to check balance
        /// </summary>
        /// <returns></returns>
        public double CheckBalance()
        {
            return BursarBalance;
        }
        //Overriding creates a string representation of our instance of the class
        public override string ToString()
        {
            string output = $"{FirstName} {LastName} {SoonerID}";
            if (IsOnProbation == true)
            {
                output += "is on probation.\n";
            }
            else
            {
                output += "is not on probation.\n"
            }
            output += $"They have a {GPA.ToString("N2")}";
            SoonerID = "";
            FirstName
            LastName
            IsOnProbation
            GPA = 0;
            return base.ToString();
        }
    }
}
