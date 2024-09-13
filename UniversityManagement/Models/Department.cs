using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Models
{
    public class Department
    {
        [Key]
        public String DeptName { get; set; }
        public String DeptHead { get; set; }
        public int EsatablishedYear { get; set; }
    }
}
