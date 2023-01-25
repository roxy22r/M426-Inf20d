namespace Testing.Lotto;

public class LottoNumberRetriever
{
    public LottoNumberRetriever(int[] drawnLottoNumbers)
    {
        DrawnLottoNumbers = drawnLottoNumbers;
    }

    public int[] DrawnLottoNumbers { get; }
}