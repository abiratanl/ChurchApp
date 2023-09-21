using Church.Contexts.AdmContext.Entities;

namespace Church.Contexts.AdmContext.UseCases.NewsletterUseCases.Modify.Contracts;

public interface IRepository
{
    Task<Newsletter> GetByIdAsync(Guid id);
    Task Update(Newsletter newsletter);
}
