namespace LibraryX.Api.Areas.Book.UseCases.GetAll;

public class Request : IRequest
{
    public int Skip { get; set; } = 0;
    public int Take { get; set; } = 25;
}