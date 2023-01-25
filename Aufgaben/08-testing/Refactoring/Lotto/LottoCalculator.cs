namespace Testing.Lotto
{
    public class LottoCalculator
    {
        private readonly LottoNumberValidator _lottoNumberValidator;
        private readonly LuckyNumberCalculator _luckyNumberCalculator;
        private readonly LottoNumberRetriever _lottoNumberRetriever;

        public LottoCalculator(
            LottoNumberValidator lottoNumberValidator,
            LuckyNumberCalculator luckyNumberCalculator,
            LottoNumberRetriever lottoNumberRetriever)
        {
            _lottoNumberValidator = lottoNumberValidator;
            _luckyNumberCalculator = luckyNumberCalculator;
            _lottoNumberRetriever = lottoNumberRetriever;
        }

        public int Calculate(int[] lottoNumbers, int luckyNumber)
        {
            var resultMultiplication = 1;

            if (_lottoNumberValidator.Validate(lottoNumbers))
            {
                throw new ArgumentException("Invalid lotto numbers");
            }

            if (_luckyNumberCalculator.Validate(luckyNumber))
            {
                resultMultiplication = 2;
            }

            return _lottoNumberRetriever.DrawnLottoNumbers
                .Intersect(lottoNumbers)
                .Count() * 100 * resultMultiplication;
        }
    }
}