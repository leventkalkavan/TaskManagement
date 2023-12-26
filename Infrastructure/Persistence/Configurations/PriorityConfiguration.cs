using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class PriorityConfiguration: IEntityTypeConfiguration<Priority>
{
    public void Configure(EntityTypeBuilder<Priority> builder)
    {
        builder.Property(x => x.Definition).IsRequired(true);
        builder.Property(x => x.Definition).HasMaxLength(250);

        builder.HasMany(x => x.AppTasks).WithOne(x => x.Priority).HasForeignKey(x => x.PriorityId);
    }
}