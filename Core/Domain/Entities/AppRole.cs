using Domain.Entities.Common;

namespace Domain.Entities;

public class AppRole: BaseEntity
{
    public string Definition { get; set; } = null!;

    #region Navigation Properties

    public List<AppUser>? AppUsers { get; set; }

    #endregion
}