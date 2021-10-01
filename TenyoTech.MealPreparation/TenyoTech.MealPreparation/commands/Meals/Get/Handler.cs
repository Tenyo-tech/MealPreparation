using MediatR;

using MongoDB.Driver;

using System.Threading;
using System.Threading.Tasks;

using TenyoTech.MealPreparation.Data.Models;

namespace TenyoTech.MealPreparation.commands.Meals.Get
{
    public class Handler : IRequestHandler<Command, Response>
    {
        private IMongoCollection<Meal> mealsMongoCollection;

        public Handler(IMongoClient mongoClient)
        {
            var dataBase = mongoClient.GetDatabase("TenyoTech");
            mealsMongoCollection = dataBase.GetCollection<Meal>("Meals");
        }

        public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
        {
            var filter = Builders<Meal>.Filter.Eq(x => x.Id, request.Id);

            var meal = await mealsMongoCollection.Aggregate()
                    .Match(filter)
                    .FirstOrDefaultAsync(cancellationToken);
            return new Response() { Meal = meal };
        }
    }
}