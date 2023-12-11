using System.Threading;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // the order matters in this if the console.background is at the end it will only change the background of the text after the program is done running and showing the dir
        //Console.BackgroundColor = ConsoleColor.White;
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.Clear();
        //Console.WriteLine("Hello, World!");
        //Console.WriteLine("Press any key to exit.");
        //string num = "23";

        //int num1 = Convert.ToInt32(num);
        //int num2 = int.Parse(num);
        ////int num3 = Int32.Parse(num);
        //const int num3 = 23; 
        //Console.WriteLine("The num is {0}", num3);
        //Console.WriteLine("The num is "  +  num3);

        //Console.WriteLine(num1 + num2);
        //Greet("Frank", "Tom", "Sue");

        //Console.WriteLine(Sum());

        try { 
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is {0}", age);
    }catch(Exception e)
        {
            Console.WriteLine("Please enter a number");
        }
            

    }

    //static void Greet(string name1,string name2,string name3)
    //{
    //    Console.WriteLine("Hi {0}, my friend!", name1);
    //    Console.WriteLine("Hi {0}, my friend!", name2);
    //    Console.WriteLine("Hi {0}, my friend!", name3);



    //}
    //static int Sum() { 
    //    Console.WriteLine("Please enter the Number you want to add:");
    //    Console.Write("Enter Number 1:");
    //    int num1 = Convert.ToInt32(Console.ReadLine());
    //    Console.Write("Enter Number 2:");
    //    int num2 = Convert.ToInt32(Console.ReadLine());

    //    return num1 + num2;

    //}

}

//In this challenge you will deepen your understanding for methods.
//Please go ahead and create three variables with names of your friends.
//Then create a Method "GreetFriend" which writes something like: "Hi Frank, my friend!" onto the console, once it is called.
//Where "Frank" should be replaced with the Name behind the argument given to the Method when it's called. So the method will need a parameter (decide which DataType will be best). 

//Greet all your three friends.
