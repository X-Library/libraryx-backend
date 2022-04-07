using LibraryX.Api.SharedContext.ValueObjects;

namespace LibraryX.Api.LibraryContext.Models;

public class AuthorModel : Model
{
    public Name Name { get; set; } = string.Empty;
    public string Nationality { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}