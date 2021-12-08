using System.Collections.Generic;

using TenyoTech.MealPreparation.Data.Models;

namespace TenyoTech.MealPreparation.ReadDTOs.Models.Meals
{
    public class ReadMeal
    {
        public string AuthorId { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Product> Products { get; set; }

        public string Recipe { get; set; }

        public NutritionalComposition NutritionalComposition { get; set; }
    }
}