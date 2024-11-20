using Movies.Dtos;

namespace Movies.Reposatory.CategoryRepo
{
    public interface ICategoryRepo
    {
        public void post (CategoryDto category);

        public CategoryDto Update (int id,CategoryDto category);
    }
}
