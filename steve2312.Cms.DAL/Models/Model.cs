using steve2312.Cms.DAL.Models.KeyFields;

namespace steve2312.Cms.DAL.Models;

public class Model
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    
    public virtual IList<KeyField>? KeyFields { get; set; }
    public virtual IList<Instance>? Instances { get; set; }
}