using Microsoft.AspNetCore.Mvc;
using RecommendationAPI.Services;
using RecommendationAPI.Model;

namespace RecommendationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly CosmosDbService _cosmosDbService;

        public UserController(CosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }

        // GET: api/user
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _cosmosDbService.GetUsersAsync();
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }
    }
}
