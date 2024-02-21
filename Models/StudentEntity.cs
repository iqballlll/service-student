using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceStudent.Models
{
    public enum Gender
    {
        Male,
        Female
    }
    public class StudentEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public required string Address { get; set; }
        public Gender gender { get; set; }
    }
}