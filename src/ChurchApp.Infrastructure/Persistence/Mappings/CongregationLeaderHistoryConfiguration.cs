using ChurchApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChurchApp.Infrastructure.Persistence.Mappings;

public class CongregationLeaderHistoryConfiguration : IEntityTypeConfiguration<CongregationLeaderHistory>
{
    public void Configure(EntityTypeBuilder<CongregationLeaderHistory> builder)
    {
        builder.ToTable("CongregationLeaderHistories");
        builder.HasKey(clh => clh.Id);

        builder.HasOne(clh => clh.Congregation)
            .WithMany(c => c.LeaderHistories)
            .HasForeignKey(clh => clh.CongregationId);
            
        builder.HasOne(clh => clh.Member)
            .WithMany()
            .HasForeignKey(clh => clh.MemberId);
    }
}