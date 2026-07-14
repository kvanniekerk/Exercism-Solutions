public class HighScores
{
    List<int> _scores;

    public HighScores(List<int> list)
    {
        this._scores = list;
    }

    public List<int> Scores() => _scores;

    public int Latest() => _scores[_scores.Count -1];

    public int PersonalBest()
    {
        int max = _scores[0];

        foreach (int score in _scores)
        {
            if (score > max)
                max = score;
        }

        return max;
    }

    public List<int> PersonalTopThree()
    {
        return _scores.OrderByDescending(x => x).Take(3).ToList();
    }
}