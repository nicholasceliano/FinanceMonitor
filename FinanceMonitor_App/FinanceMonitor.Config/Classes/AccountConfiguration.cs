using System.Configuration;
using System.Web;
using System.Web.Configuration;

namespace FinanceMonitor.Config
{
    public class AccountConfiguration : ConfigurationSection
    {
        protected static AccountConfiguration _Current;
        protected global::System.Configuration.Configuration _Configuration;

        public static AccountConfiguration Current
        {
            get
            {
                if (AccountConfiguration._Current == null)
                {
                    global::System.Configuration.Configuration configuration = null;
                    //Get current web or exe application configuration
                    if (HttpContext.Current == null)
                        configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    else
                        configuration = WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
                    //Retrieve the application configuration section from the application configuration
                    if (configuration != null)
                        AccountConfiguration._Current = (AccountConfiguration)configuration.Sections["accountConfiguration"];
                    else
                        AccountConfiguration._Current = (AccountConfiguration)global::System.Configuration.ConfigurationManager.GetSection("accountConfiguration");
                    AccountConfiguration._Current._Configuration = configuration;
                }
                return AccountConfiguration._Current;
            }
        }

        #region Configuration Properies
        
        [ConfigurationProperty("SendGrid")]
        public SendGridSettings SendGrid
        {
            get { return (SendGridSettings)base["SendGrid"]; }
        }

        [ConfigurationProperty("HessBenefitsCenter")]
        public HessBenefitsCenterSettings HessBenefitsCenter
        {
            get { return (HessBenefitsCenterSettings)base["HessBenefitsCenter"]; }
        }

        [ConfigurationProperty("PayPal")]
        public PayPalSettings PayPal
        {
            get { return (PayPalSettings)base["PayPal"]; }
        }

        [ConfigurationProperty("TDAmeritrade")]
        public TDAmeritradeSettings TDAmeritrade
        {
            get { return (TDAmeritradeSettings)base["TDAmeritrade"]; }
        }

        [ConfigurationProperty("Plaid")]
        public PlaidSettings Plaid
        {
            get { return (PlaidSettings)base["Plaid"]; }
        }

        #endregion
    }

    public class SendGridSettings : ConfigurationElement
    {
        private SendGridSettings(){}

        [ConfigurationProperty("Username")]
        public string Username
        {
            get { return (string)this["Username"]; }
            set { this["Username"] = value; }
        }

        [ConfigurationProperty("Password")]
        public string Password
        {
            get { return (string)this["Password"]; }
            set { this["Password"] = value; }
        }
    }

    public class HessBenefitsCenterSettings : ConfigurationElement
    {
        private HessBenefitsCenterSettings() { }

        [ConfigurationProperty("BaseURI")]
        public string BaseURI
        {
            get { return (string)this["BaseURI"]; }
            set { this["BaseURI"] = value; }
        }

        [ConfigurationProperty("CompanyCode")]
        public int CompanyCode
        {
            get { return (int)this["CompanyCode"]; }
            set { this["CompanyCode"] = value; }
        }
    }

    public class PayPalSettings : ConfigurationElement
    {
        private PayPalSettings() { }

        [ConfigurationProperty("URL")]
        public string URL
        {
            get { return (string)this["URL"]; }
            set { this["URL"] = value; }
        }

        [ConfigurationProperty("VERSION")]
        public string VERSION
        {
            get { return (string)this["VERSION"]; }
            set { this["VERSION"] = value; }
        }

        [ConfigurationProperty("USER")]
        public string USER
        {
            get { return (string)this["USER"]; }
            set { this["USER"] = value; }
        }

        [ConfigurationProperty("PWD")]
        public string PWD
        {
            get { return (string)this["PWD"]; }
            set { this["PWD"] = value; }
        }

        [ConfigurationProperty("SIGNATURE")]
        public string SIGNATURE
        {
            get { return (string)this["SIGNATURE"]; }
            set { this["SIGNATURE"] = value; }
        }
    }

    public class TDAmeritradeSettings : ConfigurationElement
    {
        private TDAmeritradeSettings() { }

        [ConfigurationProperty("BaseURI")]
        public string BaseURI
        {
            get { return (string)this["BaseURI"]; }
            set { this["BaseURI"] = value; }
        }

        [ConfigurationProperty("Question1")]
        public string Question1
        {
            get { return (string)this["Question1"]; }
            set { this["Question1"] = value; }
        }

        [ConfigurationProperty("Answer1")]
        public string Answer1
        {
            get { return (string)this["Answer1"]; }
            set { this["Answer1"] = value; }
        }

        [ConfigurationProperty("Question2")]
        public string Question2
        {
            get { return (string)this["Question2"]; }
            set { this["Question2"] = value; }
        }

        [ConfigurationProperty("Answer2")]
        public string Answer2
        {
            get { return (string)this["Answer2"]; }
            set { this["Answer2"] = value; }
        }

        [ConfigurationProperty("Question3")]
        public string Question3
        {
            get { return (string)this["Question3"]; }
            set { this["Question3"] = value; }
        }

        [ConfigurationProperty("Answer3")]
        public string Answer3
        {
            get { return (string)this["Answer3"]; }
            set { this["Answer3"] = value; }
        }

        [ConfigurationProperty("Question4")]
        public string Question4
        {
            get { return (string)this["Question4"]; }
            set { this["Question4"] = value; }
        }

        [ConfigurationProperty("Answer4")]
        public string Answer4
        {
            get { return (string)this["Answer4"]; }
            set { this["Answer4"] = value; }
        }
    }

    public class PlaidSettings : ConfigurationElement
    {
        private PlaidSettings() { }

        [ConfigurationProperty("BaseURI")]
        public string BaseURI
        {
            get { return (string)this["BaseURI"]; }
            set { this["BaseURI"] = value; }
        }

        [ConfigurationProperty("CLIENTID")]
        public string CLIENTID
        {
            get { return (string)this["CLIENTID"]; }
            set { this["CLIENTID"] = value; }
        }

        [ConfigurationProperty("SECRET")]
        public string SECRET
        {
            get { return (string)this["SECRET"]; }
            set { this["SECRET"] = value; }
        }
    }
}
