using Dima.Core.Control.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dima.Api.Data.Mappings;

public class TransactionMapping : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable("Transaction");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title).IsRequired().HasColumnType("NVARCHAR").HasMaxLength(80);
        builder.Property(x => x.Type).HasColumnType("SMALLINT");
        builder.Property(x => x.Amount).IsRequired().HasColumnType("MONEY");
        builder.Property(x => x.UserId).IsRequired().HasColumnType("VARCHAR").HasMaxLength(160);
        builder.Property(x => x.PaidOrReceivedAt);
        builder.Property(x => x.CategoryId).IsRequired();
        builder.Property(x => x.Active).IsRequired();
        builder.Property(x => x.CreateAt).IsRequired();
        builder.Property(x => x.UpdateAt).IsRequired();

        builder.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryId);
    }
}
