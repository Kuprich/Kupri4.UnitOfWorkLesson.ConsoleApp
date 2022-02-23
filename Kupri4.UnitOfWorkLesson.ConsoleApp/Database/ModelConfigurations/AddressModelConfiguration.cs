using Kupri4.UnitOfWorkLesson.ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kupri4.UnitOfWorkLesson.ConsoleApp.Database.ModelConfigurations;

public class AddressModelConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.IsDefault);
        builder.Property(x => x.Name).HasMaxLength(100);
        builder.Property(x => x.City).HasMaxLength(100);
        builder.Property(x => x.Building).IsRequired();
        builder.Property(x => x.Flat).HasMaxLength(100);
        builder.Property(x => x.Street).HasMaxLength(100);
    }
}