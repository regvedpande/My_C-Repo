//using System;

//namespace PracticeProblems.Polymorphism
//{
//    internal class Animal
//    {
//        public virtual void MakeSound()
//        {
//            Console.WriteLine("Generic animal sound");
//        }
//    }

//    internal class Dog : Animal
//    {
//        public override void MakeSound()
//        {
//            Console.WriteLine("Woof!");
//        }
//    }

//    internal class Cat : Animal
//    {
//        public override void MakeSound()
//        {
//            Console.WriteLine("Meow!");
//        }
//    }

//    public class Program
//    {
//        static void Main()
//        {
//            Animal[] animals = { new Dog(), new Cat() };

//            foreach (Animal animal in animals)
//            {
//                animal.MakeSound();
//            }
//        }
//    }
//}