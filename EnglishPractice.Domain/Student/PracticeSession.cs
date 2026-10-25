using EnglishPractice.Domain.WordJourney.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPractice.Domain.Student;
public class PracticeSession
{
    public WordSet WordSet { get; private set; }

    public DateTime StartedAt { get; private set; }

    public DateTime? EndedAt { get; private set; }

    public PracticeSession(WordSet wordSet)
    {
        if (wordSet is null)
        {
            throw new ArgumentNullException(nameof(wordSet));
        }

        WordSet = wordSet;
        StartedAt = DateTime.UtcNow;
    }

    public void End()
    {
        EndedAt = DateTime.UtcNow;
    }
}
// think about activity entity to know which one to pick for short session.