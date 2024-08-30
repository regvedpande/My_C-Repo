//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeProblems.Basic_Programs
//{

//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter your age:");
//            int age;

//            while (!int.TryParse(Console.ReadLine(), out age))
//            {
//                Console.WriteLine("Invalid age. Please enter a valid number:");
//            }

//            if (age >= 0 && age <= 120)
//            {
//                if (age < 18)
//                {
//                    Console.WriteLine("You are a minor.");
//                }
//                else if (age >= 18 && age < 65)
//                {
//                    Console.WriteLine("You are an adult.");
//                }
//                else
//                {
//                    Console.WriteLine("You are a senior citizen.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Invalid age. Please enter a realistic age.");
//            }

//        }
//    }

//}
