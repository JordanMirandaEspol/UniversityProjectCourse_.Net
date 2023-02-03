﻿using System.ComponentModel.DataAnnotations;
namespace universityApiBackend.Models.DataModels
{
    public class Student:BaseEntity
    {
        [Required]
        public String name { get; set; }= string.Empty;
        [Required]
        public string LastName { get; set; }=string.Empty;
        [Required]
        public DateTime Dob { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
