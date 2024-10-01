using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public String DeptName { get; set; }
        public String DeptHead { get; set; }
        public int EsatablishedYear { get; set; }
    }
}
