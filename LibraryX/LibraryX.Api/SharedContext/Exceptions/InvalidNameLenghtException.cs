namespace LibraryX.Api.SharedContext.Exceptions;

public class InvalidNameLengthException : Exception
{
    public InvalidNameLengthException() : base("Name length can not be greater than 160 characteres.")
    {
    }
}