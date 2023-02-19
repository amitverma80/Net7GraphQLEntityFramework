namespace GraphQLReal.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int RegionId { get; set; }

        public ICollection<Location> Locations { get; set; }
    }
}
