using System;

namespace PracticeProject

{   //class names like ClientActivity
    class MainClass
    {       

        public static void Main(string[] args)
        {
           // string input = Console.ReadLine(); //one line of user input
            Console.WriteLine(Calculate());
            Console.Read();
            //int result = Add(15, 31);
           // Console.WriteLine(Multiply(25, 46));
            //Console.WriteLine(Divide(100, 22));
            //Console.Read();
            //WriteSomething();
            //WriteSomethingSpecific("I am an argument and am called from a method");
            //Console.Read();
        }
        public static int Calculate()
        {   
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;
            return result;
        }
        //public static int Add(int num1, int num2)
        //{
        //    return num1 + num2; 
        //}

        //public static int Multiply(int num1, int num2)
        //{
        //    return num1 * num2;
        //}

        //public static double Divide (double num1, double num2)
        //{
        //    return num1 / num2;
        //}
        ////access modifier (static) return type method name (param1, param2)
        //public static void WriteSomething()
        //{
        //    Console.WriteLine("I am called from a method");
        //}

        //public static void WriteSomethingSpecific(string myText)
        //{
        //    Console.WriteLine(myText);
           
        //}
    }
}