namespace Movies.models
{
    public class Movie
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public DateTime ? Date { get; set; }

        public int ? Categoryid { get; set; }

        public Category? Categoryname { get; set; } 

        public List<Diractory> Diractory { get; set; }
    }
}
