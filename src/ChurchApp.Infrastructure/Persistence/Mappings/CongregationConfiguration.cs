using ChurchApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChurchApp.Infrastructure.Persistence.Mappings;

public class CongregationConfiguration : IEntityTypeConfiguration<Congregation>
{
    public void Configure(EntityTypeBuilder<Congregation> builder)
    {
        builder.ToTable("Congregations");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        
        // Configuração do Value Object de Endereço
        builder.ComplexProperty(c => c.Address);

        // Relacionamento com Membros (1:N)
        builder.HasMany(c => c.Members)
            .WithOne(m => m.Congregation)
            .HasForeignKey(m => m.CongregationId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}