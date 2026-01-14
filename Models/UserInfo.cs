using System.ComponentModel.DataAnnotations;

namespace meetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad soyad alanı boş bırakılamaz.")] //Boş geçilemez
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [EmailAddress] //Email formatında olmalı
        public string? Email { get; set; }
        [Required]
        public bool? WillAttend { get; set; } //default olarak false gelir o yuzden required normalde tetiklenmez bu yuzden ekstra ? ekledik null false ya da true gelebilir
    }
}