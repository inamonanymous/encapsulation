using System;
namespace preFi {

    class Year {
        public string nameOfStudent = "Aguilar, Stephen Joaquin G."; 
        public int year = 2002;
        private int yBorn
        {
            get { return year; }

            set{ year = value; }
        }

        public int getAge(int currentYear) {
            if (currentYear < yBorn) { return -1; } 
            return currentYear - yBorn;
        }

        public string verify(int n) {
            if (n == -1) {
                return "Invalid Input";
            }
            return "Your name: " + nameOfStudent + "\n" + "Your year of birth: " + year + "\n" + "Your age: " + n + " years old";
        }

    }
    class Program
    {

        public static void Main(string[] args) {
            Year y = new Year();
            int result = y.getAge(2022);
            Console.WriteLine(y.verify(result));
        }  
    
    }

}