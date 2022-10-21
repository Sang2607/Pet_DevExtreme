using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace PetProjects_Dev_Extreme.Models
{

    [Table("Student")]
    public class Student
    {
       
       [Key]
        public int SchedulerID { get; set; }
        [Required]
        public DateTime DoB { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ClassStudent { get; set; }
        public int Maths { get; set; }
        public int Physical { get; set; }   
        public int Chemistry { get; set; }

   
        public int Medium { get; set; }
        
        public static List<Student> aaa = new List<Student>();

    }
}