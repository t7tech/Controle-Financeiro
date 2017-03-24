using System.Configuration;

namespace T7.ControleFinanceiro.Core
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
    }
}