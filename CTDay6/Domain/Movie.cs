namespace CTDay6.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Director { get; set; }
        public List<Actor> Actors { get; set; } = null!;
        public Genre Genre { get; set; }

        public override string ToString()
        {
            return $"{Title}: {Description}";
        }

    }
}
