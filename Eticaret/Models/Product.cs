using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eticaret.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public String Product_Name { get; set; } =String.Empty;
        public String Product_Description { get; set; } = String.Empty;
        public String Product_Image { get; set; } = String.Empty;
        public decimal? Product_Price { get; set; }
        [ForeignKey("Category")]
        public int? Category_Id { get; set; }
        public virtual Category? Category { get; set; }
        [ForeignKey("SubCategories")]
        public int? SubCategory_Id { get; set; }
        public virtual SubCategory? SubCategory { get; set; }

        public String Product_Feature { get; set; } = String.Empty;

        public List<ProductColor>? ProductColors { get; set; }
        public List<ProductSize>? ProductSize { get; set; }
        public List<Comment>? Comments { get; set; }
        [NotMapped]
        public  IFormFile? PictureImage { get; set; }

    }
}
