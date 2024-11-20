using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Dtos;
using Movies.Reposatory.CategoryRepo;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _Repo;

        public CategoryController(ICategoryRepo repo)
        {
            _Repo = repo;
        }
        [HttpPost]
        public IActionResult post(CategoryDto category)
        {
             _Repo.post(category);
            return Ok(category);
        }
        [HttpPut("{id}")]
        public IActionResult put(CategoryDto category,int id)
        {
            var cat= _Repo.Update(id,category);
            if(cat==null)
            {
                return NotFound();
            }
            return Ok(cat);
        }

    }
}
