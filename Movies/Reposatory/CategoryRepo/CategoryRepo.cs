using Movies.Data;
using Movies.Dtos;
using Movies.models;

namespace Movies.Reposatory.CategoryRepo
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbcontext _context;

        public CategoryRepo(AppDbcontext context)
        {
            _context = context;
        }

        public void post(CategoryDto category)
        {
            var cat = new Category
            {
                Name = category.Name,

            };
            _context.Categories.Add(cat);
            _context.SaveChanges();  
           
        }

        public CategoryDto Update(int id, CategoryDto category)
        {
            var cat= _context.Categories.Find(id);
            if (cat == null)
            {
                throw new Exception("error");
            }
            else
            {
                cat.Name = category.Name;
                
            }
            _context.Categories.Update(cat);
            _context.SaveChanges();
            return category;
        }
    }
}
