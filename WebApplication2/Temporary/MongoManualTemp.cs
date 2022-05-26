using MongoDB.Entities;

namespace WebApplication2.Temporary;

public class MongoManualTemp: Entity
{
    public Guid  UserId { get; set; }
    public ManualImportStatus Status { get; set; }

    public Many<MongoDepartment> Departments { get; set; }

    public MongoManualTemp()
    {
        this.InitOneToMany(() => Departments);
    }
}

public enum ManualImportStatus
{
    Started,
    Finished
}