namespace backend.Repository
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Article> Articles { get; set; }
    }
}
