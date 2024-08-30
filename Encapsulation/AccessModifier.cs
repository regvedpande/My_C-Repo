//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace PracticeProblems.AccessModifier
//{
//    internal class AccessModifier
//    {

//        public int PublicField = 10;
//        public void PublicMethod()
//        {
//            Console.WriteLine("This is a public method.");
//        }


//        private int PrivateField = 20;
//        private void PrivateMethod()
//        {
//            Console.WriteLine("This is a private method.");
//        }


//        protected int ProtectedField = 30;
//        protected void ProtectedMethod()
//        {
//            Console.WriteLine("This is a protected method.");
//        }

//        internal int InternalField = 40;
//        internal void InternalMethod()
//        {
//            Console.WriteLine("This is an internal method.");
//        }

//        public void PrintPrivateAndProtectedFields()
//        {
//            Console.WriteLine("Private Field: " + PrivateField);
//            Console.WriteLine("Protected Field: " + ProtectedField);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            AccessModifier accessModifier = new AccessModifier();

//            // For Public Members
//            Console.WriteLine("Public Field: " + accessModifier.PublicField);
//            accessModifier.PublicMethod();

//            // For Private and Protected using the public method
//            accessModifier.PrintPrivateAndProtectedFields();

//            // For Internal Members
//            Console.WriteLine("Internal Field: " + accessModifier.InternalField);
//            accessModifier.InternalMethod();
//        }
//    }
//}