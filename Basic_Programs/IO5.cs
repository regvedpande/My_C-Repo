//using System;

//namespace PracticeProblems.Basic_Programs
//{
//    class Program
//    {
//        static void Main()
//        {
//            string name = "";

//            for (int attempt = 1; attempt <= 3; attempt++)
//            {
//                Console.WriteLine("Enter your name:");
//                name = Console.ReadLine();

//                if (!string.IsNullOrEmpty(name))
//                {
//                    Console.WriteLine($"Hello, {name}! Welcome to C# programming.");
//                    return;
//                }
//                else
//                {
//                    Console.WriteLine($"Attempt {attempt}/3: Invalid input. Name cannot be empty.");
//                }
//            }

//            Console.WriteLine("You have exceeded the maximum attempts. Exiting program.");

//        }
//    }
//}
