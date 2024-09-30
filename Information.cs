using System.Xml;

namespace Schoolsystem;

public class Information
{
    /* Base Info... */
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int PhoneNumber { get; set; }
    public int SocialNumber { get; private set; }
    public string Address { get; set; } = "";
    public int ZipCode { get; set; }
    public string Place { get; set; } = "";

    public Information(String firstname, String lastname)
    {
        Id = Id;
        FirstName = firstname;
        LastName = lastname;
    }

    /* Methods */
    /* public void SetSocialNumber(int value, object caller)
    {
        if(caller is Leader)
        {
            SocialNumber = value;
        }
        else
        {
            throw UnauthorizedAccessException("Obehörig tillgång till information");
        }
    } */
}