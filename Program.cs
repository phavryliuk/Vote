using System;
using System.Collections.Generic;

namespace VoteProgram
{
    class Vote
    {
        public string Topic { get; set; }
        public Dictionary<string, int> Options { get; set; }

        public Vote(string topic, Dictionary<string, int> options)
        {
            Topic = topic;
            Options = options;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Voting Program!");
            Console.WriteLine("1. Create Vote Topic");
            Console.WriteLine("2. Vote");
            Console.WriteLine("3. Show Results");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            while (choice != 4)
            {
                if (choice == 1)
                {
                    Console.WriteLine("Enter the vote topic: ");
                    string topic = Console.ReadLine();
                    Console.WriteLine("Enter the number of options for the vote topic: ");
                    int numOptions = int.Parse(Console.ReadLine());
                    Dictionary<string, int> options = new Dictionary<string, int>();
                    Console.WriteLine("Enter the options: ");
                    for (int i = 0; i < numOptions; i++)
                    {
                        Console.WriteLine("Enter option " + (i + 1) + ": ");
                        options.Add(Console.ReadLine(), 0);
                    }
                    Vote vote = new Vote(topic, options);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the vote topic: ");
                    string topic = Console.ReadLine();
                    Console.WriteLine("Enter your choice: ");
                    string option = Console.ReadLine();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter the vote topic: ");
                    string topic = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
            }
        }
    }
}
