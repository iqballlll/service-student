using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceStudent.Models;

namespace ServiceStudent.Data;

public class ApiDBContext : DbContext
{
    public virtual DbSet<StudentEntity> Students { get; set; }
    public ApiDBContext(DbContextOptions<ApiDBContext> options) : base(options) { }


}