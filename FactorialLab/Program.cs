using System;

namespace FactorialLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn)
            {
                int i, fact;

                int number = Convert.ToInt32(GetInput("Enter an Integer"));

                fact = number;

                for (i = number - 1; i >= 1; i--)
                {
                    fact = fact * i;

                }
                Console.WriteLine($"You entered the number  {number} and its factorial is {fact}");



                goOn = Continue(); 
            }

        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();

            return output;
        }

        public static bool Continue()
        {

            string answer = GetInput("Would you like to continue? y/n");
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand");
                Console.WriteLine("Let's try again.");

                // This is recursion, calling a method inside itself
                return Continue();
            }

        }
    }
}
