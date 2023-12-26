using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class TaskReportConfiguration: IEntityTypeConfiguration<TaskReport>
{
    public void Configure(EntityTypeBuilder<TaskReport> builder)
    {
        builder.Property(x => x.Detail).IsRequired(true);

        builder.Property(x => x.Definition).IsRequired(true);
        builder.Property(x => x.Definition).HasMaxLength(250);

        builder.Property(x => x.AppTaskId).IsRequired(true);
    }
}