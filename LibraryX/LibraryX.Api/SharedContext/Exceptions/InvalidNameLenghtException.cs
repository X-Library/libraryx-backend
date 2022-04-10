namespace LibraryX.Api.SharedContext.Exceptions;

public class InvalidNameLengthException : Exception
{
    public InvalidNameLengthException(string message) : base("Name length can not be greater than 160 characteres.")
    {
        Message = message;
    }

    public string Message { get; set; } 
}