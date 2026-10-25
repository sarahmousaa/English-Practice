using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPractice.Domain.Student;

public class Student
{
    public int Id { get; private set; }

    public string Name { get; private set; }

    public Student(int id, string name)
    {
        if (id <= 0)
        {
            throw new ArgumentException(
                "Student ID must be greater than zero.",
                nameof(id));
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Student name cannot be empty.",
                nameof(name));
        }

        Id = id;
        Name = name;
    }
}