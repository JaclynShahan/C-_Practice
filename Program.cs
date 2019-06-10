using System;

namespace PracticeProject

{   //class names like ClientActivity
    class MainClass
    {       

        public static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like today?");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);
            int number;

            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                number = 0;
                Console.WriteLine("value entered was no number. o set as temperature");
            }
            if(numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            } else if(numTemp == 20)
            {
                Console.WriteLine("Pants and hoodie should be fine");
            } else if (numTemp > 30)
            {
                Console.WriteLine("It's Hot");
            }
            else
            {
                Console.WriteLine("Shorts are enough for today");
            }
            Console.Read();
        }
    
    }
}
