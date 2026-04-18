using ChurchApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChurchApp.Infrastructure.Persistence.Mappings;

public class MemberConfiguration : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.ToTable("Members");

        builder.HasKey(m => m.Id);

        builder.Property(m => m.FullName)
            .IsRequired()
            .HasMaxLength(150);

        // Configuração do Value Object (Complex Type)
        builder.ComplexProperty(m => m.Address);

        // Relacionamento 1:1 com User
        builder.HasOne(m => m.User)
            .WithOne(u => u.Member)
            .HasForeignKey<User>(u => u.MemberId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}