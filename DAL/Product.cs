using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace FarmaMundo.DAL
{
    public class Product
    {
        [Key]
        [Required]
        public int Idproduct { get; set; }
        
        [Required]
        public required string Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public DateTime CreateDate { get; set; }
    
    public virtual ICollection<Category>? CategoriesRelationList { get; set; }
    public virtual ICollection<ProductCategory>? ProductCategoriesRelationList { get; set; }
    
    }
}
