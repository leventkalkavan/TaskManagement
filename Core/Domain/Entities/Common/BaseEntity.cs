namespace Domain.Entities.Common;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public bool Status { get; set; } = true;
    public DateTime UpdatedDate { get; set; }
}