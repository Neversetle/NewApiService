using System.ComponentModel.DataAnnotations;

namespace NewWebApi.Models
{
    public class Department
    {
        [Key]
        public int Did { get; set; }
        public string  Dname { get; set; }
        public string Descrip { get; set; }
    }
}
