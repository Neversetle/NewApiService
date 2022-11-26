using System.ComponentModel.DataAnnotations;

namespace NewWebApi.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name  { get; set; }
    }
}
