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
    }

    #endregion

    #region properties

    public string Address { get; }
    public bool Confirmed { get; private set; }
    public VerificationCode VerificationCode { get; }

    // Aqui

    #endregion

    #region methods

    public void ConfirmEmail(VerificationCode code)
    {
        if (code.IsValid)
            Confirmed = true;
    }

    #endregion

    #region overloads

    public static implicit operator string(Email email) => email.Address;
    public static implicit operator Email(string address) => new(address);

    #endregion
}