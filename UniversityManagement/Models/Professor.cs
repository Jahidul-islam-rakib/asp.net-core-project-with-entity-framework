using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Models
{
    public class Professor
	{
		[Key]
        public int Id { get; set; }
        public int ProfessorId { get; set; }

		public String ProfessorName { get; set; }
       
        public String PDepartment { get; set; }
        public String PHireDate { get; set; }
    }
}
