using LibraryX.Api.SharedContext.Exceptions;

namespace LibraryX.Api.SharedContext.ValueObjects;

public class VerificationCode : ValueObject
{
    # region constructors

    public VerificationCode(string verificationCode)
    {
        if (string.IsNullOrEmpty(verificationCode))
            throw new ArgumentException("The validation code can not be null or empty");

        if (verificationCode != Code)
            throw new InvalidVerificationCodeException();

        if (verificationCode.Length != 8)
            throw new InvalidVerificationCodeException();

        Code = verificationCode;
        HasValue = true;
        Verified = ConfirmVerificationCode(verificationCode);
    }

    # endregion

    # region properties

    public string Code { get; } = Guid.NewGuid().ToString().ToUpper()[..8];
    public DateTime ExpirationDate { get; } = DateTime.UtcNow.AddMinutes(2);
    public bool HasValue { get; }
    public bool Verified { get; }

    # endregion

    # region methods

    private bool  ConfirmVerificationCode(string verificationCode) => 
        verificationCode == Code && DateTime.UtcNow <= ExpirationDate;
    

    # endregion

    # region overloads

    public static implicit operator string(VerificationCode verificationCode) => verificationCode.Code;
    public static implicit operator VerificationCode(string code) => new(code);
    
    # endregion
}