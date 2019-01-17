using System;

namespace Delegate
{
    public delegate bool CompareDelegate(Student x, Student y);

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

        public void Sort(CompareDelegate compareDelegate)
        {
            for (int i = 0; i < Students.Length; i++)
                for (int j = i + 1; j < Students.Length; j++)
                {
                    if (compareDelegate(Students[i], Students[j]))
                    {
                        Student stTemp = new Student(Students[i]);
                        Students[i] = Students[j];
                        Students[j] = stTemp;
                    }
                }
        }

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
}