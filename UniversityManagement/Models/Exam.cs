using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Models
{
	public class Exam
	{
        [Key]
        public int ExamId { get; set; }
        public String ExamName { get; set; }
        public String ExamDate { get; set; }
        public int TotalMarks { get; set; }
    }
}
