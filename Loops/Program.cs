namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0 ;
            int average ;
            int num;
            string input =""; ;


            do
            {
                Console.Write("Please enter the number u want to add(Make sure its between 0 and 20): ");
                input = Console.ReadLine();
                if (int.TryParse(input, out num))
                {
                    num = int.Parse(input);
                    if (num == -1)
                    {
                        average = sum / count;
                        Console.WriteLine(average);
                        break;
                    }
                    if (num > 0 && num < 20)
                    {
                        sum += num;
                        count++;
                    }
                }
            }
            while (input != "-1");
        }
    }
}