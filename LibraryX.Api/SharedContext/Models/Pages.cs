namespace LibraryX.Api.SharedContext.Models
{
    public class Pages : IRequest
    {
          public int Skip { get; set; } = 0;
          public int Take { get; set; } = 25;
    }
}