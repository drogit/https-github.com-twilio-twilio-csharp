/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// PhoneCallResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.TrustedComms
{

    public class PhoneCallResource : Resource
    {
        private static Request BuildCreateRequest(CreatePhoneCallOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/TrustedComms/Business/PhoneCalls",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Initiates a Branded Call.
        /// </summary>
        /// <param name="options"> Create PhoneCall parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneCall </returns>
        public static PhoneCallResource Create(CreatePhoneCallOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Initiates a Branded Call.
        /// </summary>
        /// <param name="options"> Create PhoneCall parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneCall </returns>
        public static async System.Threading.Tasks.Task<PhoneCallResource> CreateAsync(CreatePhoneCallOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Initiates a Branded Call.
        /// </summary>
        /// <param name="from"> Twilio number from which to originate the call </param>
        /// <param name="to"> The terminating Phone Number </param>
        /// <param name="reason"> The business reason for this phone call </param>
        /// <param name="applicationSid"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="callerId"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="fallbackMethod"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="fallbackUrl"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="machineDetection"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="machineDetectionSilenceTimeout"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="machineDetectionSpeechEndThreshold"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="machineDetectionSpeechThreshold"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="machineDetectionTimeout"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="method"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="record"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="recordingChannels"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="recordingStatusCallback"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="recordingStatusCallbackEvent"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="recordingStatusCallbackMethod"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="sendDigits"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="sipAuthPassword"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="sipAuthUsername"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="statusCallback"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="statusCallbackEvent"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="statusCallbackMethod"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="timeout"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="trim"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="url"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneCall </returns>
        public static PhoneCallResource Create(string from,
                                               string to,
                                               string reason = null,
                                               string applicationSid = null,
                                               string callerId = null,
                                               Twilio.Http.HttpMethod fallbackMethod = null,
                                               Uri fallbackUrl = null,
                                               string machineDetection = null,
                                               int? machineDetectionSilenceTimeout = null,
                                               int? machineDetectionSpeechEndThreshold = null,
                                               int? machineDetectionSpeechThreshold = null,
                                               int? machineDetectionTimeout = null,
                                               Twilio.Http.HttpMethod method = null,
                                               bool? record = null,
                                               string recordingChannels = null,
                                               string recordingStatusCallback = null,
                                               List<string> recordingStatusCallbackEvent = null,
                                               Twilio.Http.HttpMethod recordingStatusCallbackMethod = null,
                                               string sendDigits = null,
                                               string sipAuthPassword = null,
                                               string sipAuthUsername = null,
                                               Uri statusCallback = null,
                                               List<string> statusCallbackEvent = null,
                                               Twilio.Http.HttpMethod statusCallbackMethod = null,
                                               int? timeout = null,
                                               string trim = null,
                                               Uri url = null,
                                               ITwilioRestClient client = null)
        {
            var options = new CreatePhoneCallOptions(from, to){Reason = reason, ApplicationSid = applicationSid, CallerId = callerId, FallbackMethod = fallbackMethod, FallbackUrl = fallbackUrl, MachineDetection = machineDetection, MachineDetectionSilenceTimeout = machineDetectionSilenceTimeout, MachineDetectionSpeechEndThreshold = machineDetectionSpeechEndThreshold, MachineDetectionSpeechThreshold = machineDetectionSpeechThreshold, MachineDetectionTimeout = machineDetectionTimeout, Method = method, Record = record, RecordingChannels = recordingChannels, RecordingStatusCallback = recordingStatusCallback, RecordingStatusCallbackEvent = recordingStatusCallbackEvent, RecordingStatusCallbackMethod = recordingStatusCallbackMethod, SendDigits = sendDigits, SipAuthPassword = sipAuthPassword, SipAuthUsername = sipAuthUsername, StatusCallback = statusCallback, StatusCallbackEvent = statusCallbackEvent, StatusCallbackMethod = statusCallbackMethod, Timeout = timeout, Trim = trim, Url = url};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Initiates a Branded Call.
        /// </summary>
        /// <param name="from"> Twilio number from which to originate the call </param>
        /// <param name="to"> The terminating Phone Number </param>
        /// <param name="reason"> The business reason for this phone call </param>
        /// <param name="applicationSid"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="callerId"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="fallbackMethod"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="fallbackUrl"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="machineDetection"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="machineDetectionSilenceTimeout"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="machineDetectionSpeechEndThreshold"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="machineDetectionSpeechThreshold"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="machineDetectionTimeout"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="method"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="record"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="recordingChannels"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="recordingStatusCallback"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="recordingStatusCallbackEvent"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="recordingStatusCallbackMethod"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="sendDigits"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="sipAuthPassword"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="sipAuthUsername"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="statusCallback"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="statusCallbackEvent"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="statusCallbackMethod"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="timeout"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="trim"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="url"> Refers to the Voice API Initiate Call parameter </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneCall </returns>
        public static async System.Threading.Tasks.Task<PhoneCallResource> CreateAsync(string from,
                                                                                       string to,
                                                                                       string reason = null,
                                                                                       string applicationSid = null,
                                                                                       string callerId = null,
                                                                                       Twilio.Http.HttpMethod fallbackMethod = null,
                                                                                       Uri fallbackUrl = null,
                                                                                       string machineDetection = null,
                                                                                       int? machineDetectionSilenceTimeout = null,
                                                                                       int? machineDetectionSpeechEndThreshold = null,
                                                                                       int? machineDetectionSpeechThreshold = null,
                                                                                       int? machineDetectionTimeout = null,
                                                                                       Twilio.Http.HttpMethod method = null,
                                                                                       bool? record = null,
                                                                                       string recordingChannels = null,
                                                                                       string recordingStatusCallback = null,
                                                                                       List<string> recordingStatusCallbackEvent = null,
                                                                                       Twilio.Http.HttpMethod recordingStatusCallbackMethod = null,
                                                                                       string sendDigits = null,
                                                                                       string sipAuthPassword = null,
                                                                                       string sipAuthUsername = null,
                                                                                       Uri statusCallback = null,
                                                                                       List<string> statusCallbackEvent = null,
                                                                                       Twilio.Http.HttpMethod statusCallbackMethod = null,
                                                                                       int? timeout = null,
                                                                                       string trim = null,
                                                                                       Uri url = null,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new CreatePhoneCallOptions(from, to){Reason = reason, ApplicationSid = applicationSid, CallerId = callerId, FallbackMethod = fallbackMethod, FallbackUrl = fallbackUrl, MachineDetection = machineDetection, MachineDetectionSilenceTimeout = machineDetectionSilenceTimeout, MachineDetectionSpeechEndThreshold = machineDetectionSpeechEndThreshold, MachineDetectionSpeechThreshold = machineDetectionSpeechThreshold, MachineDetectionTimeout = machineDetectionTimeout, Method = method, Record = record, RecordingChannels = recordingChannels, RecordingStatusCallback = recordingStatusCallback, RecordingStatusCallbackEvent = recordingStatusCallbackEvent, RecordingStatusCallbackMethod = recordingStatusCallbackMethod, SendDigits = sendDigits, SipAuthPassword = sipAuthPassword, SipAuthUsername = sipAuthUsername, StatusCallback = statusCallback, StatusCallbackEvent = statusCallbackEvent, StatusCallbackMethod = statusCallbackMethod, Timeout = timeout, Trim = trim, Url = url};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a PhoneCallResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PhoneCallResource object represented by the provided JSON </returns>
        public static PhoneCallResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<PhoneCallResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Background color of the current phone call
        /// </summary>
        [JsonProperty("bg_color")]
        public string BgColor { get; private set; }
        /// <summary>
        /// Brand Sid.
        /// </summary>
        [JsonProperty("brand_sid")]
        public string BrandSid { get; private set; }
        /// <summary>
        /// Branded Channel Sid.
        /// </summary>
        [JsonProperty("branded_channel_sid")]
        public string BrandedChannelSid { get; private set; }
        /// <summary>
        /// Business Sid.
        /// </summary>
        [JsonProperty("business_sid")]
        public string BusinessSid { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this phone call.
        /// </summary>
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }
        /// <summary>
        /// Caller name of the current phone call
        /// </summary>
        [JsonProperty("caller")]
        public string Caller { get; private set; }
        /// <summary>
        /// The date this Current Call was created
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; private set; }
        /// <summary>
        /// Font color of the current phone call
        /// </summary>
        [JsonProperty("font_color")]
        public string FontColor { get; private set; }
        /// <summary>
        /// The originating Phone Number
        /// </summary>
        [JsonProperty("from")]
        public string From { get; private set; }
        /// <summary>
        /// Logo URL of the caller
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; private set; }
        /// <summary>
        /// Phone Number Sid.
        /// </summary>
        [JsonProperty("phone_number_sid")]
        public string PhoneNumberSid { get; private set; }
        /// <summary>
        /// The business reason for this phone call
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this current branded phone call.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The status of the current phone call
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }
        /// <summary>
        /// The terminating Phone Number
        /// </summary>
        [JsonProperty("to")]
        public string To { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The use case for the current phone call
        /// </summary>
        [JsonProperty("use_case")]
        public string UseCase { get; private set; }

        private PhoneCallResource()
        {

        }
    }

}