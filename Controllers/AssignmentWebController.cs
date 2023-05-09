using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using webAssignment079.Models;

namespace AssignmentWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class AssignmentWebController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        [HttpGet("GetStudent/{name}/{section}")]
        public string GetStudent(string name, string section)
        {
            return "My name is " + name + " and my section is " + section;
        }

        [HttpPost("SaveStudent")]
        public string SaveStudent(Assignment student) => "My name is " + student.Name + " and my section is " + student.Section;
        {
    public class Student
        {
            public string Name { get; set; }
            public string Section  { get; set; }
        }
}