using System;
using System.Configuration;

namespace T7.ControleFinanceiro.Core.Configuration
{
    public class IdentityConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("Smtp")]
        public string Smtp
        {
            get
            {
                return this["Smtp"].ToString();
            }
        }

        [ConfigurationProperty("Port")]
        public int Port
        {
            get
            {
                return Convert.ToInt16(this["Port"]);
            }
        }

        [ConfigurationProperty("UserName")]
        public string UserName
        {
            get
            {
                return this["UserName"].ToString();
            }
        }

        [ConfigurationProperty("Password")]
        public string Password
        {
            get
            {
                return this["Password"].ToString();
            }
        }

        [ConfigurationProperty("Label")]
        public string Label
        {
            get
            {
                return this["Label"].ToString();
            }
        }
    }
}