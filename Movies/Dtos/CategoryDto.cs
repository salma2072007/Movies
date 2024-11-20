using System.ComponentModel.DataAnnotations;

namespace Movies.Dtos
{
    public class CategoryDto
    {
        [Required]
        public string? Name { get; set; }
    }
}
