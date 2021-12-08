using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace TenyoTech.MealPreparation.Data.Models
{
    public class Meal
    {
        [BsonElement("_id")]
        [JsonProperty("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string AuthorId { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Product> Products { get; set; }

        public string Recipe { get; set; }

        public NutritionalComposition NutritionalComposition { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}