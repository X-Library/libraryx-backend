namespace LibraryX.Api.SharedContext.Exceptions;

public class InvalidEmailLengthException : Exception
{
    public InvalidEmailLengthException() : base("Email length can not be greater than 160 characteres.")
    {
    }
}