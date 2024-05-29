﻿namespace steve2312.Cms.DAL.V2.Models;

public class Model
{
    public Guid Id { get; init; }
    public required string Name { get; init; }

    public virtual ICollection<KeyField<string>> StringKeyFields { get; init; } = new List<KeyField<string>>();
    public virtual ICollection<KeyField<int>> IntegerKeyFields { get; init; } = new List<KeyField<int>>();
    public virtual ICollection<Entity> Entities { get; init; } = null!;
}