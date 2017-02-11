using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account 
{

    public class CreateCallOptions : IOptions<CallResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// Phone number, SIP address or client identifier to call
        /// </summary>
        public IEndpoint To { get; }
        /// <summary>
        /// Twilio number from which to originate the call
        /// </summary>
        public Types.PhoneNumber From { get; }
        /// <summary>
        /// Url from which to fetch TwiML
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// ApplicationSid that configures from where to fetch TwiML
        /// </summary>
        public string ApplicationSid { get; set; }
        /// <summary>
        /// HTTP method to use to fetch TwiML
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Fallback URL in case of error
        /// </summary>
        public Uri FallbackUrl { get; set; }
        /// <summary>
        /// HTTP Method to use with FallbackUrl
        /// </summary>
        public Twilio.Http.HttpMethod FallbackMethod { get; set; }
        /// <summary>
        /// Status Callback URL
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The status_callback_event
        /// </summary>
        public List<string> StatusCallbackEvent { get; set; }
        /// <summary>
        /// HTTP Method to use with StatusCallback
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// Digits to send
        /// </summary>
        public string SendDigits { get; set; }
        /// <summary>
        /// Action to take if a machine has answered the call
        /// </summary>
        public string IfMachine { get; set; }
        /// <summary>
        /// Number of seconds to wait for an answer
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// Whether or not to record the Call
        /// </summary>
        public bool? Record { get; set; }
        /// <summary>
        /// The recording_channels
        /// </summary>
        public string RecordingChannels { get; set; }
        /// <summary>
        /// The recording_status_callback
        /// </summary>
        public string RecordingStatusCallback { get; set; }
        /// <summary>
        /// The recording_status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod RecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// The sip_auth_username
        /// </summary>
        public string SipAuthUsername { get; set; }
        /// <summary>
        /// The sip_auth_password
        /// </summary>
        public string SipAuthPassword { get; set; }
    
        /// <summary>
        /// Construct a new CreateCallOptions
        /// </summary>
        ///
        /// <param name="to"> Phone number, SIP address or client identifier to call </param>
        /// <param name="from"> Twilio number from which to originate the call </param>
        public CreateCallOptions(IEndpoint to, Types.PhoneNumber from)
        {
            To = to;
            From = from;
            StatusCallbackEvent = new List<string>();
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }
            
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }
            
            if (Url != null)
            {
                p.Add(new KeyValuePair<string, string>("Url", Url.ToString()));
            }
            
            if (ApplicationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ApplicationSid", ApplicationSid.ToString()));
            }
            
            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method.ToString()));
            }
            
            if (FallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackUrl", FallbackUrl.ToString()));
            }
            
            if (FallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackMethod", FallbackMethod.ToString()));
            }
            
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", StatusCallback.ToString()));
            }
            
            if (StatusCallbackEvent != null)
            {
                p.AddRange(StatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("StatusCallbackEvent", prop)));
            }
            
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            
            if (SendDigits != null)
            {
                p.Add(new KeyValuePair<string, string>("SendDigits", SendDigits));
            }
            
            if (IfMachine != null)
            {
                p.Add(new KeyValuePair<string, string>("IfMachine", IfMachine));
            }
            
            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.Value.ToString()));
            }
            
            if (Record != null)
            {
                p.Add(new KeyValuePair<string, string>("Record", Record.Value.ToString()));
            }
            
            if (RecordingChannels != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingChannels", RecordingChannels));
            }
            
            if (RecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallback", RecordingStatusCallback));
            }
            
            if (RecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallbackMethod", RecordingStatusCallbackMethod.ToString()));
            }
            
            if (SipAuthUsername != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthUsername", SipAuthUsername));
            }
            
            if (SipAuthPassword != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthPassword", SipAuthPassword));
            }
            
            return p;
        }
    }

    public class DeleteCallOptions : IOptions<CallResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// Call Sid that uniquely identifies the Call to delete
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new DeleteCallOptions
        /// </summary>
        ///
        /// <param name="sid"> Call Sid that uniquely identifies the Call to delete </param>
        public DeleteCallOptions(string sid)
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

    public class FetchCallOptions : IOptions<CallResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// Call Sid that uniquely identifies the Call to fetch
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchCallOptions
        /// </summary>
        ///
        /// <param name="sid"> Call Sid that uniquely identifies the Call to fetch </param>
        public FetchCallOptions(string sid)
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

    public class ReadCallOptions : ReadOptions<CallResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// Phone number or Client identifier to filter `to` on
        /// </summary>
        public Types.PhoneNumber To { get; set; }
        /// <summary>
        /// Phone number or Client identifier to filter `from` on
        /// </summary>
        public Types.PhoneNumber From { get; set; }
        /// <summary>
        /// Parent Call Sid to filter on
        /// </summary>
        public string ParentCallSid { get; set; }
        /// <summary>
        /// Status to filter on
        /// </summary>
        public CallResource.StatusEnum Status { get; set; }
        /// <summary>
        /// StartTime to filter on
        /// </summary>
        public DateTime? StartTimeBefore { get; set; }
        /// <summary>
        /// StartTime to filter on
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// StartTime to filter on
        /// </summary>
        public DateTime? StartTimeAfter { get; set; }
        /// <summary>
        /// EndTime to filter on
        /// </summary>
        public DateTime? EndTimeBefore { get; set; }
        /// <summary>
        /// EndTime to filter on
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// EndTime to filter on
        /// </summary>
        public DateTime? EndTimeAfter { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }
            
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }
            
            if (ParentCallSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ParentCallSid", ParentCallSid.ToString()));
            }
            
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            
            if (StartTime != null)
            {
                p.Add(new KeyValuePair<string, string>("StartTime", StartTime.ToString()));
            }
            else
            {
                if (StartTimeBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("StartTime<", StartTimeBefore.ToString()));
                }
            
                if (StartTimeAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("StartTime>", StartTimeAfter.ToString()));
                }
            }
            
            if (EndTime != null)
            {
                p.Add(new KeyValuePair<string, string>("EndTime", EndTime.ToString()));
            }
            else
            {
                if (EndTimeBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("EndTime<", EndTimeBefore.ToString()));
                }
            
                if (EndTimeAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("EndTime>", EndTimeAfter.ToString()));
                }
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    public class UpdateCallOptions : IOptions<CallResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// Call Sid that uniquely identifies the Call to update
        /// </summary>
        public string Sid { get; }
        /// <summary>
        /// URL that returns TwiML
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// HTTP method to use to fetch TwiML
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Status to update the Call with
        /// </summary>
        public CallResource.UpdateStatusEnum Status { get; set; }
        /// <summary>
        /// Fallback URL in case of error
        /// </summary>
        public Uri FallbackUrl { get; set; }
        /// <summary>
        /// HTTP Method to use with FallbackUrl
        /// </summary>
        public Twilio.Http.HttpMethod FallbackMethod { get; set; }
        /// <summary>
        /// Status Callback URL
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// HTTP Method to use with StatusCallback
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
    
        /// <summary>
        /// Construct a new UpdateCallOptions
        /// </summary>
        ///
        /// <param name="sid"> Call Sid that uniquely identifies the Call to update </param>
        public UpdateCallOptions(string sid)
        {
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Url != null)
            {
                p.Add(new KeyValuePair<string, string>("Url", Url.ToString()));
            }
            
            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method.ToString()));
            }
            
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            
            if (FallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackUrl", FallbackUrl.ToString()));
            }
            
            if (FallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackMethod", FallbackMethod.ToString()));
            }
            
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", StatusCallback.ToString()));
            }
            
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            
            return p;
        }
    }

}