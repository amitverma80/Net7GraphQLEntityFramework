namespace GraphQLReal.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }

        public string Email { get; set; }

        public int Mobile { get; set; }

        public DateTime? HireDate { get; set;}

        public int Salary { get; set; }

        public int JobId { get; set; }

        public ICollection<Dependents>? Dependents { get; set; }
    }
}
