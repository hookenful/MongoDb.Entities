using MongoDB.Entities;

namespace WebApplication2.Temporary;

public class MongoUser : Entity
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string? PatronymicName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public bool IsHead { get; set; }
}