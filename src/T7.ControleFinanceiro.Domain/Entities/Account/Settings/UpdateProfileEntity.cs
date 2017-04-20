using System;

namespace T7.ControleFinanceiro.Domain.Entities.Account.Settings
{
    public class UpdateProfileEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }
    }
}