namespace CompositePattern.ECigaretteConcept
{
    public class TheatricalFake : IECigarette
    {
        private readonly IECigarette _eCigarette;

        public TheatricalFake(IECigarette eCigarette)
        {
            this._eCigarette = eCigarette;
        }

        public double GetPrice()
        {
            return _eCigarette.GetPrice() + 30.00;
        }
    }
}
