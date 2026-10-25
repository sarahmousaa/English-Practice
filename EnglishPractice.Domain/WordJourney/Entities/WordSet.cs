using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPractice.Domain.WordJourney.Entities
{
    public class WordSet
    {
        private readonly List<WordLearningTarget> _learningTargets = new();

        public int Order { get; private set; }
        public string LearningGoal { get; private set; }
        public IReadOnlyList<WordLearningTarget> LearningTargets => _learningTargets;
        public WordSet(int order, string learningGoal)
        {
            if (order <= 0)
            {
                throw new ArgumentException(
                    "Word set order must be greater than zero.",
                    nameof(order));
            }

            if (string.IsNullOrWhiteSpace(learningGoal))
            {
                throw new ArgumentException(
                    "Learning goal cannot be empty.",
                    nameof(learningGoal));
            }

            Order = order;
            LearningGoal = learningGoal;
        }
        public void AddLearningTarget(WordLearningTarget target)
        {
            if (target is null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            _learningTargets.Add(target);
        }
    }
}
