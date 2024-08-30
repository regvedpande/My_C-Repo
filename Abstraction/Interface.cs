using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeProblems.Abstraction

{
    interface IAnimal
    {
        void MakeSound();
    }

    internal class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    internal class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    public class Program
    {
        static void Main()
        {
            IAnimal[] animals = { new Dog(), new Cat() };

            foreach (IAnimal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
