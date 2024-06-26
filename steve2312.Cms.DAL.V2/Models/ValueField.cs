﻿namespace steve2312.Cms.DAL.V2.Models;

public class ValueField
{
    public Guid Id { get; init; }
    public Guid EntityId { get; init; }
    public Guid KeyFieldId { get; init; }

    public virtual Entity Entity { get; init; } = null!;
}

public class ValueField<T> : ValueField
{
    public required T Value { get; init; }

    public virtual KeyField<T> KeyField { get; init; } = null!;
}