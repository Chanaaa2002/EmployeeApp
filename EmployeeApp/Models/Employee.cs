using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public string Department { get; set; }
    }
}
