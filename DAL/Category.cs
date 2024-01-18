using System.ComponentModel.DataAnnotations;

namespace FarmaMundo.DAL
{
    public class Category
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Product>? ProductsRelationList { get; set; }
        public virtual ICollection<ProductCategory>? ProductCategoriesRelationList { get; set; }

    }
}
