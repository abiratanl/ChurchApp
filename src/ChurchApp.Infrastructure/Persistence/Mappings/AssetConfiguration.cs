using ChurchApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AssetConfiguration : IEntityTypeConfiguration<Asset>
{
    public void Configure(EntityTypeBuilder<Asset> builder)
    {
        builder.ToTable("Assets");
        builder.HasKey(a => a.Id);

        // Regra da Plaqueta Única
        builder.HasIndex(a => a.TagNumber).IsUnique();
        builder.Property(a => a.TagNumber).IsRequired().HasMaxLength(20);
        
        builder.Property(a => a.Description).IsRequired().HasMaxLength(200);
        builder.Property(a => a.PurchaseValue).HasPrecision(18, 2);

        // Relacionamentos
        builder.HasOne(a => a.Category)
            .WithMany(ac => ac.Assets)
            .HasForeignKey(a => a.CategoryId);

        builder.HasOne(a => a.ResponsibleMember)
            .WithMany()
            .HasForeignKey(a => a.ResponsibleMemberId)
            .OnDelete(DeleteBehavior.SetNull);
            
        // Ignorar propriedades calculadas no banco (o cálculo é feito no C#)
        builder.Ignore(a => a.AccumulatedDepreciation);
        builder.Ignore(a => a.CurrentNetValue);
    }
}