namespace Dima.Core.Common;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreateAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdateAt { get; set; } = DateTime.UtcNow;

    public void SetUpdated()
    {
        UpdateAt = DateTime.UtcNow;
    }
}