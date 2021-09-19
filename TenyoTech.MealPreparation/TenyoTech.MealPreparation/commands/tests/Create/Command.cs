using MediatR;

namespace TenyoTech.MealPreparation.commands.tests.Create
{
    public class Command : IRequest<Response>
    {
        public string TestName { get; set; }

        public int TestNumber { get; set; }
    }
}