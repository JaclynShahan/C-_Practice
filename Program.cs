using System;

namespace PracticeProject

{   //class names like ClientActivity
    class MainClass
    {

        public static void Main(string[] args)
        {
            //for loop
            //    for (int counter = 1; counter < 20; counter += 2)
            //    {
            //        Console.WriteLine(counter);

            //    }
            //    Console.Read();
            //}
            //    for (int counter = 0; counter < 50; counter+=5)
            //    {
            //        Console.WriteLine(counter);
            //    }
            //       Console.WriteLine("For loop is done.");
            //    Console.Read();
            //}
            //do While loop

            //int lengthOfText = 0;
            //string wholeText = "";

            //do
            //{
            //    Console.WriteLine("Please enter the name of a friend");
            //    string nameOfAFriend = Console.ReadLine();
            //    int currentLength = nameOfAFriend.Length;
            //    lengthOfText += currentLength;
            //    wholeText += nameOfAFriend;

            //}
            //while (lengthOfText < 20);
            //Console.WriteLine("Thanks, that was enough");
            //Console.Read();
            int counter = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else" + 
                                 " enter if you want to finish counting");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine("{0} people are inside the bus", counter);
            }
            Console.Read();
        }
    }
}
