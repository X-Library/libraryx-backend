using LibraryX.Api.SharedContext.Exceptions;

namespace LibraryX.Api.SharedContext.ValueObjects;

public class VerificationCode : ValueObject
{
    # region constructors

    public VerificationCode(string verificationCode)
    {
        if (string.IsNullOrEmpty(verificationCode))
            throw new ArgumentException("The validation code can not be null or empty");

        if (verificationCode != Code.ToString()[..8].ToUpper())
            throw new InvalidVerificationCodeException();

        if (verificationCode.Length != 8)
            throw new InvalidVerificationCodeException();

        if (verificationCode.Length == 8)
            HasValue = true;

        if (verificationCode == Code.ToString()[..8].ToUpper() && DateTime.UtcNow <= ExpirationDate)
            IsValid = true;
    }

    # endregion

    # region properties

    public Guid Code { get; private set; }
    public DateTime ExpirationDate { get; set; } = DateTime.UtcNow.AddMinutes(2);
    public bool HasValue { get; set; }
    public bool IsValid { get; set; }

    # endregion

    # region methods

    # endregion

    # region overloads

    # endregion
}