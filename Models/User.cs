namespace task_scheduler.Models;
public class User
{
    public int Id { get; private set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public List<Task> Tasks = new List<Task>(); 

}