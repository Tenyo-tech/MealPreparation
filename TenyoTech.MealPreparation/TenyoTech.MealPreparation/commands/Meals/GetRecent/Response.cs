using System.Collections.Generic;

using TenyoTech.MealPreparation.Data.Models;

namespace TenyoTech.MealPreparation.commands.Meals.GetRecent
{
    public class Response
    {
        public ICollection<Meal> RecentMeals { get; set; }
    }
}