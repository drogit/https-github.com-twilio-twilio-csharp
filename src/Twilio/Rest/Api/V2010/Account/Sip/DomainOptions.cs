using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account.Sip 
{

    public class ReadDomainOptions : ReadOptions<DomainResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    public class CreateDomainOptions : IOptions<DomainResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// The unique address on Twilio to route SIP traffic
        /// </summary>
        public string DomainName { get; }
        /// <summary>
        /// A user-specified, human-readable name for the trigger.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The types of authentication mapped to the domain
        /// </summary>
        public string AuthType { get; set; }
        /// <summary>
        /// URL Twilio will request when receiving a call
        /// </summary>
        public Uri VoiceUrl { get; set; }
        /// <summary>
        /// HTTP method to use with voice_url
        /// </summary>
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }
        /// <summary>
        /// URL Twilio will request if an error occurs in executing TwiML
        /// </summary>
        public Uri VoiceFallbackUrl { get; set; }
        /// <summary>
        /// HTTP method used with voice_fallback_url
        /// </summary>
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }
        /// <summary>
        /// URL that Twilio will request with status updates
        /// </summary>
        public Uri VoiceStatusCallbackUrl { get; set; }
        /// <summary>
        /// The voice_status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod VoiceStatusCallbackMethod { get; set; }
    
        /// <summary>
        /// Construct a new CreateDomainOptions
        /// </summary>
        ///
        /// <param name="domainName"> The unique address on Twilio to route SIP traffic </param>
        public CreateDomainOptions(string domainName)
        {
            DomainName = domainName;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DomainName != null)
            {
                p.Add(new KeyValuePair<string, string>("DomainName", DomainName));
            }
            
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (AuthType != null)
            {
                p.Add(new KeyValuePair<string, string>("AuthType", AuthType));
            }
            
            if (VoiceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceUrl", VoiceUrl.ToString()));
            }
            
            if (VoiceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceMethod", VoiceMethod.ToString()));
            }
            
            if (VoiceFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackUrl", VoiceFallbackUrl.ToString()));
            }
            
            if (VoiceFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackMethod", VoiceFallbackMethod.ToString()));
            }
            
            if (VoiceStatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceStatusCallbackUrl", VoiceStatusCallbackUrl.ToString()));
            }
            
            if (VoiceStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceStatusCallbackMethod", VoiceStatusCallbackMethod.ToString()));
            }
            
            return p;
        }
    }

    public class FetchDomainOptions : IOptions<DomainResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// Fetch by unique Domain Sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchDomainOptions
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique Domain Sid </param>
        public FetchDomainOptions(string sid)
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

    public class UpdateDomainOptions : IOptions<DomainResource> 
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
        /// The auth_type
        /// </summary>
        public string AuthType { get; set; }
        /// <summary>
        /// A user-specified, human-readable name for the trigger.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The voice_fallback_method
        /// </summary>
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }
        /// <summary>
        /// The voice_fallback_url
        /// </summary>
        public Uri VoiceFallbackUrl { get; set; }
        /// <summary>
        /// HTTP method to use with voice_url
        /// </summary>
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }
        /// <summary>
        /// The voice_status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod VoiceStatusCallbackMethod { get; set; }
        /// <summary>
        /// The voice_status_callback_url
        /// </summary>
        public Uri VoiceStatusCallbackUrl { get; set; }
        /// <summary>
        /// The voice_url
        /// </summary>
        public Uri VoiceUrl { get; set; }
    
        /// <summary>
        /// Construct a new UpdateDomainOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public UpdateDomainOptions(string sid)
        {
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (AuthType != null)
            {
                p.Add(new KeyValuePair<string, string>("AuthType", AuthType));
            }
            
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (VoiceFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackMethod", VoiceFallbackMethod.ToString()));
            }
            
            if (VoiceFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackUrl", VoiceFallbackUrl.ToString()));
            }
            
            if (VoiceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceMethod", VoiceMethod.ToString()));
            }
            
            if (VoiceStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceStatusCallbackMethod", VoiceStatusCallbackMethod.ToString()));
            }
            
            if (VoiceStatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceStatusCallbackUrl", VoiceStatusCallbackUrl.ToString()));
            }
            
            if (VoiceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceUrl", VoiceUrl.ToString()));
            }
            
            return p;
        }
    }

    public class DeleteDomainOptions : IOptions<DomainResource> 
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
        /// Construct a new DeleteDomainOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public DeleteDomainOptions(string sid)
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

}