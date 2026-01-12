using Microsoft.EntityFrameworkCore;
using task_scheduler.Models;
using Task = task_scheduler.Models.Task;

namespace task_scheduler.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Task> Tasks {get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
}