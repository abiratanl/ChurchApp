using Church.Contexts.AdmContext.Entities;

namespace Church.Contexts.AdmContext.UseCases.NewsletterUseCases.Get.Contracts;

public interface IRepository
{
    Task<Newsletter> GetByIdAsync(Guid id);
    Task<Newsletter> GetAllAsync(DateTime startDate, DateTime endDate);
}
