using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;

namespace Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
        modelBuilder.ApplyConfiguration(new AppTaskConfiguration());
        modelBuilder.ApplyConfiguration(new AppUserConfiguration());
        modelBuilder.ApplyConfiguration(new NotificationConfiguration());
        modelBuilder.ApplyConfiguration(new PriorityConfiguration());
        modelBuilder.ApplyConfiguration(new TaskReportConfiguration());
    }

    public DbSet<AppRole> AppRoles { get; set; }
    public DbSet<AppTask> AppTasks { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Priority> Priorities { get; set; }
    public DbSet<TaskReport> TaskReports { get; set; }
}