using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class AppRoleConfiguration: IEntityTypeConfiguration<AppRole>
{
    public void Configure(EntityTypeBuilder<AppRole> builder)
    {
        builder.Property(x => x.Definition).IsRequired(true);
        builder.Property(x => x.Definition).HasMaxLength(100);

        builder.HasMany(x => x.AppUsers).WithOne(x => x.AppRole).
            HasForeignKey(x => x.AppRoleId);
        
    }
}