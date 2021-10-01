using AutoMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using System.Threading;
using System.Threading.Tasks;

using TenyoTech.MealPreparation.Import.Models.Meals;
using TenyoTech.MealPreparation.ReadDTOs.Models.Meals;

namespace TenyoTech.MealPreparation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MealsController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public MealsController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<ReadMeal>> CreateMeal(CreateMeal create, CancellationToken cancellationToken)
        {
            var command = mapper.Map<commands.Meals.Create.Command>(create);

            var result = await mediator.Send(command, cancellationToken);

            var response = mapper.Map<ReadMeal>(result.Meal);

            return response;
        }

        [HttpGet]
        public async Task<ActionResult<ReadMeal>> GetMeal(string id, CancellationToken cancellationToken)
        {
            var command = new commands.Meals.Create.Command { Id = id };

            var result = await mediator.Send(command, cancellationToken);

            var response = mapper.Map<ReadMeal>(result.Meal);

            return response;
        }
    }
}