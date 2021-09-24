using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using Newtonsoft.Json;

namespace TenyoTech.MealPreparation.Data.Models
{
    public class Product
    {
        [BsonElement("_id")]
        [JsonProperty("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public int Calories { get; set; }

        public int Protein { get; set; }

        public int Carbs { get; set; }

        public int Fat { get; set; }

        public int QuantityInGrams { get; set; }
    }
}