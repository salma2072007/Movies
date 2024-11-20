using Microsoft.Identity.Client;

namespace Movies.models
{
    public class Diractory
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string ?contect { get; set; }

        public string? Email { get; set; }

        public int nationalityid { get; set; }

        public Nationalty  nationalty { get; set; }

        public List<Movie> movies { get; set; }
    }
}
