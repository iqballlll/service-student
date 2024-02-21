using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceStudent.Models;

[Table("grades")]
public class GradesEntity
{
    [Key, Required]
    public int id { get; set; }
    public int student_id { get; set; }
    public int grade { get; set; }
}