using Domain.Entities.Common;

namespace Domain.Entities;

public class AppUser : BaseEntity
{
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public int AppRoleId { get; set; }

    #region Navigation Properties

    public AppRole? AppRole { get; set; }
    public AppTask? AppTask { get; set; }
    public List<Notification>? Notifications{ get; set; }
    #endregion
}