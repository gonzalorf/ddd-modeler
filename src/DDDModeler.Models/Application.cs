namespace DDDModeler.Models;
public class Application : BaseModel
{
    public List<Entity> Entities { get; set; } = new();
    public List<ValueObject> ValueObjects { get; set; } = new();
    public List<BoundedContext> BoundedContexts { get; set; } = new();
    public List<Repository> Repositories { get; set; } = new();
    public List<Service> Services { get; set; } = new();
    public List<Event> Events { get; set; } = new();
}
