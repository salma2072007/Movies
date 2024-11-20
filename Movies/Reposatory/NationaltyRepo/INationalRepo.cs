using Movies.Dtos;

namespace Movies.Reposatory.NationaltyRepo
{
    public interface INationalRepo
    {
        public void post(NationalDto national);

        public void Delete(int id);

    }
}
