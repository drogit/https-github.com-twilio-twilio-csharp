/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Twilio.Converters;
using Twilio.Types;

namespace Twilio.TwiML.Voice
{

    /// <summary>
    /// Sip TwiML Noun
    /// </summary>
    public class Sip : TwiML
    {
        public sealed class EventEnum : StringEnum
        {
            private EventEnum(string value) : base(value) {}
            public EventEnum() {}
            public static implicit operator EventEnum(string value)
            {
                return new EventEnum(value);
            }

            public static readonly EventEnum Initiated = new EventEnum("initiated");
            public static readonly EventEnum Ringing = new EventEnum("ringing");
            public static readonly EventEnum Answered = new EventEnum("answered");
            public static readonly EventEnum Completed = new EventEnum("completed");
        }

        /// <summary>
        /// SIP URL
        /// </summary>
        public Uri SipUrl { get; set; }
        /// <summary>
        /// SIP Username
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// SIP Password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Action URL
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// Action URL method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Status callback events
        /// </summary>
        public IEnumerable<Sip.EventEnum> StatusCallbackEvent { get; set; }
        /// <summary>
        /// Status callback URL
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// Status callback URL method
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// Enable machine detection or end of greeting detection
        /// </summary>
        public string MachineDetection { get; set; }
        /// <summary>
        /// HTTP Method to use with amd_status_callback
        /// </summary>
        public Twilio.Http.HttpMethod AmdStatusCallbackMethod { get; set; }
        /// <summary>
        /// The URL we should call to send amd status information to your application
        /// </summary>
        public string AmdStatusCallback { get; set; }
        /// <summary>
        /// Number of seconds to wait for machine detection
        /// </summary>
        public int? MachineDetectionTimeout { get; set; }
        /// <summary>
        /// Number of milliseconds for measuring stick for the length of the speech activity
        /// </summary>
        public int? MachineDetectionSpeechThreshold { get; set; }
        /// <summary>
        /// Number of milliseconds of silence after speech activity
        /// </summary>
        public int? MachineDetectionSpeechEndThreshold { get; set; }
        /// <summary>
        /// Number of milliseconds of initial silence
        /// </summary>
        public int? MachineDetectionSilenceTimeout { get; set; }

        /// <summary>
        /// Create a new Sip
        /// </summary>
        /// <param name="sipUrl"> SIP URL, the body of the TwiML Element. </param>
        /// <param name="username"> SIP Username </param>
        /// <param name="password"> SIP Password </param>
        /// <param name="url"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        /// <param name="statusCallbackEvent"> Status callback events </param>
        /// <param name="statusCallback"> Status callback URL </param>
        /// <param name="statusCallbackMethod"> Status callback URL method </param>
        /// <param name="machineDetection"> Enable machine detection or end of greeting detection </param>
        /// <param name="amdStatusCallbackMethod"> HTTP Method to use with amd_status_callback </param>
        /// <param name="amdStatusCallback"> The URL we should call to send amd status information to your application </param>
        /// <param name="machineDetectionTimeout"> Number of seconds to wait for machine detection </param>
        /// <param name="machineDetectionSpeechThreshold"> Number of milliseconds for measuring stick for the length of the
        ///                                       speech activity </param>
        /// <param name="machineDetectionSpeechEndThreshold"> Number of milliseconds of silence after speech activity </param>
        /// <param name="machineDetectionSilenceTimeout"> Number of milliseconds of initial silence </param>
        public Sip(Uri sipUrl = null,
                   string username = null,
                   string password = null,
                   Uri url = null,
                   Twilio.Http.HttpMethod method = null,
                   IEnumerable<Sip.EventEnum> statusCallbackEvent = null,
                   Uri statusCallback = null,
                   Twilio.Http.HttpMethod statusCallbackMethod = null,
                   string machineDetection = null,
                   Twilio.Http.HttpMethod amdStatusCallbackMethod = null,
                   string amdStatusCallback = null,
                   int? machineDetectionTimeout = null,
                   int? machineDetectionSpeechThreshold = null,
                   int? machineDetectionSpeechEndThreshold = null,
                   int? machineDetectionSilenceTimeout = null) : base("Sip")
        {
            this.SipUrl = sipUrl;
            this.Username = username;
            this.Password = password;
            this.Url = url;
            this.Method = method;
            this.StatusCallbackEvent = statusCallbackEvent;
            this.StatusCallback = statusCallback;
            this.StatusCallbackMethod = statusCallbackMethod;
            this.MachineDetection = machineDetection;
            this.AmdStatusCallbackMethod = amdStatusCallbackMethod;
            this.AmdStatusCallback = amdStatusCallback;
            this.MachineDetectionTimeout = machineDetectionTimeout;
            this.MachineDetectionSpeechThreshold = machineDetectionSpeechThreshold;
            this.MachineDetectionSpeechEndThreshold = machineDetectionSpeechEndThreshold;
            this.MachineDetectionSilenceTimeout = machineDetectionSilenceTimeout;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.SipUrl != null ? Serializers.Url(this.SipUrl) : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override IEnumerable<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Username != null)
            {
                attributes.Add(new XAttribute("username", this.Username));
            }
            if (this.Password != null)
            {
                attributes.Add(new XAttribute("password", this.Password));
            }
            if (this.Url != null)
            {
                attributes.Add(new XAttribute("url", Serializers.Url(this.Url)));
            }
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            if (this.StatusCallbackEvent != null)
            {
                attributes.Add(new XAttribute("statusCallbackEvent", String.Join(" ", this.StatusCallbackEvent.Select(e => e.ToString()).ToArray())));
            }
            if (this.StatusCallback != null)
            {
                attributes.Add(new XAttribute("statusCallback", Serializers.Url(this.StatusCallback)));
            }
            if (this.StatusCallbackMethod != null)
            {
                attributes.Add(new XAttribute("statusCallbackMethod", this.StatusCallbackMethod.ToString()));
            }
            if (this.MachineDetection != null)
            {
                attributes.Add(new XAttribute("machineDetection", this.MachineDetection));
            }
            if (this.AmdStatusCallbackMethod != null)
            {
                attributes.Add(new XAttribute("amdStatusCallbackMethod", this.AmdStatusCallbackMethod.ToString()));
            }
            if (this.AmdStatusCallback != null)
            {
                attributes.Add(new XAttribute("amdStatusCallback", this.AmdStatusCallback));
            }
            if (this.MachineDetectionTimeout != null)
            {
                attributes.Add(new XAttribute("machineDetectionTimeout", this.MachineDetectionTimeout.ToString()));
            }
            if (this.MachineDetectionSpeechThreshold != null)
            {
                attributes.Add(new XAttribute("machineDetectionSpeechThreshold", this.MachineDetectionSpeechThreshold.ToString()));
            }
            if (this.MachineDetectionSpeechEndThreshold != null)
            {
                attributes.Add(new XAttribute("machineDetectionSpeechEndThreshold", this.MachineDetectionSpeechEndThreshold.ToString()));
            }
            if (this.MachineDetectionSilenceTimeout != null)
            {
                attributes.Add(new XAttribute("machineDetectionSilenceTimeout", this.MachineDetectionSilenceTimeout.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Sip Append(TwiML childElem)
        {
            return (Sip) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Sip SetOption(string key, object value)
        {
            return (Sip) base.SetOption(key, value);
        }
    }

}