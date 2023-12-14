namespace DDDModeler.Models;
public class Relationship : BaseModel
{
    public Entity ToEntity { get; set; }
    public RelationshipType Type { get; set; }
    public bool AllowBidirectional { get; set; }
}
