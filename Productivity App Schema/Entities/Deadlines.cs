namespace Productivity_App_Schema.Entities
{
    public class Deadlines
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public DateTime Deadline { get; set;}
        public Tasks Tasks { get; set; }
        
        
    }
}
