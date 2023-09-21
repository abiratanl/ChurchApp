using Church.Contexts.SharedContext.ValueObjects;

namespace Church.Contexts.SharedContext.UseCases.Contracts;

public interface IResponse
{
    public IReadOnlyCollection<Error>? Errors { get; }
    public int StatusCode { get; }
    public bool IsSuccess { get; }
}
