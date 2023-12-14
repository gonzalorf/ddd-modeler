namespace DDDModeler.Models;
public class BoundedContext : BaseModel
{
    public List<Entity> Entities { get; set; } = new();
}
