using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Dtos;
using Movies.Reposatory.MovieRepo;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepo _Repo;

        public MovieController(IMovieRepo repo)
        {
            _Repo = repo;
        }
        [HttpGet]
        public IActionResult Getall()
        {
            var list= _Repo.Getall();
            return Ok(list);
        }
        [HttpPost]
        public IActionResult post(MovieDto movie)
        {
           _Repo.Add(movie);
           return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult get(int id)
        {
            var mov= _Repo.Get(id);
            return Ok(mov);
        }
    }
}
