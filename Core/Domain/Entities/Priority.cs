using Domain.Entities.Common;

namespace Domain.Entities;

public class Priority: BaseEntity
{
    public string Definition { get; set; } = null!;

    #region Navigation Properties

    public List<AppTask>? AppTasks { get; set; }

    #endregion
}