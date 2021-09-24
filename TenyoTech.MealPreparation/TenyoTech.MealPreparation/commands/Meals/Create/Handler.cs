using MediatR;

using MongoDB.Driver;

using System.Threading;
using System.Threading.Tasks;

using TenyoTech.MealPreparation.Data.Models;

namespace TenyoTech.MealPreparation.commands.Meals.Create
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
            var meal = new Meal()
            {
                Author = request.Author,
                Title = request.Title,
                Products = request.Products,
                Recipe = request.Recipe,
                NutritionalComposition = request.NutritionalComposition
            };

            await mealsMongoCollection.InsertOneAsync(meal);

            return new Response() { Meal = meal };
        }
    }
}