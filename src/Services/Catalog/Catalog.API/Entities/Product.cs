using MongoDB.Bson.Serialization.Attributes; // Using MongoDB as import with different BSON attr
using MongoDB.Bson; // Using MongoDB.Bson to parse JSON

namespace Catalog.API.Entities
{
    public class Product //Creating get:set response for RESTApi
    {
        [BsonId] //Using MongoDB.Bson for parsing JSON files
        [BsonRepresentation(BsonType.ObjectId)] //Using BsonRepresentation to find ObjectiveID from JSON response
        public string Id { get; set; }

        [BsonElement("Name")]

        public string Category { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; }

        public string ImageFile { get; set; }

        public decimal Price { get; set; }
        public string Name { get; internal set; }
    }
}
