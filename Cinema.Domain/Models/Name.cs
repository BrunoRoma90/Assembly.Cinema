using Cinema.Domain.Common;


namespace Cinema.Domain.Models;

public class Name : AuditableEntity<int>
{
    public string FirstName { get; set; }

    public string[] MiddleNames { get; set; }
    public string LastName { get; set; }

    public string FullName => $"{FirstName} {string.Join(" ", MiddleNames)} {LastName}";

    private Name()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        MiddleNames = [];
    }
    public Name(string firstName, string lastName) : this()
    {
        FirstName = firstName;
        LastName = lastName;
    }


    public Name(string firstName, string middleNames, string lastName) : this(firstName, lastName)
    {
        MiddleNames = middleNames.Split("");
    }

    public Name(string fullName) : this(
        fullName.Split()[0],
        fullName.Split("")[fullName.Split("").Length -1]) 
    {

    }

}




