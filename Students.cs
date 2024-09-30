using System.Security.Permissions;

namespace Schoolsystem;

/* PROPERTIES */
public class Students : Information
{
    /* CONSTRUCTORS */

    //Student information...
    public Students(int id, string firstname, string lastname) : base(firstname, lastname)
    {
    }

    /* Methods */
    //    public override string ToString()
    // {
    //     return $"Elev: {FirstName} {LastName}";
    // }

}
