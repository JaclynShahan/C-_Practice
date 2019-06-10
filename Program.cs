using System;

namespace PracticeProject

{   //class names like ClientActivity
    class MainClass
    {

        public static void Main(string[] args)
        {
            //for (int counter = 0; counter < 10; counter++)
            //{
            //    Console.WriteLine(counter);
            //    if(counter == 3)
            //    {
            //        Console.WriteLine("at 3 we stop");
            //        break;
            //    }
            //}
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if (counter %2 == 0)
                {
                    Console.WriteLine("Here comes an odd number");
                    continue;
                }
            }
            Console.Read();
        }
    }
}
