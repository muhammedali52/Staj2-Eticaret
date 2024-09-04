using System.ComponentModel.DataAnnotations;

namespace Eticaret.Models
{
    public class ProductSize
    {
        [Key]
        public int ProductSizeId { get; set; }
        public int ProductId { get; set; }

        public Product? Product { get; set; }
        public int SizeId { get; set; }

        public Size? Size { get; set; }
    }
}
