using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EnglishPractice.Domain.WordJourney.Entities;

namespace EnglishPractice.Domain.Curriculum;

public class Grade
{
    private readonly List<Unit> _units = new();

    public int Order { get; private set; }

    public IReadOnlyList<Unit> Units => _units;

    public Grade(int order)
    {
        if (order <= 0)
        {
            throw new ArgumentException(
                "Grade order must be greater than zero.",
                nameof(order));
        }

        Order = order;
    }

    public void AddUnit(Unit unit)
    {
        if (unit is null)
        {
            throw new ArgumentNullException(nameof(unit));
        }

        _units.Add(unit);
    }

    // TODO: Revisit the Grade structure when Sentence Learning
    // and Story Learning are introduced.
}
