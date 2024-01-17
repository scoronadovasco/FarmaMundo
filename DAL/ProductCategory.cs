
namespace FarmaMundo.DAL
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product? product { get; set; }
        public int CategoryId { get; set; }

        public Category? category { get; set; }
    }
}