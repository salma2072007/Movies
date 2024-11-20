using Movies.Data;
using Movies.Dtos;

namespace Movies.Reposatory.NationaltyRepo
{
    public class NationalRepo : INationalRepo
    {
        private readonly AppDbcontext _context;

        public NationalRepo(AppDbcontext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
          
        }

        public void post(NationalDto national)
        {
            throw new NotImplementedException();
        }
    }
}
