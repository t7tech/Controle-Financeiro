using System.Configuration;
using T7.ControleFinanceiro.Core.Configuration;

namespace T7.ControleFinanceiro.Core.Configuration
{
    public class AppConfig : ConfigurationSection
    {
        #region Constructor

        public static AppConfig Get()
        {
            return (AppConfig)ConfigurationManager.GetSection("appConfig");
        }

        #endregion

        [ConfigurationProperty("DefaultClaimType")]
        public string DefaultClaimType
        {
            get
            {
                return this["DefaultClaimType"].ToString();
            }
        }

        [ConfigurationProperty("DefaultClaimValue")]
        public string DefaultClaimValue
        {
            get
            {
                return this["DefaultClaimValue"].ToString();
            }
        }

        [ConfigurationProperty("Server")]
        public string Server
        {
            get
            {
                return this["Server"].ToString();
            }
        }

        [ConfigurationProperty("identityEmail")]
        public IdentityConfigElement IdentityEmail
        {
            get
            {
                return (IdentityConfigElement)this["identityEmail"];
            }
        }
    }
}