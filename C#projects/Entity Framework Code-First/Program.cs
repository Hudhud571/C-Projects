using System;

class Program
{
    static void Main()
    {
        using (var context = new StudentContext())
        {
            var student = new Student { Name = "Abdirahman Said", Age = 30 };
            context.Students.Add(student);
            context.SaveChanges();
            Console.WriteLine("Student added successfully!");
        }
    }
}
