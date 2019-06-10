using System;

namespace PracticeProject

{   //class names like ClientActivity
    class MainClass
    {

        public static void Main(string[] args)
        {

            Human sissy = new Human();
            sissy.firstName = "Sissy";
            sissy.lastName = "Wagner";
            sissy.IntroduceMyself();

            Human jaclyn = new Human();
            jaclyn.firstName = "Jaclyn";
            jaclyn.lastName = "Shahan";
            jaclyn.IntroduceMyself();

            Console.ReadKey();
            //Human jaclyn = new Human();
            //jaclyn.firstName = "Jaclyn";
            //jaclyn.IntroduceMyself();

            //Human michael = new Human();
            //michael.IntroduceMyself();
            //Console.ReadKey();
          
        }
    }
}
