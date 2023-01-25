namespace Testing.Lotto;

public class LuckyNumberCalculator
{
    private readonly int _drawnLuckyNumber;

    public LuckyNumberCalculator(int drawnLuckyNumber)
    {
        _drawnLuckyNumber = drawnLuckyNumber;
    }

    public bool Validate(int luckyNumber)
    {
        if (luckyNumber is > 6 or < 1)
        {
            throw new ArgumentOutOfRangeException($"{nameof(luckyNumber)} is invalid");
        }

        return _drawnLuckyNumber == luckyNumber;
    }
}