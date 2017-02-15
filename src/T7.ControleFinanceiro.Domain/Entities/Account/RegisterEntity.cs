using System;

namespace T7.ControleFinanceiro.Domain.Entities.Account
{
    public class RegisterEntity
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime DateBirth { get; set; }
    }
}