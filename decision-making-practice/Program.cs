namespace DecisionMakingPractice
{
    internal class Program
    {
        //    private static void Main(string[] args)
        //    {
        //        Console.Write("Enter the Temperature:");
        //        string temp = Console.ReadLine();
        //        int num;

        //        if (int.TryParse(temp,out num))
        //        {
        //            num = int.Parse(temp);
        //        }
        //        else
        //        {
        //            num = 0;
        //            Console.WriteLine("Invalid value entered, so the temp is set to 0");

        //        }

        //        if (num > 0 && num< 20)
        //        {
        //            Console.WriteLine("its freezing out there!!");

        //        }
        //        else if (num == 20)
        //        {
        //            Console.WriteLine("It is nice out there!");

        //        }

        //    }
        //}
        private static void Main(string[]args)
        {
            Console.WriteLine("Welcome User!");
            Console.WriteLine("Please Register first!");
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your age:");
            string ageStr = Console.ReadLine();
            int age;
            Console.Write("Enter your password:");
            string password = Console.ReadLine();

            if (int.TryParse(ageStr, out age))
            {
                age = int.Parse(ageStr);
                Console.WriteLine("you have registered succesfully");
                Console.WriteLine("Please Login now");
                Console.Write("Enter your name:");
                string nameL = Console.ReadLine();
                Console.Write("Enter your age:");
                int ageL = int.Parse(Console.ReadLine());
                Console.Write("Enter your password:");
                string passwordL = Console.ReadLine();

                if (name == nameL && age == ageL && password == passwordL)
                {
                    Console.Write("you have logged in successfully:");

                }
                else
                {
                    Console.WriteLine("Invalid info entered:Program Exiting");
                }


            }
            else
            {
               
                age = 0;
                Console.WriteLine("Ivalid Age entered,So the program is ending");
            }

        }
    }
}