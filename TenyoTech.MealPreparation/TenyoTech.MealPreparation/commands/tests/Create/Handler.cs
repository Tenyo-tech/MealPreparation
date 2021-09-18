using MediatR;

using MongoDB.Driver;

using System.Threading;
using System.Threading.Tasks;

using TenyoTech.MealPreparation.Data.Models;

namespace TenyoTech.MealPreparation.commands.tests.Create
{
    public class Handler : IRequestHandler<Command, Response>
    {
        private IMongoCollection<Test> testMongoCollection;

        public Handler(IMongoClient mongoClient)
        {
            var dataBase = mongoClient.GetDatabase("TenyoTech");
            testMongoCollection = dataBase.GetCollection<Test>("Tests");
        }

        public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
        {
            var test = new Test()
            {
                TestName = request.TestName,
                TestNumber = request.TestNumber
            };

            await testMongoCollection.InsertOneAsync(test);

            return new Response() { Test = test };
        }
    }
}