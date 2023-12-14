namespace DDDModeler.Models;
public class Entity : BaseModel
{
    public bool IsAggregateRoot { get; set; }
    public List<Property> Properties { get; set; } = new();
    public List<Relationship> Relationships { get; set; } = new();
}
