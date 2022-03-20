namespace LibraryX.Api.SharedContext.Exceptions;

public class InvalidVerificationCodeException : Exception
{
    public InvalidVerificationCodeException() : base("Verification code is invalid.")
    {
    }
}