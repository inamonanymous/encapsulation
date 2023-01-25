using System;
using System.Reflection;

namespace preFi
{

    class Year
    {
        public string nameOfStudent = "Aguilar, Stephen Joaquin G.";
        public int year;
        private int yBorn
        {
            get { return year; }

            set { year = value; }
        }

        public int getYear(int year) {

            return this.year = year;

        }

        public int getAge(int currentYear)
        {
            if (currentYear < yBorn) { return -1; }
            return currentYear - yBorn;
        }

        public string verify(int n)
        {
            if (n == -1)
            {
                return "Invalid Input";
            }
            return "Your name: " + nameOfStudent + "\n" + "Your year of birth: " + yBorn + "\n" + "Your age: " + n + " years old";
        }

    }
    class Program
    {

        public static void Main(string[] args)
        {

            Year y = new Year();

            Console.WriteLine("Enter year of birth: ");
            string s = Console.ReadLine();
            int year1 = int.Parse(s);

            int yearOfBorn = y.getYear(year1);
            int result = y.getAge(2023);

            Console.WriteLine(y.verify(result));
            
        }

    }

}