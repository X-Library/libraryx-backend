using LibraryX.Api.SharedContext.Exceptions;

namespace LibraryX.Api.SharedContext.ValueObjects;

public class Name : ValueObject
{
    #region constructors
    
    public Name(Name name)
    {
        name = NameSplitter(name);
        
        if (string.IsNullOrEmpty(name.FirstName) | string.IsNullOrEmpty(name.LastName)) 
            throw new ArgumentNullException("This field can not be null or empty;");

        if (name.FirstName.Length <= 2 | name.LastName.Length <= 2)
            throw new InvalidNameLengthException("This field must have more than 2 characters");

        if (name.FirstName.Length >= 80 | name.LastName.Length >= 80)
            throw new InvalidNameLengthException("This field must have less than 80 characters");

        FirstName = name.FirstName; 
        LastName = name.LastName;
    }

    public Name(string firstName, string lastName)
    {
        if (string.IsNullOrEmpty(firstName) | string.IsNullOrEmpty(lastName))
            throw new ArgumentNullException("This field can not be null or empty;");
        
        if (firstName.Length <= 2 | lastName.Length <= 2)
            throw new InvalidNameLengthException("This field must have more than 2 characters");

        if (firstName.Length >= 80 | lastName.Length >= 80)
            throw new InvalidNameLengthException("This field must have less than 80 characters");
        FirstName = firstName;
        LastName = lastName;
    }

    #endregion

    #region properties

    public string FirstName { get; set; } 

    public string LastName { get; set; } 

    #endregion

    #region methods

    private static Name NameSplitter(string nameString)
    {
        var name = new Name(nameString)
        {
            FirstName = nameString.Split(" ")[0],
            LastName = nameString.Split(" ")[1..].ToString()
        };
        return name;
    }

    #endregion

    #region overloads

    public static implicit operator string(Name name) => name;

    public static implicit operator Name(string name) => new(name)
    {
        FirstName = name.Split(" ", 0).ToString(),
        LastName = name.Split(" ").ToString()[1..]
    };

    #endregion
}