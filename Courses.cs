namespace Schoolsystem;

/* PROPERTIES */
public class Courses
{
    public int CourseNumber { get; set; }
    public string Title { get; set; } = "";
    public DateTime CourseDate { get; set; }
    public string Schedule { get; set; } = "";

    public Courses()
    {
        CourseNumber = 12345;
        Title = "Programmering";
        CourseDate = DateTime.Now;
    }

    public override string ToString()
    {
        return $"CourseNumber: {CourseNumber}, {Title}, Period:{CourseDate}";
    }
}
