using System.ComponentModel.DataAnnotations.Schema;

namespace MVC4UserControl.Models
{
    [Table("TableEmployee")]
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ThirdName { get; set; }
    }
}