using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnglishPractice.Domain.Curriculum;

namespace EnglishPractice.Domain.WordJourney.Entities;

public class Unit
{
    private readonly List<WordSet> _wordSets = new();

    public int Order { get; private set; }
    public string Title { get; private set; }


    public IReadOnlyList<WordSet> WordSets => _wordSets;

    public Unit(int order, string title)
    {
        if (order <= 0)
        {
            throw new ArgumentException(
                "Unit order must be greater than zero.",
                nameof(order));
        }

        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException(
                "Unit title cannot be empty.",
                nameof(title));
        }

        Order = order;
        Title = title;
    }

    public void AddWordSet(WordSet wordSet)
    {
        if (wordSet is null)
        {
            throw new ArgumentNullException(nameof(wordSet));
        }

        _wordSets.Add(wordSet);
    }
}
