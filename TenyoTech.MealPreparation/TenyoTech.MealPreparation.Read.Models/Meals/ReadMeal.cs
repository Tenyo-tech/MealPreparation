using System.Collections.Generic;

using TenyoTech.MealPreparation.Data.Models;

namespace TenyoTech.MealPreparation.ReadDTOs.Models.Meals
{
    public class ReadMeal
    {
        public string Id { get; set; }

        public Author Author { get; set; }

        public string Title { get; set; }

        public ICollection<Product> Products { get; set; }

        public string Recipe { get; set; }

        public NutritionalComposition NutritionalComposition { get; set; }
    }
}