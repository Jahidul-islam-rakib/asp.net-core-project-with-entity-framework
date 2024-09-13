﻿using System.ComponentModel.DataAnnotations;

namespace UniversityManagement.Models
{
    public class Student
    {
        [Key]
        public int StId { get; set; }
        public string StFullName { get; set; }
        public string StEnrollmentDate { get; set; }
    }
}