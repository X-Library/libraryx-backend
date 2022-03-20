namespace LibraryX.Api.LibraryContext.Models;

public class BookModel : Model
{
    public Guid AuthorId { get; set; }
    public AuthorModel Author { get; set; } = new();
    public Guid CategoryId { get; set; }
    public CategoryModel Category { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string ISSN { get; set; } = string.Empty!;
}