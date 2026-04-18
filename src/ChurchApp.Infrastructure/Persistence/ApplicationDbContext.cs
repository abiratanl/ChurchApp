using ChurchApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChurchApp.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) { }

    public DbSet<Member> Members { get; set; }
    public DbSet<Congregation> Congregations { get; set; }
    public DbSet<Asset> Assets { get; set; }
    public DbSet<AssetCategory> AssetCategories { get; set; }
    public DbSet<MonthlyBulletinEvent> MonthlyBulletinEvents { get; set; }
    public DbSet<BoardHistory> BoardHistories { get; set; }
    public DbSet<CongregationLeaderHistory> CongregationLeaderHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Esta linha varre o assembly atual e aplica todas as configurações automaticamente
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}