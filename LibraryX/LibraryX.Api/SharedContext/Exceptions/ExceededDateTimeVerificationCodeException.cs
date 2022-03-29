namespace LibraryX.Api.SharedContext.Exceptions;

public class ExceededDateTimeVerificationCodeException : Exception
{
    public ExceededDateTimeVerificationCodeException() : base("You must confirm your e-mail until two minutes after requesting it.")
    {
    }
}