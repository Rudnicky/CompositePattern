namespace CompositePattern.ECigaretteConcept
{
    public class VapingShelter : IECigarette
    {
        private readonly IECigarette _eCigarette;

        public VapingShelter(IECigarette eCigarette)
        {
            this._eCigarette = eCigarette;
        }

        public double GetPrice()
        {
            return _eCigarette.GetPrice() + 15.00;
        }
    }
}
