using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationcurddemo.Model;

namespace WebApplicationcurddemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        List<Students> _oStudents = new List<Students>()
        {
            new Students(){ Id=1,Name="shain",Roll=1001},
            new Students(){ Id=2,Name="Chaitanya",Roll=1002},
            new Students(){ Id=3,Name="Vijaya",Roll=1003},
            new Students(){ Id=4,Name="supriya",Roll=1004},
            new Students(){ Id=5,Name="snehal",Roll=1005},

        };

        [HttpGet]
        public IActionResult Gets()
        {
            if (_oStudents.Count == 0)
            {
                return NotFound("No list found.");
            }
            return Ok(_oStudents);
        }
        [HttpGet("GetStudent")]
        public IActionResult Get(int id)
        {
            var oStudent = _oStudents.SingleOrDefault(x => x.Id == id);
            if (oStudent == null)
            {
                return NotFound("No student found.");

            }
            return Ok(oStudent);
        }
        [HttpPost]
        public IActionResult Save(Students oStudent)
        {
            _oStudents.Add(oStudent);
            if (_oStudents.Count == 0)
            {
                return NotFound("No student found.");
            }
            return Ok(_oStudents);
        }

        [HttpPut]
        public IActionResult Update(int id, Students oStudent)
        {
            _oStudents.Add(oStudent);
            if (_oStudents.Count == 0)
            {
                return NotFound("No student found.");
            }
            return Ok(_oStudents);
        }


        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            var ostudent = _oStudents.SingleOrDefault(x => x.Id == id);
            if (_oStudents == null)
            {
                return NotFound("No student found.");
            }
            _oStudents.Remove(ostudent);
            if (_oStudents.Count == 0)
            {
                return NotFound("No list found.");
            }
            return Ok(_oStudents);
        }
        
    }
}
