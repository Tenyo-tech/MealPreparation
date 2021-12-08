using MediatR;

using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using TenyoTech.MealPreparation.Data.Models;

namespace TenyoTech.MealPreparation.commands.Meals.GetRecent
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
            //var filter = Builders<Meal>.Filter.Eq();

            Expression<Func<Meal, bool>> expression = t => true;

            var options = new FindOptions<Meal, BsonDocument>()
            {
                Limit = 5,
                Skip = 0,
                Sort = null
            };

            var result = await mealsMongoCollection.FindAsync(expression, options, CancellationToken.None);
            var recentMeals = (await result.ToListAsync(CancellationToken.None)).Select(x => (Meal)BsonSerializer.Deserialize(x, typeof(Meal))).ToList();

            //var meal = await mealsMongoCollection.Aggregate()
            //        .Match(filter)
            //        .FirstOrDefaultAsync(cancellationToken);

            return new Response() { RecentMeals = recentMeals };
        }
    }
}