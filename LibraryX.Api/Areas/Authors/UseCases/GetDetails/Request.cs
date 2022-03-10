namespace LibraryX.Api.Areas.Authors.UseCases.GetDetails;

public class Request : IRequest
{
    public Guid Id { get; set; }
}