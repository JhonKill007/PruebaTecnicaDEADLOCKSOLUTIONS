using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PruebaTecnica.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int Count { get; set; }
    }
}
