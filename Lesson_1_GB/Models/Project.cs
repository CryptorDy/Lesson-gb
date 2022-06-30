namespace Lesson_1_GB.Models
{
    public class Project
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public DateTime Deadline { get; set; }

        public bool Status { get; set; }

        public string ManagerId { get; set; }
    }
}
