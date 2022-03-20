namespace LibraryX.Api.Areas.Authors.UseCases.Delete;

public class Request : IRequest
{
    public Guid Id { get; set; }
}