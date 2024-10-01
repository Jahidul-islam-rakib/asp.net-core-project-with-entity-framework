using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Models
{
	public class Course
	{
		[Key]
		public int Id { get; set; }
		public String CourseId {  get; set; }
		public string CourseName { get; set; }
		public int CourseCredit { get; set; }
	}
}
