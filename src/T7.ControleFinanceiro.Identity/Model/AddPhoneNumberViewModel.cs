using System.ComponentModel.DataAnnotations;

namespace T7.ControleFinanceiro.Infra.CrossCutting.Identity.Model
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}