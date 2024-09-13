using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Models
{
    public class Professor
	{
		[Key]
        public int ProfessorId { get; set; }

		public String ProfessorName { get; set; }
       
        public String PDepartment { get; set; }
        public String PHireDate { get; set; }
    }
}
