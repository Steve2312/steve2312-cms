using steve2312.Cms.DAL.V1.Models.ValueFields;

namespace steve2312.Cms.DAL.V1.Models;

public class Instance
{
    public Guid Id { get; set; }
    public DateTime Created { get; } = DateTime.Now;
    public DateTime Modified { get; } = DateTime.Now;
    
    public virtual Model? Model { get; set; }
    public virtual IList<ValueField>? ValueFields { get; set; }
}