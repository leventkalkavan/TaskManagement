using Domain.Entities.Common;

namespace Domain.Entities;

public class AppTask: BaseEntity
{
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public int AppUserId { get; set; }
    public int PriorityId { get; set; }

    #region Navigation Properties

    public AppUser? AppUser { get; set; }
    public Priority? Priority { get; set; }
    public List<TaskReport>? TaskReports { get; set; }
    
    #endregion
}