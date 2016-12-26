﻿using System.ComponentModel.DataAnnotations;

namespace T7.ControleFinanceiro.Infra.CrossCutting.Identity.Model
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}