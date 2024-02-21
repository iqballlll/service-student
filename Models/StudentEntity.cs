using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ServiceStudent.Helper;

namespace ServiceStudent.Models
{
   
    [Table("students")]
    public class StudentEntity
    {
        [Key, Required]
        public int id { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        public  string name { get; set; }
        
        [Required(ErrorMessage = "Age is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Age must be a positive number")]
        public int age { get; set; }
        
        [Required(ErrorMessage = "Address is required")]
        public required string address { get; set; }
      
        [Required(ErrorMessage = "Gender is required")]
        public string gender { get; set; }
        
      
    }
}