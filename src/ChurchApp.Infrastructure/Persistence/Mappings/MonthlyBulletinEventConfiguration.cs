using ChurchApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MonthlyBulletinEventConfiguration : IEntityTypeConfiguration<MonthlyBulletinEvent>
{
    public void Configure(EntityTypeBuilder<MonthlyBulletinEvent> builder)
    {
        builder.ToTable("MonthlyBulletinEvents");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Day).IsRequired().HasMaxLength(20);
        builder.Property(e => e.Time).IsRequired().HasMaxLength(50);
        builder.Property(e => e.EventDescription).IsRequired().HasMaxLength(500);

        builder.Ignore(e => e.FinalLocation);
    }
}