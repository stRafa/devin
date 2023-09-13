using DevIn.API.ViewModels.Post;
using DevIn.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevIn.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly AppDbContext _ctx;

        public PostsController(IConfiguration configuration, AppDbContext dbContext)
        {
            _configuration = configuration;
            _ctx = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPosts(int page = 0, int pageSize = 25)
        {
            try
            {
                var posts = await _ctx
                    .Posts
                    .AsNoTracking()
                    .Include(x => x.Category)
                    .Include(x => x.Tags)
                    .Select(x => new ListPostViewModel
                    {

                    })
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .OrderByDescending(x => x.CreateDate)
                    .ToListAsync();

                return Ok(posts);
            }
            catch (Exception ex)
            {
                // Log the exception or return an error response
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
