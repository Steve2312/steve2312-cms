namespace steve2312.Cms.DAL.V2.Models.KeyFields;

public class KeyField
{
    public Guid Id { get; set; }
    public required string Key { get; init; }
    
    public Guid ModelId { get; init; }
    public virtual Model? Model { get; init; }
}