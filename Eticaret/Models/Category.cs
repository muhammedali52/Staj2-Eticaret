using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Eticaret.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        public String Category_Name { get; set; } = String.Empty;
        public virtual ICollection<SubCategory>? SubCategories { get; set; }
        public virtual ICollection<Product>? Products { get; set; }




    }
}
