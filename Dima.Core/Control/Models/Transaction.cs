using Dima.Core.Common;
using Dima.Core.Control.Enums;

namespace Dima.Core.Control.Models;

public class Transaction : BaseEntity
{
    public string? Title { get; set; }
    public string? UserId { get; set; }
    public DateTime? PaidOrReceivedAt { get; set; }
    public EtransactionType Type { get; set; } = EtransactionType.Withdraw;
    public decimal Amount { get; set; }
    public long CategoryId { get; set; }
    public Category? Category { get; set; }
}