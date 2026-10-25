using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPractice.Domain.WordJourney.Entities;

public class ActivityPattern
{
    public string Name { get; private set; }

    public ActivityPattern(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Activity pattern name cannot be empty.",
                nameof(name));
        }

        Name = name;
    }
}
