using System;

namespace EnumExample
{
    class Program
    {
        enum DaysOfTheWeek
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 7:");
            var input = Console.ReadLine();
            int dayNum;
            if (int.TryParse(input, out dayNum) && Enum.IsDefined(typeof(DaysOfTheWeek), dayNum))
            {
                var day = (DaysOfTheWeek)dayNum;
                Console.WriteLine("The day is: " + day);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            }
        }
    }
}