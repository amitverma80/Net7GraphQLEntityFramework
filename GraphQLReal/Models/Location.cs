namespace GraphQLReal.Models
{
    public class Location
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? City { get; set; }

        public int  CountryId { get; set; }

        public ICollection<Department>? Departments { get; set; }
    }
}
