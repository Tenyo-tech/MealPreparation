using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using Newtonsoft.Json;

namespace TenyoTech.MealPreparation.Data.Models
{
    public class Test
    {
        [BsonElement("_id")]
        [JsonProperty("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string TestName { get; set; }

        public int TestNumber { get; set; }
    }
}