namespace GraphQLReal.Models
{
    public class Regions
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public ICollection<Country> Country { get; set; }
    }
}
