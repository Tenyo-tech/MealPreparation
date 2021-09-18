using MediatR;

using MongoDB.Driver;

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using TenyoTech.MealPreparation.Data.Models;

namespace TenyoTech.MealPreparation.commands.tests.Get
{
    public class Handler : IRequestHandler<Command, Response>
    {
        private IMongoCollection<Test> testMongoCollection;

        public Handler(IMongoClient mongoClient)
        {
            var dataBase = mongoClient.GetDatabase("TenyoTech");
            testMongoCollection = dataBase.GetCollection<Test>("Tests");
        }

        public Response Handle(Command request, CancellationToken cancellationToken)
        {
            var test = testMongoCollection.Find(x => x.TestName == "Test").ToList().FirstOrDefault();

            return new Response() { Test = test };
        }

        Task<Response> IRequestHandler<Command, Response>.Handle(Command request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}