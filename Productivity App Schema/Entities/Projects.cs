﻿namespace Productivity_App_Schema.Entities
{
    public class Projects
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List <Tasks> Tasks { get; set; }

    }
}
