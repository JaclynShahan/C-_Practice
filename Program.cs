using System;

namespace PracticeProject

{   //class names like ClientActivity
    class MainClass
    {       

        public static void Main(string[] args)
        {
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            if(numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }

            if (numTemp == 20) 
            {
                Console.WriteLine("Pants and hoodie should be fine");
            }
            if(numTemp > 20)
            {
                Console.WriteLine("Shorts are enough today!");
            }

            Console.Read();
        }
    
    }
}
