using System.Collections.Generic;

namespace TenyoTech.MealPreparation.Data.Models
{
    public class Author
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfilePicture { get; set; }

        public ICollection<string> RecipeIds { get; set; }
    }
}