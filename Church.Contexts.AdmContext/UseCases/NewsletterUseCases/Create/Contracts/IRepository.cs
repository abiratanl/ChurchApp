using Church.Contexts.AdmContext.Entities;

namespace Church.Contexts.AdmContext.UseCases.NewsletterUseCases.Create.Contracts;

public interface IRepository
{
    /// <summary>
    /// Asynchronous Create a new event.
    /// </summary>
    /// <param name="newsletter">Required a newsletter instance</param>
    /// <returns></returns>
    Task CreateAsync(Newsletter? newsletter);
}
