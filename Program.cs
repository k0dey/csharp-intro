using System;

namespace introduction

{

    class Mathematics
    {
        public int Addition(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public int Subtraction(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        public int Multiplication(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        public double Division (double numberOne, double numberTwo)
        {
            return numberOne / numberTwo;
        }
    }


    class Program
    {

    
        static void Main(string[] args)
        {
            Mathematics maths = new Mathematics();
            int addMePlease = maths.Addition(1,2);
            Console.WriteLine(addMePlease);
            int subtractPlease = maths.Subtraction(10, 5);
            Console.WriteLine(subtractPlease);

           double dividePlease = maths.Division(10, 3);
            Console.WriteLine(dividePlease);
        }
    }
}
