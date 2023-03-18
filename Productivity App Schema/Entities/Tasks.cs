using System.ComponentModel;

namespace Productivity_App_Schema.Entities
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int ProjectId { get; set; }
        public DateTime Deadline { get; set; }

        public Boolean Completed { get; set; }

        public Categories Categories { get; set; }

        public Projects Projects { get; set; }




    }
}
