namespace Schoolsystem;

public class Leader : Teachers
{
    public string EmploymentDate { get; set; } = "";

    public Leader()
    {
        Leader.FirstName = "Pankaka";
        Leader.LastName = "blåbär";
        PhoneNumber = 0723100227;
        /* Information obj = new Information();
        obj.SetSocialNumber(20010101, this); */
    }

    public override string ToString()
    {
        return $"Rektor: {FirstName} {LastName} - Telefonnr: {PhoneNumber}";
    }
}
