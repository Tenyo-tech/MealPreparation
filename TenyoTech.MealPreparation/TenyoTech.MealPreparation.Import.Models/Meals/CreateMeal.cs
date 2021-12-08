using System.Collections.Generic;

using TenyoTech.MealPreparation.Data.Models;

namespace TenyoTech.MealPreparation.Import.Models.Meals
{
    public class CreateMeal
    {
        public string AuthorId { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<CreateProduct> Products { get; set; }

        public string Recipe { get; set; }

        public NutritionalComposition NutritionalComposition { get; set; }
    }
}