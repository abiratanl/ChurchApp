using ChurchApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class BoardHistoryConfiguration : IEntityTypeConfiguration<BoardHistory>
{
    public void Configure(EntityTypeBuilder<BoardHistory> builder)
    {
        builder.ToTable("BoardHistories");
        builder.HasKey(bh => bh.Id);
        
        builder.HasOne(bh => bh.Member)
            .WithMany()
            .HasForeignKey(bh => bh.MemberId);
    }
}

