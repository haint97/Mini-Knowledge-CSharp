namespace Delegate
{
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

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Mark { get; set; }
    }
}