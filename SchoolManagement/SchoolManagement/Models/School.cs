using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
	public class School
	{
        [Key]
        public int StId { get; set; }
        public String StName { get; set; }
        public string StFName { get; set; }
        public String DOB {  get; set; }
    }
}
