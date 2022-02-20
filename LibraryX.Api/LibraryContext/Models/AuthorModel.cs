namespace LibraryX.Api.LibraryContext.Models;

public class AuthorModel : Model
{
    public string Name { get; set; } = string.Empty!;
    public string LastName { get; set; } = string.Empty!;
    public string Nationality { get; set; } = string.Empty!;
    public string Email { get; set; } = string.Empty!;
}