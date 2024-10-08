﻿namespace Dima.Core.Common;

public abstract class BaseDTO
{
    public long Id { get; set; }
    public bool Active { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
}
