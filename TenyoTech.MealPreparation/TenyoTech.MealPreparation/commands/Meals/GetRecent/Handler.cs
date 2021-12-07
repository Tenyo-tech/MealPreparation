namespace TenyoTech.MealPreparation.commands.Meals.GetRecent
{
    public class Handler //: IRequestHandler<Command, Response>
    {
        //    private IMongoCollection<Meal> mealsMongoCollection;

        //    public Handler(IMongoClient mongoClient)
        //    {
        //        var dataBase = mongoClient.GetDatabase("TenyoTech");
        //        mealsMongoCollection = dataBase.GetCollection<Meal>("Meals");
        //    }

        //    public Task<Response> Handle(Command request, CancellationToken cancellationToken)
        //    {
        //        var filter = Builders<Meal>.Filter.Eq();

        //        var meal = await mealsMongoCollection.Aggregate()
        //                .Match(filter)
        //                .FirstOrDefaultAsync(cancellationToken);

        //        return new Response() { Meal = meal };
        //    }
        //}
    }
}