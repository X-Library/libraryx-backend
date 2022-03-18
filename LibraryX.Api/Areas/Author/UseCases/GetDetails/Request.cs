namespace LibraryX.Api.Areas.Author.UseCases.GetDetails;

public class Request : IRequest
{
    public Guid  Id { get; set; }
}