namespace CompositePattern.ECigaretteConcept
{
    public class Ego : IECigarette
    {
        private readonly IECigarette _eCigarette;

        public Ego(IECigarette eCigarette)
        {
            this._eCigarette = eCigarette;
        }

        public double GetPrice()
        {
            return _eCigarette.GetPrice() + 20.00;
        }
    }
}
