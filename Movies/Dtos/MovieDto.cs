namespace Movies.Dtos
{
    public class MovieDto
    {
        public string? Title { get; set; }

        public DateTime? Date { get; set; }

        public List<DiractorDto> Diractors { get; set; }
        public string? Categoryname { get; set; }

        public string? Nationaltyname { get; set; }
    }
}
