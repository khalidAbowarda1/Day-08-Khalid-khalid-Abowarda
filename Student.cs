namespace Day08
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        // Copy constructor for deep copy
        public Student(Student other)
        {
            Id = other.Id;
            Name = string.Copy(other.Name);
            Grade = other.Grade;
        }

        public override string ToString()
        {
            return $"Student {Id}: {Name}, Grade: {Grade}";
        }
    }
}
