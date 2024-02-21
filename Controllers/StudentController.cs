using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceStudent.Data;
using ServiceStudent.Helper;
using ServiceStudent.Models;

namespace ServiceStudent.Controllers
{
    [Route("v1/students")]
    [ApiController]
    public class StudentController(ApiDBContext context) : ControllerBase
    {
        // GET: v1/students/
        [HttpGet]
   
        public async Task<ActionResult<ResponseData<StudentEntity>>> GetStudents(
            [FromQuery] string name = "",
            [FromQuery] string address = "",
            [FromQuery] string gender = ""
            )
        {
            try
            {
                var query = context.Students.AsQueryable();
                if (!string.IsNullOrEmpty(name))
                    query = query.Where(s => s.name.Contains(name));

              
                if (!string.IsNullOrEmpty(address))
                    query = query.Where(s => s.address.Contains(address));

               
                if (!string.IsNullOrEmpty(gender))
                    query = query.Where(s => s.gender == gender);

                var data = await query.ToListAsync();
             
                return Ok(new ResponseData<IEnumerable<StudentEntity>>
                {
                    code = 200, message = "Success", data = data
                });
            }
            catch (Exception e)
            {
                return Ok(new ResponseData<object>
                {
                    code = 500, message = e.Message
                });
            }
        }
        

        // PUT: v1/students/5
      
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutStudentEntity(int id, StudentEntity studentEntity)
        {
           

            try
            {
                if (id != studentEntity.id)
                {
                    return Ok(new ResponseData<object>
                    {
                        code = 400, message = "Data not match"
                    });
                }

                var data = await context.Students.FindAsync(id);
            
                if (data == null)
                {
                    return Ok(new ResponseData<object>
                    {
                        code = 400, message = "Data not found"
                    });
                }

                data.name = studentEntity.name;
                data.address = studentEntity.address;
                data.age = studentEntity.age;
                data.gender = studentEntity.gender;

                await context.SaveChangesAsync();
                return Ok(new ResponseData<StudentEntity>
                {
                    code = 200, message = "Success", data = data
                });
            }
            catch (DbUpdateConcurrencyException e)
            {
                return Ok(new ResponseData<object>
                {
                    code = 500, message = e.Message
                });
            }

         
        }

        // POST: v1/students
      
        [HttpPost]
        public async Task<ActionResult<ResponseData<StudentEntity>>> PostStudentEntity(StudentData studentEntity)
        {
            try
            {
                var data = new StudentEntity
                {
                    name = studentEntity.name,
                    age = studentEntity.age,
                    address = studentEntity.address,
                    gender = studentEntity.gender
                    
                };
                context.Students.Add(data);
                await context.SaveChangesAsync();
                
                return Ok(new ResponseData<StudentEntity>
                {
                    code = 200, message = "Success", data = data
                });
            }
            catch (Exception e)
            {
                return Ok(new ResponseData<object>
                {
                    code = 500, message = e.Message
                });
            }
        }

        // DELETE: api/Student/5
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ResponseData<object>>> DeleteStudent(int id)
        {

            try
            {
                var studentEntity = await context.Students.FindAsync(id);
                if (studentEntity == null)
                {
                    return Ok(new ResponseData<object>
                    {
                        code = 404, message = "Data not found"
                    });
                }
                
                context.Students.Remove(studentEntity);
                await context.SaveChangesAsync();
                
                return Ok(new ResponseData<object>
                {
                    code = 200, message = "Success delete."
                });
                

            }
            catch (Exception e)
            {
                return Ok(new ResponseData<object>
                {
                    code = 500, message = e.Message
                });
            }
            
        }

      
        public class StudentData
        {
        
          
            public  string name { get; set; }
        
          
            public int age { get; set; }
        
          
            public required string address { get; set; }
      
         
            public string gender { get; set; }
            
        }
    }
}
