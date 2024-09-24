using System.ComponentModel.DataAnnotations;

namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
    }

}
