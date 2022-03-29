using LibraryX.Api.SharedContext.Exceptions;

namespace LibraryX.Api.SharedContext.ValueObjects;

public class VerificationCode : ValueObject
{
    # region constructors


    public VerificationCode()
    {
        if (string.IsNullOrEmpty(Code))
            throw new ArgumentNullException("The verification code can not be null or empty");

        if (Code.Length != 8)
            throw new InvalidVerificationCodeException();

        HasValue = false;
        Verified = false;
    }
    
    # endregion

    # region properties
    
    public string Code { get;  set; } = Guid.NewGuid().ToString()[..8].ToUpper();
    public DateTime ExpirationDate { get; set; } = DateTime.UtcNow.Date.AddMinutes(2);
    public bool HasValue { get; set; }
    public bool Verified { get; set; } 

    # endregion

    # region methods
    
    public void ConfirmVerificationCodeValidValueExpirationDate(VerificationCode verificationCode)
    {
        if (Code != verificationCode.Code) throw new InvalidVerificationCodeException();
        verificationCode.HasValue = true;

        if (DateTime.UtcNow.Date > ExpirationDate ) throw new ExceededDateTimeVerificationCodeException();
        Verified = true;
    }


    # endregion

    # region overloads

    public static implicit operator string?(VerificationCode verificationCode) => verificationCode.Code;

    public static implicit operator VerificationCode(string verificationCodeString)
    {
        VerificationCode verificationCode = new(){Code = verificationCodeString};
        return verificationCode;
    }
    
    # endregion
}