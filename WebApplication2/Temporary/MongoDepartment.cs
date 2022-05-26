using MongoDB.Entities;

namespace WebApplication2.Temporary;

public class MongoDepartment: Entity
{
    public string Name { get; set; }

    public Many<MongoPosition> Positions { get; set; }

    public ICollection<MongoDepartment> Children { get; set; }

    public MongoDepartment()
    {
        this.InitOneToMany(() => Positions);
    }
}