using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Notify.V1 
{

    public class CreateServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The apn_credential_sid
        /// </summary>
        public string ApnCredentialSid { get; set; }
        /// <summary>
        /// The gcm_credential_sid
        /// </summary>
        public string GcmCredentialSid { get; set; }
        /// <summary>
        /// The messaging_service_sid
        /// </summary>
        public string MessagingServiceSid { get; set; }
        /// <summary>
        /// The facebook_messenger_page_id
        /// </summary>
        public string FacebookMessengerPageId { get; set; }
        /// <summary>
        /// The default_apn_notification_protocol_version
        /// </summary>
        public string DefaultApnNotificationProtocolVersion { get; set; }
        /// <summary>
        /// The default_gcm_notification_protocol_version
        /// </summary>
        public string DefaultGcmNotificationProtocolVersion { get; set; }
        /// <summary>
        /// The fcm_credential_sid
        /// </summary>
        public string FcmCredentialSid { get; set; }
        /// <summary>
        /// The default_fcm_notification_protocol_version
        /// </summary>
        public string DefaultFcmNotificationProtocolVersion { get; set; }
    
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
            
            if (ApnCredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ApnCredentialSid", ApnCredentialSid.ToString()));
            }
            
            if (GcmCredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("GcmCredentialSid", GcmCredentialSid.ToString()));
            }
            
            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid.ToString()));
            }
            
            if (FacebookMessengerPageId != null)
            {
                p.Add(new KeyValuePair<string, string>("FacebookMessengerPageId", FacebookMessengerPageId));
            }
            
            if (DefaultApnNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultApnNotificationProtocolVersion", DefaultApnNotificationProtocolVersion));
            }
            
            if (DefaultGcmNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultGcmNotificationProtocolVersion", DefaultGcmNotificationProtocolVersion));
            }
            
            if (FcmCredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("FcmCredentialSid", FcmCredentialSid.ToString()));
            }
            
            if (DefaultFcmNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultFcmNotificationProtocolVersion", DefaultFcmNotificationProtocolVersion));
            }
            
            return p;
        }
    }

    public class DeleteServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new DeleteServiceOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public DeleteServiceOptions(string sid)
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

    public class FetchServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchServiceOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public FetchServiceOptions(string sid)
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

    public class ReadServiceOptions : ReadOptions<ServiceResource> 
    {
        /// <summary>
        /// The friendly_name
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

    public class UpdateServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The apn_credential_sid
        /// </summary>
        public string ApnCredentialSid { get; set; }
        /// <summary>
        /// The gcm_credential_sid
        /// </summary>
        public string GcmCredentialSid { get; set; }
        /// <summary>
        /// The messaging_service_sid
        /// </summary>
        public string MessagingServiceSid { get; set; }
        /// <summary>
        /// The facebook_messenger_page_id
        /// </summary>
        public string FacebookMessengerPageId { get; set; }
        /// <summary>
        /// The default_apn_notification_protocol_version
        /// </summary>
        public string DefaultApnNotificationProtocolVersion { get; set; }
        /// <summary>
        /// The default_gcm_notification_protocol_version
        /// </summary>
        public string DefaultGcmNotificationProtocolVersion { get; set; }
        /// <summary>
        /// The fcm_credential_sid
        /// </summary>
        public string FcmCredentialSid { get; set; }
        /// <summary>
        /// The default_fcm_notification_protocol_version
        /// </summary>
        public string DefaultFcmNotificationProtocolVersion { get; set; }
    
        /// <summary>
        /// Construct a new UpdateServiceOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public UpdateServiceOptions(string sid)
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
            
            if (ApnCredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ApnCredentialSid", ApnCredentialSid.ToString()));
            }
            
            if (GcmCredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("GcmCredentialSid", GcmCredentialSid.ToString()));
            }
            
            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid.ToString()));
            }
            
            if (FacebookMessengerPageId != null)
            {
                p.Add(new KeyValuePair<string, string>("FacebookMessengerPageId", FacebookMessengerPageId));
            }
            
            if (DefaultApnNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultApnNotificationProtocolVersion", DefaultApnNotificationProtocolVersion));
            }
            
            if (DefaultGcmNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultGcmNotificationProtocolVersion", DefaultGcmNotificationProtocolVersion));
            }
            
            if (FcmCredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("FcmCredentialSid", FcmCredentialSid.ToString()));
            }
            
            if (DefaultFcmNotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultFcmNotificationProtocolVersion", DefaultFcmNotificationProtocolVersion));
            }
            
            return p;
        }
    }

}