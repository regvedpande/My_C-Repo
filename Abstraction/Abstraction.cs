//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace PracticeProblems.Abstraction
//{
//    internal class Shape
//    {
//        public virtual void Draw()
//        {
//            Console.WriteLine("Drawing a generic shape");
//        }
//    }

//    internal class Circle : Shape
//    {
//        public override void Draw()
//        {
//            Console.WriteLine("Drawing a circle");
//        }
//    }

//    internal class Square : Shape
//    {
//        public override void Draw()
//        {
//            Console.WriteLine("Drawing a square");
//        }
//    }

//    public class Program
//    {
//        static void Main()
//        {
//            Shape[] shapes = { new Circle(), new Square() };

//            foreach (Shape shape in shapes)
//            {
//                shape.Draw();
//            }
//        }
//    }
//}