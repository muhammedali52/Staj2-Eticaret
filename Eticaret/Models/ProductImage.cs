namespace Eticaret.Models
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public string ImageName { get; set; }=String.Empty;

        public int ProductId { get; set; }
    }
}
