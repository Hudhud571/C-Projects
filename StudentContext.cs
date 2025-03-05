using System.Data.Entity;

public class StudentContext : DbContext
{
    public StudentContext() : base("StudentDB")
    {
    }

    public DbSet<Student> Students { get; set; }
}
