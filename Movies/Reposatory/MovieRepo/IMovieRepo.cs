using Movies.Dtos;

namespace Movies.Reposatory.MovieRepo
{
    public interface IMovieRepo
    {
        public List<MovieDto> Getall();

        public MovieDto Get(int id);

        public void Add(MovieDto movie);
    }
}
