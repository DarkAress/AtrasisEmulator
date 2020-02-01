namespace Supercell.Magic.Logic.Data
{
    using Supercell.Magic.Titan.CSV;

    public class LogicClientGlobals : LogicDataTable
    {
        private string m_feedbackEmail;
        private string m_feedbackEmailAndroid;
        private string m_gameFacebookUrl;
        private string m_gameWeiboUrl;
        private string m_gameAppbankUrl;
        private string m_gameExternalUrl;
        private string m_gameTwitterUrl;
        private string m_gameTwitterUrlJp;
        private string m_tosUrl;
        private string m_privacyLolicyUrlJp;
        private string m_tosUrlJp;
        private string m_privacyPolicyUrlKr;
        private string m_tosUrlKr;
        private string m_helpcenterContact;
        private string m_faqUrl;
        private string m_forumsUrl;
        private string m_privacyPolicyUrl;

        private bool m_pepperEnabled;
        private bool m_powerSaveModeLessEndTurnMessages;

        public LogicClientGlobals(CSVTable table, LogicDataType index) : base(table, index)
        {
        }

        public override void CreateReferences()
        {
            base.CreateReferences();

            this.m_feedbackEmail = this.GetStrValue("FEEDBACK_EMAIL");
            this.m_feedbackEmailAndroid = this.GetStrValue("FEEDBACK_EMAIL_ANDROID");
            this.m_gameFacebookUrl = this.GetStrValue("GAME_FACEBOOK_URL");
            this.m_gameWeiboUrl = this.GetStrValue("GAME_WEIBO_URL");
            this.m_gameAppbankUrl = this.GetStrValue("GAME_APPBANK_URL");
            this.m_gameExternalUrl = this.GetStrValue("GAME_EXTERNAL_URL");
            this.m_gameTwitterUrl = this.GetStrValue("GAME_TWITTER_URL");
            this.m_gameTwitterUrlJp = this.GetStrValue("GAME_TWITTER_URL_JP");
            this.m_tosUrl = this.GetStrValue("TOS_URL");
            this.m_privacyLolicyUrlJp = this.GetStrValue("PRIVACY_POLICY_URL_JP");
            this.m_tosUrlJp = this.GetStrValue("TOS_URL_JP");
            this.m_privacyPolicyUrlKr = this.GetStrValue("PRIVACY_POLICY_URL_KR");
            this.m_tosUrlKr = this.GetStrValue("TOS_URL_KR");
            this.m_helpcenterContact = this.GetStrValue("HELPCENTER_CONTACT");
            this.m_faqUrl = this.GetStrValue("FAQ_URL");
            this.m_forumsUrl = this.GetStrValue("FORUMS_URL");
            this.m_privacyPolicyUrl = this.GetStrValue("PRIVACY_POLICY_URL");

            this.m_pepperEnabled = this.GetBoolValue("USE_PEPPER_CRYPTO");
            this.m_powerSaveModeLessEndTurnMessages = this.GetBoolValue("POWER_SAVE_MODE_LESS_ENDTURN_MESSAGES");
        }

        private LogicGlobalData GetGlobalData(string name)
        {
            return LogicDataTables.GetClientGlobalByName(name, null);
        }

        private string GetStrValue(string name)
        {
           return this.GetGlobalData(name).GetGetTextValue();
        }

        private bool GetBoolValue(string name)
        {
            return this.GetGlobalData(name).GetBooleanValue();
        }

        private int GetIntValue(string name)
        {
            return this.GetGlobalData(name).GetNumberValue();
        }

        public string FeedbackEmail()
        {
            return this.m_feedbackEmail;
        }

        public string FeedbackEmailAndroid()
        {
            return this.m_feedbackEmailAndroid;
        }

        public string GameFacebookUrl()
        {
            return this.m_gameFacebookUrl;
        }

        public string GameWeiboUrl()
        {
            return this.m_gameWeiboUrl;
        }

        public string GameAppbankUrl()
        {
            return this.m_gameAppbankUrl;
        }

        public string GameExternalUrl()
        {
            return this.m_gameExternalUrl;
        }

        public string GameTwitterUrl()
        {
            return this.m_gameTwitterUrl;
        }

        public string GameTwitterUrlJp()
        {
            return this.m_gameTwitterUrlJp;
        }

        public string TosUrl()
        {
            return this.m_tosUrl;
        }

        public string PrivacyLolicyUrlJp()
        {
            return this.m_privacyLolicyUrlJp;
        }

        public string TosUrlJp()
        {
            return this.m_tosUrlJp;
        }

        public string PrivacyPolicyUrlKr()
        {
            return this.m_privacyPolicyUrlKr;
        }

        public string TosUrlKr()
        {
            return this.m_tosUrlKr;
        }

        public string HelpcenterContact()
        {
            return this.m_helpcenterContact;
        }

        public string FaqUrl()
        {
            return this.m_faqUrl;
        }

        public string ForumsUrl()
        {
            return this.m_forumsUrl;
        }

        public string PrivacyPolicyUrl()
        {
            return this.m_privacyPolicyUrl;
        }

        public bool PepperEnabled()
        {
            return this.m_pepperEnabled;
        }

        public bool PowerSaveModeLessEndTurnMessages()
        {
            return this.m_powerSaveModeLessEndTurnMessages;
        }
    }
}
