using System;
using System.Collections.Generic;

namespace EnglishPractice.Domain.WordJourney.Entities
{
    // A Word owns its media and references reusable phonics patterns.
    public class Word
    {
        private readonly List<PhonicsPattern> _phonics = new();
        private readonly List<WordMedia> _media = new();

        public string Term { get; private set; }

        public IReadOnlyCollection<PhonicsPattern> Phonics =>
            _phonics.AsReadOnly();

        public IReadOnlyCollection<WordMedia> Media =>
            _media.AsReadOnly();

        public Word(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                throw new ArgumentException(
                    "Word term cannot be empty.",
                    nameof(term));
            }

            Term = term.Trim();
        }

        public void AddPhonicsPattern(PhonicsPattern pattern)
        {
            ArgumentNullException.ThrowIfNull(pattern);

            if (_phonics.Contains(pattern))
            {
                return;
            }

            _phonics.Add(pattern);
        }

        public void AddMedia(
            MediaType mediaType,
            string storageKey,
            string? altText = null,
            int displayOrder = 0)
        {
            var media = new WordMedia(
                mediaType,
                storageKey,
                altText,
                displayOrder);

            _media.Add(media);
        }
    }
}