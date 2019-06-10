using System;

namespace PracticeProject

{   //class names like ClientActivity
    class MainClass
    {

        public static void Main(string[] args)
        {

            Human sissy = new Human("Sissy", "Wagner", "green", 43);
            sissy.IntroduceMyself();

            Human jaclyn = new Human("Jaclyn", "Shahan", "blue", 30);
            jaclyn.IntroduceMyself();

            Human chris = new Human("Chris", "Foster", "blue", 32);
            chris.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

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
