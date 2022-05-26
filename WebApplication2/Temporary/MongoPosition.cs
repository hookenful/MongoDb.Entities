using MongoDB.Entities;

namespace WebApplication2.Temporary;

public class MongoPosition : Entity
{
    public Guid PositionId { get; set; }
    public string Name { get; set; }

    public Many<MongoUser> Users { get; set; }

    public MongoPosition()
    {
        this.InitOneToMany(() => Users);
    }
}