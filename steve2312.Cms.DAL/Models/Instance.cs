using steve2312.Cms.DAL.Models.ValueFields;

namespace steve2312.Cms.DAL.Models;

public class Instance
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Modified { get; set; } = DateTime.Now;
    
    public virtual Model? Model { get; set; }
    public virtual IList<ValueField>? ValueFields { get; set; }
}