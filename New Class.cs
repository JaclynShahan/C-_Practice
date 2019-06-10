using System;
namespace PracticeProject
{   //this class is a blueprint for a data type
    public class Human
    {   //member variable
        public string firstName;
        public string lastName;
        private string eyeColor;
        private int age;



        //default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }


        //constructor parameterized
        public Human(string myFirstName, string lastName, string eyeColor, int age)
        {
            firstName = myFirstName; //use new variable name or this.variable
            this.lastName = lastName; //both of these work
            this.eyeColor = eyeColor;
            this.age = age;
        }


        //member method
        public void IntroduceMyself()
        {
            if (age != 0)
                Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2}.", firstName, lastName, eyeColor);

            else

            {
                Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2} and I am {3} years old.", firstName, lastName, eyeColor, age);
            }
        }
    }
}