namespace task_scheduler.Models;

public class Task
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ScheduledDate { get; set; }
    public Status TaskStatus { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }

}