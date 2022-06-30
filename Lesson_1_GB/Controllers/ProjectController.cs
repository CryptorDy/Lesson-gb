using Lesson_1_GB.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson_1_GB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController
    {
        public ProjectController()
        {

        }

        [HttpGet]
        public List<Project> Projects()
        {

        }

        [HttpGet]
        public List<Project> Projects(int id)
        {
            return null;
        }

        [HttpPost]
        public List<Project> Projects(int id)
        {
            return null;
        }
    }
}
