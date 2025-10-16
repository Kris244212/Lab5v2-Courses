namespace Lab5v2
{
    public class Enrollment
    {
        public Course Course { get; }
        public Student Student { get; }
        public double Grade { get; }

        public Enrollment(Course course, Student student, double grade)
        {
            if (grade < 0 || grade > 100)
                throw new ArgumentException("Оцінка має бути в межах 0–100");

            Course = course;
            Student = student;
            Grade = grade;
        }
    }
}
