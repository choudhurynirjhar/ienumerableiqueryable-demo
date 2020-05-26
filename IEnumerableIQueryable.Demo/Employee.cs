using System.ComponentModel.DataAnnotations.Schema;

namespace IEnumerableIQueryable.Demo
{
    [Table("Employees")]
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
