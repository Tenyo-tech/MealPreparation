using MediatR;

namespace TenyoTech.MealPreparation.commands.Meals.Get
{
    public class Command : IRequest<Response>
    {
        public string Id { get; set; }
    }
}