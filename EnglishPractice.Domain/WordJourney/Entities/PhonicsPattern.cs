using System;
using EnglishPractice.Domain.WordJourney.Enums;
namespace EnglishPractice.Domain.WordJourney.Entities
{
    public class PhonicsPattern
    {
        private readonly List<string> _exampleWords = new();
        public string Grapheme { get; private set; }              // e.g., "sh", "cr"
        public string SoundIpa { get; private set; }                // e.g., "/ʃ/"
        public PhonicsCategory Category { get; private set; }
        public string? AudioStorageKey { get; private set; }        // Isolated sound audio
        public string? VideoStorageKey { get; private set; }        // Articulation / teacher video
        public IReadOnlyCollection<string> ExampleWords => _exampleWords.AsReadOnly();
        public PhonicsPattern(
            string grapheme,
            string soundIpa,
            PhonicsCategory category,
            string? audioStorageKey = null,
            string? videoStorageKey = null)
        {
            if (string.IsNullOrWhiteSpace(grapheme))
            {
                throw new ArgumentException("Grapheme cannot be empty.", nameof(grapheme));
            }

            if (string.IsNullOrWhiteSpace(soundIpa))
            {
                throw new ArgumentException("Sound IPA representation cannot be empty.", nameof(soundIpa));
            }

            if (!Enum.IsDefined(category))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(category),
                    "The provided phonics category is not valid.");
            }

            Grapheme = grapheme.Trim();
            SoundIpa = soundIpa.Trim();
            Category = category;

            AudioStorageKey = string.IsNullOrWhiteSpace(audioStorageKey)
                ? null
                : audioStorageKey.Trim();

            VideoStorageKey = string.IsNullOrWhiteSpace(videoStorageKey)
                ? null
                : videoStorageKey.Trim();
        }

        public void AddExampleWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentException("Example word cannot be empty.", nameof(word));
            }

            string trimmedWord = word.Trim();

            if (_exampleWords.Contains(trimmedWord, StringComparer.OrdinalIgnoreCase))
            {
                return;
            }

            _exampleWords.Add(trimmedWord);
        }
    }
}