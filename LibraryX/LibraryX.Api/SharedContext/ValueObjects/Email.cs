using LibraryX.Api.SharedContext.Exceptions;

namespace LibraryX.Api.SharedContext.ValueObjects;

public class Email : ValueObject
{
    #region constructors
    public Email(string emailAddress)
    {
        if (string.IsNullOrEmpty(emailAddress))
            throw new ArgumentNullException("Email can not be null or empty;");

        if (emailAddress.Length > 160)
            throw new InvalidEmailLengthException();
        
        Address = emailAddress;
        Confirmed = false;
        VerificationCode = Guid.NewGuid()
            .ToString()
            .ToUpper()
            [..8];
    }
    #endregion

    #region properties
    public string Address { get; }
    public bool Confirmed { get; private set; }
    public string VerificationCode { get; }
    #endregion

    #region methods
    public void ConfirmEmail(string code = "")
    {
        if(string.IsNullOrEmpty(code))
            throw new ArgumentNullException("Verification code can not be null or empty;");

        if (code != VerificationCode)
            throw new InvalidVerificationCodeException();

        Confirmed = true;
    }
    #endregion

    #region overloads
    public static implicit operator string(Email email) => email.Address;
    public static implicit operator Email(string address) => new(address);
    #endregion
}