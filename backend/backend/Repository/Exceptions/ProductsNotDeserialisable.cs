namespace backend.Repository.Exceptions
{
    public class ProductsNotDeserialisable : Exception
    {
        public ProductsNotDeserialisable()
            : base("Products could not be deserialized")
        {
        }
    }
}
