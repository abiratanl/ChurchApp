using ChurchApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChurchApp.Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
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

        // Configuração do Address como Complex Type (Disponível no .NET 10)
        builder.Entity<Member>().ComplexProperty(m => m.Address);
        builder.Entity<Congregation>().ComplexProperty(c => c.Address);

        // Configuração da relação 1:1 entre Member e User
        builder.Entity<Member>()
            .HasOne(m => m.User)
            .WithOne(u => u.Member)
            .HasForeignKey<User>(u => u.MemberId)
            .OnDelete(DeleteBehavior.Cascade);

        // Garantir que a plaqueta do patrimônio seja única
        builder.Entity<Asset>()
            .HasIndex(a => a.TagNumber)
            .IsUnique();
    }
}