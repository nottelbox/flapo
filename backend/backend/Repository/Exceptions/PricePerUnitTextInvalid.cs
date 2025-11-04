namespace backend.Repository.Exceptions
{
    public class PricePerUnitTextInvalid : Exception
    {
        public PricePerUnitTextInvalid()
            : base("PricePerUnitText format is invalid")
        {
        }
    }
}
