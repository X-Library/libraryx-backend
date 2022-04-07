namespace LibraryX.Api.SharedContext.ValueObjects;

public class Name : ValueObject
{
    #region constructors

    public Name()
    {
    }
    
    public Name(string firstName, string lastName)
    {
        if (string.IsNullOrEmpty(FirstName) | string.IsNullOrEmpty(LastName)) 
            throw new ArgumentNullException("This field can not be null or empty;");

        if (FirstName.Length < 2 | LastName.Length < 2 | FirstName.Length > 80 | LastName.Length > 80)
            throw new ArgumentNullException("This field must have between 2 and 80 characters");

        FirstName = firstName;
        LastName = lastName;
    }

    #endregion

    #region properties

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    #endregion

    #region methods

    public string NameSpliter(string nameString)
    {
        var name = new Name
        {
            FirstName = nameString.Split(" ")[0],
            LastName = nameString.Split(" ")[1..].ToString()
        };
        return name;
    }

    #endregion

    #region overloads

    public static implicit operator string(Name name) => name;

    public static implicit operator Name(string name) => new()
    {
        FirstName = name.Split(" ", 0).ToString(),
        LastName = name.Split(" ").ToString()[1..]
    };

    #endregion
}