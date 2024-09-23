using Microsoft.Azure.Cosmos;
using System.Collections.Generic;
using System.Threading.Tasks;
using RecommendationAPI.Model;
using User = RecommendationAPI.Model.User;

namespace RecommendationAPI.Services
{
    public class CosmosDbService
    {
        private readonly Container _container;

        public CosmosDbService(CosmosClient cosmosClient, string databaseName, string containerName)
        {
            _container = cosmosClient.GetContainer(databaseName, containerName);
        }

        // Fetch all users from Cosmos DB
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            var query = "SELECT * FROM c";
            var iterator = _container.GetItemQueryIterator<User>(new QueryDefinition(query));
            List<User> results = new List<User>();

            while (iterator.HasMoreResults)
            {
                var response = await iterator.ReadNextAsync();
                results.AddRange(response);
            }

            return results;
        }
    }
}