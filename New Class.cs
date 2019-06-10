using System;
namespace PracticeProject
{   //this class is a blueprint for a data type
    public class Human
    {   //member variable
        public string firstName;
        public string lastName;
        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);

        }
    }
}
