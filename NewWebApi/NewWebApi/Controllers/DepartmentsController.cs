using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewWebApi.Models;

namespace NewWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {

        OrganizationDbContext dbContext;

        public DepartmentsController( OrganizationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }


        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            //var dbContext1 = new OrganizationDbContext();  
            //var depts = await dbContext1.Departments.ToListAsync();
            //dbContext1.Dispose();
            //return Ok(depts);

            using(var dbContext1 = new OrganizationDbContext())
            {
                var depts = await dbContext.Departments.ToListAsync();
                return Ok(depts);
            }
                
        }

        [HttpGet("getDeptById/{did}")]
        public async Task<ActionResult<Department>> GetDepartmentById(int did)
        {
            var dept = await dbContext.Departments.FindAsync(did);
            if (dept != null)
                return Ok(dept);
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<Department>> PostDepartment(Department D)
        {
            dbContext.Departments.Add(D);
            await dbContext.SaveChangesAsync();

            return CreatedAtAction("Record inserted Successfully", new {did = D.Did},D);
        }

        [HttpDelete("deleteDeptById/{did}")]
        public async Task<ActionResult<Department>> deleteDeptById(int did)
        {
            if (RecordExist(did))
            {
                var dept = await dbContext.Departments.FindAsync(did);

                dbContext.Departments.Remove(dept);
                await dbContext.SaveChangesAsync();

                return Ok(dept);
            }
            return NotFound();
            
        }

        private bool RecordExist(int did)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{did}")]
        public string putDeptById(int did, Department D)
        {
            dbContext.Departments.Update(D);
            dbContext.SaveChanges();

            return "Record Updated Successfully";
        }


     
        
    }
}
