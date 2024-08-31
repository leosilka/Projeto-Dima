using Dima.Core.Common;
using Dima.Core.Control.Enums;
using Dima.Core.Control.Models;

namespace Dima.Core.Control.DTOs.Request;

public class TransactionRequest : BaseDTO
{
    public string? Title { get; set; }
    public int Type { get; set; }
    public decimal Amount { get; set; }
    public long CategoryId { get; set; }
    public Category? Category { get; set; }
}