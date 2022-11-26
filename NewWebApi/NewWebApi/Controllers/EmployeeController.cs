using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewWebApi.Models;

namespace NewWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //[HttpGet]
        //public string Get()
        //{
        //    return "Welcome Employee";
        //}

        //[HttpGet("getById")]
        //public string Get(int id)
        //{
        //    return "Welcome Employee" + id.ToString();
        //}

        //[HttpGet("getByIdandName/{id}/{name}")]
        //public string Get(int id, string name)
        //{
        //    return "Welcome Employee " + id.ToString()+" "+name.ToString();
        //}

        //[HttpGet("getEmployee")]
        //public Employee Get()
        //{
        //    var E = new Employee()
        //    {
        //        Id = 101,
        //        Name = "sunil"
        //    };

        //    return E;

        //}

        //[HttpGet("getAllEmployees")]
        //public IEnumerable<Employee> Get()
        //{
        //    List<Employee> emps = new List<Employee>()
        //    { 
        //        new Employee() { Id = 1, Name = "sham"},
        //        new Employee() { Id = 2, Name = "rahul"},
        //        new Employee() { Id = 3, Name = "sushma"},
        //        new Employee() { Id = 4, Name = "rohini"}
        //    };
        //    return emps;
        //}

        [HttpGet("getAllEmployees/{id}")]
        public IEnumerable<Employee> Get(int id)
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "sham"},
                new Employee() { Id = 2, Name = "rahul"},
                new Employee() { Id = 3, Name = "sushma"},
                new Employee() { Id = 4, Name = "rohini"}
            };

            if(id == 0)
                return emps;
            else 
                return emps.Where(x => x.Id == id);

            return emps;
        }// this is final output


    }
}
