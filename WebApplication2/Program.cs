using MongoDB.Driver;
using MongoDB.Entities;
using WebApplication2.Temporary;

var builder = WebApplication.CreateBuilder(args);


await DB.InitAsync("Structure",
    MongoClientSettings.FromConnectionString(
        builder.Configuration.GetConnectionString("Mongo")));



var app = builder.Build();

app.MapGet("/", () => "Hello World!");


var userId = Guid.NewGuid();

var mongoTemp = new MongoManualTemp
{
    UserId = userId,
    Status = ManualImportStatus.Started
};
        
await mongoTemp.SaveAsync();

var newDepartment = new MongoDepartment
{
    Name = "Test"
};

await newDepartment.SaveAsync();

var existManualTemp = await DB
    .Find<MongoManualTemp>()
    .Match(c => c.UserId == userId)
    .ExecuteFirstAsync();
        
await existManualTemp.Departments.AddAsync(newDepartment);
        
await existManualTemp.SaveAsync();

app.Run();