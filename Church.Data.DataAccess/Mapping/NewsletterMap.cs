using Church.Contexts.AdmContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Church.Data.DataAccess.Mapping;

public class NewsletterMap : IEntityTypeConfiguration<Newsletter>
{ 
    public void Configure(EntityTypeBuilder<Newsletter> builder)
    {
        #region Identifiers

        builder.ToTable(nameof(Newsletter));
        builder.HasKey(n => n.Id);

        #endregion

        #region Properties

        builder.Property(n => n.EndDate)
            .IsRequired()
            .HasColumnType("SMALLDATETIME");
        builder.Property(n => n.EventDescription)
            .IsRequired()
            .HasColumnType("NVARCHAR")
            .HasMaxLength(180);
        builder.Property(n => n.EventTime)
            .IsRequired()
            .HasColumnType("SMALLDATETIME");
        builder.Property(n => n.IsDeleted)
            .IsRequired()
            .HasColumnType("BIT");
        builder.Property(n => n.StartDate)
            .IsRequired()
            .HasColumnType("SMALLDATETIME");

        #endregion


    }
}
