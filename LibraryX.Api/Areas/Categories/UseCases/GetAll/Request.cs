namespace LibraryX.Api.Areas.Categories.UseCases.GetAll;

public class Request : IRequest
{
    public int Skip { get; set; } = 0;
    public int Take { get; set; } = 25;
}