using Twilio.Types;

namespace Twilio.Rest 
{

    public sealed class Domain : StringEnum 
    {
        private Domain(string value) : base(value) {}
        public Domain() {}
    
        public static readonly Domain Accounts = new Domain("accounts");
        public static readonly Domain Api = new Domain("api");
        public static readonly Domain Chat = new Domain("ip-messaging");
        public static readonly Domain IpMessaging = new Domain("ip-messaging");
        public static readonly Domain Lookups = new Domain("lookups");
        public static readonly Domain Monitor = new Domain("monitor");
        public static readonly Domain Notify = new Domain("notify");
        public static readonly Domain Preview = new Domain("preview");
        public static readonly Domain Pricing = new Domain("pricing");
        public static readonly Domain Taskrouter = new Domain("taskrouter");
        public static readonly Domain Trunking = new Domain("trunking");
    }

}