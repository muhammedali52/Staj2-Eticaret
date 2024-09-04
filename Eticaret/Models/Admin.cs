using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Eticaret.Models
{
    public class Admin
    {
        [Key]
        public int Admin_Id { get; set; }
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage ="Bu Alan Boş Geçilemez")]
        public string Admin_Name { get; set; }
        [DisplayName("Şifre")]
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [MinLength(8,ErrorMessage ="8 Karakterden az olamaz.")]
        public string Admin_Password { get; set; }
    }
}
