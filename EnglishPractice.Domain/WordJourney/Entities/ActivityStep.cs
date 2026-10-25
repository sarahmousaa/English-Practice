using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPractice.Domain.WordJourney.Entities;

public class ActivityStep
{
    public int Order { get; private set; }

    public ActivityPattern Pattern { get; private set; }

    public ActivityStep(int order, ActivityPattern pattern)
    {
        if (order < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(order),
                "Step order must be at least 1.");
        }

        Pattern = pattern ?? throw new ArgumentNullException(
            nameof(pattern));

        Order = order;
    }
}
