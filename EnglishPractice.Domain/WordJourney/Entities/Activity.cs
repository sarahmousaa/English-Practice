using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPractice.Domain.WordJourney.Entities;

public class Activity
{
    private readonly List<ActivityStep> _steps = new();

    public string Name { get; private set; }

    public IReadOnlyCollection<ActivityStep> Steps => _steps.AsReadOnly();

    public Activity(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "Activity name cannot be empty.",
                nameof(name));
        }

        Name = name;
    }

    public void AddStep(ActivityStep step)
    {
        ArgumentNullException.ThrowIfNull(step);

        if (step.Order != _steps.Count + 1)
        {
            throw new InvalidOperationException(
                $"Expected step order {_steps.Count + 1}, " +
                $"but received {step.Order}.");
        }

        _steps.Add(step);
    }
}
