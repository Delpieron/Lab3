using System.ComponentModel.DataAnnotations;

namespace Lab3_test2.Models
{
    public class FormModel
    {
        [Display(Name = "Imie")]
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Ilosc powtorzen")]
        public int Iterations { get; set; }
    }
}
