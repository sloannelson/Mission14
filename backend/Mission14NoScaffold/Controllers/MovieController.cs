using Microsoft.AspNetCore.Mvc;
using Mission14NoScaffold.Models;

namespace Mission14NoScaffold.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MoviesDBContext context;
        public MovieController(MoviesDBContext temp) {
            context = temp;
        }
        public IEnumerable<Movie> Get()
        {
            var x = context.Movies
                .Where(x => x.Edited == "Yes")
                .OrderBy(x => x.Title)
                .ToArray();
            return x;
        }


    }
}
