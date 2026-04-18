using ChurchApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AssetCategoryConfiguration : IEntityTypeConfiguration<AssetCategory>
{
    public void Configure(EntityTypeBuilder<AssetCategory> builder)
    {
        builder.ToTable("AssetCategories");
        builder.HasKey(ac => ac.Id);
        
        builder.Property(ac => ac.Name).IsRequired().HasMaxLength(50);
        builder.Property(ac => ac.Description).HasMaxLength(200);
    }
}