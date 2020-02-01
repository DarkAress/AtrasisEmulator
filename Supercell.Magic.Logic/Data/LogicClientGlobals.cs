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
        private string m_feedbackCategoryBanned;

        private int m_appRateXpLevel;
        private int m_comeBackNotificationDelayHoursSmall;
        private int m_comeBackNotificationDelayHoursMedium;
        private int m_comeBackNotificationDelayHoursLarge;
        private int m_ashCnt;
        private int m_ashCntlow;
        private int m_ashCntCombat;

        private bool m_gamecenterReauthorize;
        private bool m_billingPackNamesFromCsv;
        private bool m_droidSansFallbackOnLowMemDevices;
        private bool m_googleServiceAchievementsButton;
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
            this.m_feedbackCategoryBanned = this.GetStrValue("FEEDBACK_CATEGORY_BANNED");

            this.m_appRateXpLevel = this.GetIntValue("APP_RATE_XP_LEVEL");
            this.m_comeBackNotificationDelayHoursSmall = 3600 * this.GetIntValue("COME_BACK_NOTIFICATION_DELAY_HOURS_SMALL");
            this.m_comeBackNotificationDelayHoursMedium = 3600 * this.GetIntValue("COME_BACK_NOTIFICATION_DELAY_HOURS_MEDIUM");
            this.m_comeBackNotificationDelayHoursLarge = 3600 * this.GetIntValue("COME_BACK_NOTIFICATION_DELAY_HOURS_LARGE");
            this.m_ashCnt = this.GetIntValue("ASH_CNT");
            this.m_ashCntLow = this.GetIntValue("ASH_CNT_LOW");
            this.m_ashCntCombat = this.GetIntValue("ASH_CNT_COMBAT");

            this.m_gamecenterReauthorize = this.GetBoolValue("GAMECENTER_REAUTHORIZE");
            this.m_billingPackNamesFromCsv = this.GetBoolValue("BILLING_PACK_NAMES_FROM_CSV");
            this.m_droidSansFallbackOnLowMemDevices = this.GetBoolValue("DROID_SANS_FALLBACK_ON_LOW_MEM_DEVICES");
            this.m_googleServiceAchievementsButton = this.GetBoolValue("GOOGLE_SERVICE_ACHIEVEMENTS_BUTTON");
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

        public string FeedbackCategoryBanned()
        {
            return this.m_feedbackCategoryBanned;
        }

        public int AppRateXpLevel()
        {
            return this.m_appRateXpLevel;
        }

        public int ComeBackNotificationDelayHoursSmall()
        {
             return this.m_comeBackNotificationDelayHoursSmall;
        }

        public int ComeBackNotificationDelayHoursMedium()
        {
             return this.m_comeBackNotificationDelayHoursMedium;
        }

        public int ComeBackNotificationDelayHoursLarge()
        {
             return this.m_comeBackNotificationDelayHoursLarge;
        }

        public int AshCnt()
        {
             return this.m_ashCnt;
        }

        public int AshCntlow()
        {
             return this.m_ashCntlow;
        }

        public int AshCntCombat()
        {
             return this.m_ashCntCombat;
        }

        public bool GamecenterReauthorize()
        {
             return this.m_gamecenterReauthorize;
        }

        public bool BillingPackNamesFromCsv()
        {
             return this.m_billingPackNamesFromCsv;
        }

        public bool DroidSansFallbackOnLowMemDevices()
        {
            return this.m_droidSansFallbackOnLowMemDevices;
        }

        public bool GoogleServiceAchievementsButton()
        {
            return this.m_googleServiceAchievementsButton;
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
