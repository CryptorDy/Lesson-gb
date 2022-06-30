﻿namespace Lesson_1_GB.Models
{
    public class Tasks
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Deadline { get; set; }

        public int EmployeerId { get; set; }

        public int ProjectId { get; set; }

    }
}
