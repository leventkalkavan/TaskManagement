using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class NotificationConfiguration: IEntityTypeConfiguration<Notification>
{
    public void Configure(EntityTypeBuilder<Notification> builder)
    {
        builder.Property(x => x.Description).IsRequired(true);
        builder.Property(x => x.Description).HasMaxLength(500);

        builder.Property(x => x.State).IsRequired(true);
        
        builder.Property(x => x.AppUserId).IsRequired(true);
    }
}