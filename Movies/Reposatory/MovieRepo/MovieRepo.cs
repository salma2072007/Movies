using Microsoft.EntityFrameworkCore;
using Movies.Data;
using Movies.Dtos;
using Movies.models;

namespace Movies.Reposatory.MovieRepo
{
    public class MovieRepo : IMovieRepo
    {
        private readonly AppDbcontext _context;

        public MovieRepo(AppDbcontext context)
        {
            _context = context;
        }

        public void Add(MovieDto movie)
        {
            var moviee = new Movie
            {
                Title = movie.Title,
                Date = movie.Date,
                Diractory=movie.Diractors.Select(x=> new Diractory
                {
                     Name = x.Name,
                     contect=x.contect,
                     Email=x.Email,
                     nationalty=new Nationalty
                     {
                         Name=movie.Nationaltyname
                     }

                }).ToList(),
                Categoryname= new Category
                {
                   Name= movie.Categoryname,
                }
               
            };
            _context.Movies.Add(moviee);
            _context.SaveChanges();

        }

        public MovieDto Get(int id)
        {
           var m= _context.Movies.Include(x=>x.Diractory).Include(x=>x.Categoryname).FirstOrDefault(x=>x.Id==id);
            return new MovieDto
            {
                Title = m.Title,
                Date = m.Date,
                Diractors = m.Diractory.Select(d => new DiractorDto
                {
                    Name = d.Name,
                    Email = d.Email,
                    contect = d.contect,
                }).ToList(),
                Categoryname=m.Categoryname.Name
            };
        }

        public List<MovieDto> Getall()
        {
            var Movie = _context.Movies.Include(x=>x.Diractory).ThenInclude(x=>x.nationalty).Include(x=>x.Categoryname).Select(m=> new MovieDto
            {
                Title=m.Title,
                Date=m.Date,
                Categoryname=m.Categoryname.Name,
                Diractors=m.Diractory.Select(d=> new DiractorDto
                {
                    Name=d.Name,
                    Email=d.Email,
                    nationaltyname=d.nationalty.Name,
                    contect=d.contect,
                    

                }).ToList(),
              
            }).ToList();
            return Movie;

        }
    }
}
