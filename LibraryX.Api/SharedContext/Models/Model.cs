namespace LibraryX.Api.SharedContext.Models;

public abstract class Model
{
    public Guid Id { get; set; } = Guid.NewGuid();
}