namespace LibraryX.Api.Areas.Author.UseCases.Delete;

public class Request : IRequest
{
    public Guid Id { get; set; }
}