using System.ComponentModel.DataAnnotations;

namespace VetKlinik.Models
{
    public class Hizmetler
    {
        public int Id { get; set; }//primay key için koydum

        [Required(ErrorMessage ="Uzmanlık alanını girmek zorunludur.")]
        [StringLength(60, ErrorMessage ="En fazla 60 karakter giriniz.")]
        [Display(Name ="Uzmanlık Alanı")]
        public string UzmanlıkAlanı { get; set; } = "";





        public string CalismaSaatleri { get; set; } = "";
        public List<Hizmetler> Hizmetlerimiz { get; set; } = new();


    }
}
