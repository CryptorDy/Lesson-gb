using Lesson_1_GB.Models;

namespace Lesson_1_GB.BD
{
    public class ProjectsDB
    {
        private List<Project> _projects;
        

        public ProjectsDB()
        {
            var project1 = new Project { Id = 1, Name = "Tesla", Deadline = new DateTime(2025, 12, 31 ), Status = true, ManagerId = "1" };
            var project2 = new Project { Id = 1, Name = "BMW", Deadline = new DateTime(2030, 12, 31 ), Status = true, ManagerId = "1" };

            _projects = new List<Project> { project1, project2 };
        }

        public List<Project> AllProject()
        {
            return _projects;
        }

    }
}
