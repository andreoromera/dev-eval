using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.Property(u => u.Username).IsRequired().HasMaxLength(50);
        builder.Property(u => u.Password).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Phone).HasMaxLength(20);

        builder.Property(u => u.Status)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(u => u.Role)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.HasData(
            new User
            {
                Id = new Guid("C205ACDA-F799-4620-AF11-2D0D31C4CC61"),
                Username = "John",
                Email = "john@ambev.com.br",
                Password = "$2a$11$98uK.e4T65eZLbZoM1m4UeTvWdq3Cv1Yb7GA.VfaNkq2RAreOTIxy",
                Phone = "11984151122",
                Role = UserRole.Admin,
                Status = UserStatus.Active,
                CreatedAt = new DateTime(2025, 2, 9, 13, 17, 8, 105, DateTimeKind.Utc)
            },
            new User
            {
                Id = new Guid("BD43D49A-1246-4368-8EC1-03508D2C9BF1"),
                Username = "Mary",
                Email = "mary@ambev.com.br",
                Password = "$2a$11$bSfY6FmnKx4QxnTOw9DHz.864wBSBWAAq.eeojS.c6POYGtp8iTWS",
                Phone = "11984153344",
                Role = UserRole.Admin,
                Status = UserStatus.Active,
                CreatedAt = new DateTime(2025, 2, 9, 13, 17, 8, 105, DateTimeKind.Utc)
            },
            new User
            {
                Id = new Guid("A13304D6-3748-4720-B1CF-149C4092FDC0"),
                Username = "Jane",
                Email = "jane@ambev.com.br",
                Password = "$2a$11$A.3yd/ekyeIV8KrrZrJ7KuXBpnmwFlFDA85WZLRM076hZPrM.G6zC",
                Phone = "11984155566",
                Role = UserRole.Customer,
                Status = UserStatus.Active,
                CreatedAt = new DateTime(2025, 2, 9, 13, 17, 8, 105, DateTimeKind.Utc)
            }
        );
    }
}
