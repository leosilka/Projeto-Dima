using Dima.Core.Common;

namespace Dima.Core.Control.Models;

public class Category : BaseEntity
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public string UserId { get; set; }
}