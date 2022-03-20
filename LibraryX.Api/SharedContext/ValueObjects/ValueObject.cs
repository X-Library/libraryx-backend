namespace LibraryX.Api.SharedContext.ValueObjects;

public abstract class ValueObject
{
    public ValueObject() => Id = Guid.NewGuid();
    public Guid Id { get; }
}