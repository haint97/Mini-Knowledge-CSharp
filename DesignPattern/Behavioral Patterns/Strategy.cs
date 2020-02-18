using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral_Patterns
{
   // allow a group of  algorithms, encapsulate each one, 
    //and make them interchangeable.Strategy lets the algorithm vary independently from clients that use it
    class Strategy
    {
    }
    public class Student
    {
        public Student(Student st)
        {
            Age = st.Age;
            Id = st.Id;
            Mark = st.Mark;
            Name = st.Name;
        }

        public Student()
        {
        }

        private SortStrategy _sortstrategy;

         void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Mark { get; set; }
    }

   abstract class SortStrategy
    {
        public abstract void Sort(Student[] students);
    }

    public class Container
    {
        public Container()
        {
            Students = new Student[3];
            Students[0] = new Student
            {
                Age = 1,
                Id = 1,
                Mark = 1,
                Name = "a"
            };
            Students[1] = new Student
            {
                Age = 3,
                Id = 3,
                Mark = 3,
                Name = "c"
            };
            Students[2] = new Student
            {
                Age = 2,
                Id = 2,
                Mark = 2,
                Name = "b"
            };
        }

        public Student[] Students { get; set; }

        public void OutputResult()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine("-----" + (i + 1) + "----");
                Console.WriteLine("Id  " + Students[i].Id);
                Console.WriteLine("Name  " + Students[i].Name);
                Console.WriteLine("Mark  " + Students[i].Mark);
                Console.WriteLine("Age  " + Students[i].Age);
            }
        }


    }

    class AgeSortStrategy : SortStrategy
    {
        public override void Sort(Student[] students)
        {
            Console.WriteLine("sorted by age");
        }
    }
    class MarkSortStrategy : SortStrategy
    {
        public override void Sort(Student[] students)
        {
            Console.WriteLine("sorted by mark");
        }
    }

}
