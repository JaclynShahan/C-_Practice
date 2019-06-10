using System;

namespace PracticeProject

{   //class names like ClientActivity
    class MainClass
    {       

        public static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            Console.WriteLine("Please enter Username:");
            string userName = Console.ReadLine();


            if (isRegistered && userName != "" && userName.Equals("admin")) ;
            {
                Console.WriteLine("Hi there, registered user");

                    Console.WriteLine("Hi There, " + userName);
                 
                        Console.WriteLine("Hi there, Admin.");
                    
                
            }

                if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in.");
            }

            Console.Read();
        }


    
    }
}
