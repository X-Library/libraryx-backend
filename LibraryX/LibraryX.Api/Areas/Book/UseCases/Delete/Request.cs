namespace LibraryX.Api.Areas.Book.UseCases.Delete;

public class Request : IRequest
{
    public Guid Id { get; set; }
}