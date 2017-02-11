using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account 
{

    public class CreateApplicationOptions : IOptions<ApplicationResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// Human readable description of this resource
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The API version to use
        /// </summary>
        public string ApiVersion { get; set; }
        /// <summary>
        /// URL Twilio will make requests to when relieving a call
        /// </summary>
        public Uri VoiceUrl { get; set; }
        /// <summary>
        /// HTTP method to use with the URL
        /// </summary>
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }
        /// <summary>
        /// Fallback URL
        /// </summary>
        public Uri VoiceFallbackUrl { get; set; }
        /// <summary>
        /// HTTP method to use with the fallback url
        /// </summary>
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }
        /// <summary>
        /// URL to hit with status updates
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// HTTP method to use with the status callback
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// True or False
        /// </summary>
        public bool? VoiceCallerIdLookup { get; set; }
        /// <summary>
        /// URL Twilio will request when receiving an SMS
        /// </summary>
        public Uri SmsUrl { get; set; }
        /// <summary>
        /// HTTP method to use with sms_url
        /// </summary>
        public Twilio.Http.HttpMethod SmsMethod { get; set; }
        /// <summary>
        /// Fallback URL if there's an error parsing TwiML
        /// </summary>
        public Uri SmsFallbackUrl { get; set; }
        /// <summary>
        /// HTTP method to use with sms_fallback_method
        /// </summary>
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; set; }
        /// <summary>
        /// URL Twilio with request with status updates
        /// </summary>
        public Uri SmsStatusCallback { get; set; }
        /// <summary>
        /// URL to make requests to with status updates
        /// </summary>
        public Uri MessageStatusCallback { get; set; }
    
        /// <summary>
        /// Construct a new CreateApplicationOptions
        /// </summary>
        ///
        /// <param name="friendlyName"> Human readable description of this resource </param>
        public CreateApplicationOptions(string friendlyName)
        {
            FriendlyName = friendlyName;
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
            
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", StatusCallback.ToString()));
            }
            
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            
            if (VoiceCallerIdLookup != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceCallerIdLookup", VoiceCallerIdLookup.Value.ToString()));
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
            
            if (SmsStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsStatusCallback", SmsStatusCallback.ToString()));
            }
            
            if (MessageStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("MessageStatusCallback", MessageStatusCallback.ToString()));
            }
            
            return p;
        }
    }

    public class DeleteApplicationOptions : IOptions<ApplicationResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// The application sid to delete
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new DeleteApplicationOptions
        /// </summary>
        ///
        /// <param name="sid"> The application sid to delete </param>
        public DeleteApplicationOptions(string sid)
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

    public class FetchApplicationOptions : IOptions<ApplicationResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// Fetch by unique Application Sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchApplicationOptions
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique Application Sid </param>
        public FetchApplicationOptions(string sid)
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

    public class ReadApplicationOptions : ReadOptions<ApplicationResource> 
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
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    public class UpdateApplicationOptions : IOptions<ApplicationResource> 
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
        /// Human readable description of this resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The API version to use
        /// </summary>
        public string ApiVersion { get; set; }
        /// <summary>
        /// URL Twilio will make requests to when relieving a call
        /// </summary>
        public Uri VoiceUrl { get; set; }
        /// <summary>
        /// HTTP method to use with the URL
        /// </summary>
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }
        /// <summary>
        /// Fallback URL
        /// </summary>
        public Uri VoiceFallbackUrl { get; set; }
        /// <summary>
        /// HTTP method to use with the fallback url
        /// </summary>
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }
        /// <summary>
        /// URL to hit with status updates
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// HTTP method to use with the status callback
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// True or False
        /// </summary>
        public bool? VoiceCallerIdLookup { get; set; }
        /// <summary>
        /// URL Twilio will request when receiving an SMS
        /// </summary>
        public Uri SmsUrl { get; set; }
        /// <summary>
        /// HTTP method to use with sms_url
        /// </summary>
        public Twilio.Http.HttpMethod SmsMethod { get; set; }
        /// <summary>
        /// Fallback URL if there's an error parsing TwiML
        /// </summary>
        public Uri SmsFallbackUrl { get; set; }
        /// <summary>
        /// HTTP method to use with sms_fallback_method
        /// </summary>
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; set; }
        /// <summary>
        /// URL Twilio with request with status updates
        /// </summary>
        public Uri SmsStatusCallback { get; set; }
        /// <summary>
        /// URL to make requests to with status updates
        /// </summary>
        public Uri MessageStatusCallback { get; set; }
    
        /// <summary>
        /// Construct a new UpdateApplicationOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public UpdateApplicationOptions(string sid)
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
            
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", StatusCallback.ToString()));
            }
            
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            
            if (VoiceCallerIdLookup != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceCallerIdLookup", VoiceCallerIdLookup.Value.ToString()));
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
            
            if (SmsStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsStatusCallback", SmsStatusCallback.ToString()));
            }
            
            if (MessageStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("MessageStatusCallback", MessageStatusCallback.ToString()));
            }
            
            return p;
        }
    }

}