namespace LibraryX.Api.Areas.Book.UseCases.GetDetails;

public class Request : IRequest
{
    public Guid Id { get; set; }
}