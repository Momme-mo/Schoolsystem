namespace Schoolsystem;

/* PROPERTIES */
public class Teachers : Information
{
    public string Knowledge { get; set; } = "";
    public string TeachingCourses { get; set; } = "";

    /* CONSTRUCTORS */
    public Teachers()
    {
        FirstName = "Nabil";
        LastName = "Merhi";
        Knowledge = "Civilingenjör, systemutvecklare";
        TeachingCourses = "Produktutveckling";
    }
    /* METHODS */
    public override string ToString()
    {
        return $"Lärare: {FirstName} {LastName} - Undervisar: {TeachingCourses} - Utbildning: {Knowledge}";
    }
}

