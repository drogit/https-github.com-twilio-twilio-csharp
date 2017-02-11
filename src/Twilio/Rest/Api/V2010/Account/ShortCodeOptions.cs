using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account 
{

    public class FetchShortCodeOptions : IOptions<ShortCodeResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// Fetch by unique short-code Sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchShortCodeOptions
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique short-code Sid </param>
        public FetchShortCodeOptions(string sid)
        {
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    public class UpdateShortCodeOptions : IOptions<ShortCodeResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The API version to use
        /// </summary>
        public string ApiVersion { get; set; }
        /// <summary>
        /// URL Twilio will request when receiving an SMS
        /// </summary>
        public Uri SmsUrl { get; set; }
        /// <summary>
        /// HTTP method to use when requesting the sms url
        /// </summary>
        public Twilio.Http.HttpMethod SmsMethod { get; set; }
        /// <summary>
        /// URL Twilio will request if an error occurs in executing TwiML
        /// </summary>
        public Uri SmsFallbackUrl { get; set; }
        /// <summary>
        /// HTTP method Twilio will use with sms fallback url
        /// </summary>
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; set; }
    
        /// <summary>
        /// Construct a new UpdateShortCodeOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public UpdateShortCodeOptions(string sid)
        {
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (ApiVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("ApiVersion", ApiVersion));
            }
            
            if (SmsUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsUrl", SmsUrl.ToString()));
            }
            
            if (SmsMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsMethod", SmsMethod.ToString()));
            }
            
            if (SmsFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackUrl", SmsFallbackUrl.ToString()));
            }
            
            if (SmsFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackMethod", SmsFallbackMethod.ToString()));
            }
            
            return p;
        }
    }

    public class ReadShortCodeOptions : ReadOptions<ShortCodeResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// Filter by friendly name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Filter by ShortCode
        /// </summary>
        public string ShortCode { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (ShortCode != null)
            {
                p.Add(new KeyValuePair<string, string>("ShortCode", ShortCode));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

}