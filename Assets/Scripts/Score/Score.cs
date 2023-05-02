public static class Score
{
    public static int ScoreCount {get; private set;}

    public static void AddScore(int amount)
    {
        ScoreCount += amount;
    }
}