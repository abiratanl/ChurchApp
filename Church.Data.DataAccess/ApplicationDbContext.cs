using Church.Contexts.AdmContext.Entities;
using Church.Data.DataAccess.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Church.Data.DataAccess;

public class ApplicationDbContext : DbContext
{
    #region Contructors

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    #endregion

    #region AdmContext

    public DbSet<Newsletter> Newsletters { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder builder)
    {
        #region AdmContext

        builder.ApplyConfiguration(new NewsletterMap());

    #endregion
    }
}
