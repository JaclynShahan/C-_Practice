using System;

namespace PracticeProject

{   //class names like ClientActivity
    class MainClass
    {       

        public static void Main(string[] args)
        {
         Console.WriteLine("Please write a number!");
            string userInput = Console.ReadLine();
            try
            {
                int userInputasInt = int.Parse(userInput);  
            }
            catch (FormatException)
            {
                 Console.WriteLine("Format Exception, please enter correct type next time");
            } catch (Exception)
            {
                Console.WriteLine("General Exception. Something went wrong");
            }

            Console.ReadKey();
        }
    
    }
}