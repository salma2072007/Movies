namespace Movies.models
{
    public class Nationalty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiractoryId { get; set; }
        public Diractory? Diractory { get; set; }

    }
}
