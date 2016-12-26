using System.Collections.Generic;

namespace T7.ControleFinanceiro.Infra.CrossCutting.Identity.Model
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<string> Providers { get; set; }
    }
}