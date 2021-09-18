using AutoMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using System.Threading;
using System.Threading.Tasks;

using TenyoTech.MealPreparation.Import.Models.tests;
using TenyoTech.MealPreparation.ReadDTOs.Models.tests;

namespace TenyoTech.MealPreparation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestsController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public TestsController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<Read>> CreateTest(Create create, CancellationToken cancellationToken)
        {
            var command = mapper.Map<commands.tests.Create.Command>(create);

            var result = await mediator.Send(command, cancellationToken);

            var response = mapper.Map<Read>(result.Test);

            return response;
        }

        [HttpGet]
        public async Task<ActionResult<Read>> GetTest(Create create, CancellationToken cancellationToken)
        {
            var command = mapper.Map<commands.tests.Create.Command>(create);

            var result = await mediator.Send(command, cancellationToken);

            var response = mapper.Map<Read>(result.Test);

            return response;
        }
    }
}