namespace backend.Repository
{
    public class ProductsNotDeserialisable : Exception
    {
        public ProductsNotDeserialisable()
            : base("Products could not be deserialized")
        {
        }
    }
}
