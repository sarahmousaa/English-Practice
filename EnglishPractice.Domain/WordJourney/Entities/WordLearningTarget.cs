using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPractice.Domain.WordJourney.Entities
{
    public class WordLearningTarget
    {
        public Word Word { get; private set; }

        public WordSense Sense { get; private set; }
        public WordLearningTarget(Word word, WordSense sense)
        {
            if (word is null)
            {
                throw new ArgumentNullException(nameof(word));
            }
            if (sense is null)
            {
                throw new ArgumentNullException(nameof(sense));
            }
            Word = word;
            Sense = sense;

        }
    }
}
