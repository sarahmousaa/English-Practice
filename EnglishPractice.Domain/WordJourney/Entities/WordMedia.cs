using System;

namespace EnglishPractice.Domain.WordJourney.Entities
{
    public class WordMedia
    {
        public int Id { get; private set; }

        //public int WordId { get; private set; }

        public MediaType MediaType { get; private set; }

        public string StorageKey { get; private set; }

        public string? AltText { get; private set; }

        public int DisplayOrder { get; private set; }

        public WordMedia(
           // int wordId,
            MediaType mediaType,
            string storageKey,
            string? altText = null,
            int displayOrder = 0)
        {
            //if (wordId <= 0)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(wordId));
            //}

            if (!Enum.IsDefined(mediaType))
            {
                throw new ArgumentOutOfRangeException(nameof(mediaType));
            }

            if (string.IsNullOrWhiteSpace(storageKey))
            {
                throw new ArgumentException(
                    "Storage key cannot be empty.",
                    nameof(storageKey));
            }

            if (displayOrder < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(displayOrder));
            }

           // WordId = wordId;
            MediaType = mediaType;
            StorageKey = storageKey;
            AltText = altText;
            DisplayOrder = displayOrder;
        }
    }
}
