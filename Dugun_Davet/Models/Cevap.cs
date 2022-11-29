using System.ComponentModel.DataAnnotations;

namespace Dugun_Davet.Models
{
    public class Cevap
    {
        [Required(ErrorMessage ="Lütfen ad alanını boş bırakmayınız!")] // Ad'ın boş geçilmemesini sağlıyor.
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen soyad alanını boş bırakmayınız!")] // Soyad'ın boş geçilmemesini sağlıyor.
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Lütfen email alanını boş bırakmayınız!")] // Email'in boş geçilmemesini sağlıyor.
        [EmailAddress] // Girilen email'in formata uygun olup olmadığını kontrol eder.
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen telefon alanını boş bırakmayınız!")] // Telefon'un boş geçilmemesini sağlıyor.
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Lütfen bir seçim yapınız!")] // DuguneGelecekMi'nin boş geçilmemesini sağlıyor.
        public bool? DuguneGelecekMi { get; set; } //boll? demek alanın boş kalamayacağı anlamına geliyor
    }
}
