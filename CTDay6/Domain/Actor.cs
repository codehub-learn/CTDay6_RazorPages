namespace CTDay6.Domain
{
    public class Actor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<Movie> Movies { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";   
        }
    }
}
