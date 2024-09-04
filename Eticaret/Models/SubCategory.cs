using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eticaret.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategory_Id { get; set; }
        [Display(Name ="Alt Kategori Adı")]
        public string SubCategory_Name { get; set; } = String.Empty;
        [Display(Name ="Kategori Adı")]
        [ForeignKey("Category")]
        public int? Category_Id { get; set; }
        public virtual Category? Category { get; set; }
        public ICollection<Product>? Products { get; set; }

    }
}
