using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPractice.Domain.WordJourney.Entities
{
    public class WordSense
    {
        private readonly List<string> _examples = new();

        public string Description { get; private set; }

        public IReadOnlyList<string> Examples => _examples;
        public WordSense(string description, string example)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException(
                    "Word sense description cannot be empty.",
                    nameof(description));
            }

            if (string.IsNullOrWhiteSpace(example))
            {
                throw new ArgumentException(
                    "Word sense example cannot be empty.",
                    nameof(example));
            }

            Description = description;
            _examples.Add(example);
        }
        public void AddExample(string example)
        {
            if (string.IsNullOrWhiteSpace(example))
            {
                throw new ArgumentException(
                    "Word sense example cannot be empty.",
                    nameof(example));
            }

            _examples.Add(example);
        }
    }
}
