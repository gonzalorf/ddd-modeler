namespace DDDModeler.Models;
public class ValueObject : Type
{
    public List<Property> Properties { get; set; } = new();
}
