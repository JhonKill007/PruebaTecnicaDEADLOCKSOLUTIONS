using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PruebaTecnica.Entities
{
    public class Client
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
