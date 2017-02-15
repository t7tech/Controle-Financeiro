using System;
using System.ComponentModel.DataAnnotations;

namespace T7.ControleFinanceiro.Infra.CrossCutting.Identity.Model
{
    public class RegisterModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime DateBirth { get; set; }
    }
}