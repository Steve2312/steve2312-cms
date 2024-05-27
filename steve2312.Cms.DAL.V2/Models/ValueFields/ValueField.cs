﻿using steve2312.Cms.DAL.V2.Models.KeyFields;

namespace steve2312.Cms.DAL.V2.Models.ValueFields;

public class ValueField
{
    public Guid Id { get; init; }
    
    public Guid EntityId { get; init; }
    public Guid KeyFieldId { get; init; }
    public virtual Entity? Entity { get; init; }
}