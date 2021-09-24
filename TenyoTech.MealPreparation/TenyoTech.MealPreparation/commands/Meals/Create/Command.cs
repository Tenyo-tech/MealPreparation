using MediatR;

using System.Collections.Generic;

using TenyoTech.MealPreparation.Data.Models;

namespace TenyoTech.MealPreparation.commands.Meals.Create
{
    public class Command : IRequest<Response>
    {
        public string Id { get; set; }

        public Author Author { get; set; }

        public string Title { get; set; }

        public ICollection<Product> Products { get; set; }

        public string Recipe { get; set; }

        public NutritionalComposition NutritionalComposition { get; set; }
    }
}