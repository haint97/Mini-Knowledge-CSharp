using System;

namespace Delegate
{
    internal class Program
    {
        //delegate is a reference type, it reference to function
        private static void Main(string[] args)
        {
            Container container = new Container();
            Console.WriteLine("Original result");
            container.OutputResult();
            container.Sort(CompareByAge);
            Console.WriteLine("sort by age");
            container.OutputResult();
            container.Sort(CompareByMark);
            Console.WriteLine("sort by mark");
            container.OutputResult();
            Console.ReadKey();
        }

        public static bool CompareByAge(Student st1, Student st2)
        {
            return st1.Age > st2.Age;
        }

        public static bool CompareByMark(Student st1, Student st2)
        {
            return st1.Mark < st2.Mark;
        }
    }
}