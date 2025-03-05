using System;
using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
