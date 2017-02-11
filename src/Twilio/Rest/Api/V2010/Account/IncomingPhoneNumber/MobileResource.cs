using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.IncomingPhoneNumber 
{

    public class MobileResource : Resource 
    {
        public sealed class AddressRequirementEnum : StringEnum 
        {
            private AddressRequirementEnum(string value) : base(value) {}
            public AddressRequirementEnum() {}
        
            public static readonly AddressRequirementEnum None = new AddressRequirementEnum("none");
            public static readonly AddressRequirementEnum Any = new AddressRequirementEnum("any");
            public static readonly AddressRequirementEnum Local = new AddressRequirementEnum("local");
            public static readonly AddressRequirementEnum Foreign = new AddressRequirementEnum("foreign");
        }
    
        private static Request BuildReadRequest(ReadMobileOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.OwnerAccountSid ?? client.AccountSid) + "/IncomingPhoneNumbers/Mobile.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Mobile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Mobile </returns> 
        public static ResourceSet<MobileResource> Read(ReadMobileOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<MobileResource>.FromJson("incoming_phone_numbers", response.Content);
            return new ResourceSet<MobileResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Mobile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Mobile </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MobileResource>> ReadAsync(ReadMobileOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<MobileResource>.FromJson("incoming_phone_numbers", response.Content);
            return new ResourceSet<MobileResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="ownerAccountSid"> The owner_account_sid </param>
        /// <param name="beta"> The beta </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="phoneNumber"> The phone_number </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Mobile </returns> 
        public static ResourceSet<MobileResource> Read(string ownerAccountSid = null, bool? beta = null, string friendlyName = null, Types.PhoneNumber phoneNumber = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMobileOptions{OwnerAccountSid = ownerAccountSid, Beta = beta, FriendlyName = friendlyName, PhoneNumber = phoneNumber, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="ownerAccountSid"> The owner_account_sid </param>
        /// <param name="beta"> The beta </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="phoneNumber"> The phone_number </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Mobile </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MobileResource>> ReadAsync(string ownerAccountSid = null, bool? beta = null, string friendlyName = null, Types.PhoneNumber phoneNumber = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMobileOptions{OwnerAccountSid = ownerAccountSid, Beta = beta, FriendlyName = friendlyName, PhoneNumber = phoneNumber, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<MobileResource> NextPage(Page<MobileResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<MobileResource>.FromJson("incoming_phone_numbers", response.Content);
        }
    
        private static Request BuildCreateRequest(CreateMobileOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.OwnerAccountSid ?? client.AccountSid) + "/IncomingPhoneNumbers/Mobile.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Mobile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Mobile </returns> 
        public static MobileResource Create(CreateMobileOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Mobile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Mobile </returns> 
        public static async System.Threading.Tasks.Task<MobileResource> CreateAsync(CreateMobileOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="phoneNumber"> The phone_number </param>
        /// <param name="ownerAccountSid"> The owner_account_sid </param>
        /// <param name="apiVersion"> The api_version </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="smsApplicationSid"> The sms_application_sid </param>
        /// <param name="smsFallbackMethod"> The sms_fallback_method </param>
        /// <param name="smsFallbackUrl"> The sms_fallback_url </param>
        /// <param name="smsMethod"> The sms_method </param>
        /// <param name="smsUrl"> The sms_url </param>
        /// <param name="statusCallback"> The status_callback </param>
        /// <param name="statusCallbackMethod"> The status_callback_method </param>
        /// <param name="voiceApplicationSid"> The voice_application_sid </param>
        /// <param name="voiceCallerIdLookup"> The voice_caller_id_lookup </param>
        /// <param name="voiceFallbackMethod"> The voice_fallback_method </param>
        /// <param name="voiceFallbackUrl"> The voice_fallback_url </param>
        /// <param name="voiceMethod"> The voice_method </param>
        /// <param name="voiceUrl"> The voice_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Mobile </returns> 
        public static MobileResource Create(Types.PhoneNumber phoneNumber, string ownerAccountSid = null, string apiVersion = null, string friendlyName = null, string smsApplicationSid = null, Twilio.Http.HttpMethod smsFallbackMethod = null, Uri smsFallbackUrl = null, Twilio.Http.HttpMethod smsMethod = null, Uri smsUrl = null, Uri statusCallback = null, Twilio.Http.HttpMethod statusCallbackMethod = null, string voiceApplicationSid = null, bool? voiceCallerIdLookup = null, Twilio.Http.HttpMethod voiceFallbackMethod = null, Uri voiceFallbackUrl = null, Twilio.Http.HttpMethod voiceMethod = null, Uri voiceUrl = null, ITwilioRestClient client = null)
        {
            var options = new CreateMobileOptions(phoneNumber){OwnerAccountSid = ownerAccountSid, ApiVersion = apiVersion, FriendlyName = friendlyName, SmsApplicationSid = smsApplicationSid, SmsFallbackMethod = smsFallbackMethod, SmsFallbackUrl = smsFallbackUrl, SmsMethod = smsMethod, SmsUrl = smsUrl, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, VoiceApplicationSid = voiceApplicationSid, VoiceCallerIdLookup = voiceCallerIdLookup, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceUrl = voiceUrl};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="phoneNumber"> The phone_number </param>
        /// <param name="ownerAccountSid"> The owner_account_sid </param>
        /// <param name="apiVersion"> The api_version </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="smsApplicationSid"> The sms_application_sid </param>
        /// <param name="smsFallbackMethod"> The sms_fallback_method </param>
        /// <param name="smsFallbackUrl"> The sms_fallback_url </param>
        /// <param name="smsMethod"> The sms_method </param>
        /// <param name="smsUrl"> The sms_url </param>
        /// <param name="statusCallback"> The status_callback </param>
        /// <param name="statusCallbackMethod"> The status_callback_method </param>
        /// <param name="voiceApplicationSid"> The voice_application_sid </param>
        /// <param name="voiceCallerIdLookup"> The voice_caller_id_lookup </param>
        /// <param name="voiceFallbackMethod"> The voice_fallback_method </param>
        /// <param name="voiceFallbackUrl"> The voice_fallback_url </param>
        /// <param name="voiceMethod"> The voice_method </param>
        /// <param name="voiceUrl"> The voice_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Mobile </returns> 
        public static async System.Threading.Tasks.Task<MobileResource> CreateAsync(Types.PhoneNumber phoneNumber, string ownerAccountSid = null, string apiVersion = null, string friendlyName = null, string smsApplicationSid = null, Twilio.Http.HttpMethod smsFallbackMethod = null, Uri smsFallbackUrl = null, Twilio.Http.HttpMethod smsMethod = null, Uri smsUrl = null, Uri statusCallback = null, Twilio.Http.HttpMethod statusCallbackMethod = null, string voiceApplicationSid = null, bool? voiceCallerIdLookup = null, Twilio.Http.HttpMethod voiceFallbackMethod = null, Uri voiceFallbackUrl = null, Twilio.Http.HttpMethod voiceMethod = null, Uri voiceUrl = null, ITwilioRestClient client = null)
        {
            var options = new CreateMobileOptions(phoneNumber){OwnerAccountSid = ownerAccountSid, ApiVersion = apiVersion, FriendlyName = friendlyName, SmsApplicationSid = smsApplicationSid, SmsFallbackMethod = smsFallbackMethod, SmsFallbackUrl = smsFallbackUrl, SmsMethod = smsMethod, SmsUrl = smsUrl, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, VoiceApplicationSid = voiceApplicationSid, VoiceCallerIdLookup = voiceCallerIdLookup, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceUrl = voiceUrl};
            return await CreateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a MobileResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MobileResource object represented by the provided JSON </returns> 
        public static MobileResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<MobileResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The address_requirements
        /// </summary>
        [JsonProperty("address_requirements")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MobileResource.AddressRequirementEnum AddressRequirements { get; private set; }
        /// <summary>
        /// The api_version
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The beta
        /// </summary>
        [JsonProperty("beta")]
        public bool? Beta { get; private set; }
        /// <summary>
        /// The capabilities
        /// </summary>
        [JsonProperty("capabilities")]
        public PhoneNumberCapabilities Capabilities { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The phone_number
        /// </summary>
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The sms_application_sid
        /// </summary>
        [JsonProperty("sms_application_sid")]
        public string SmsApplicationSid { get; private set; }
        /// <summary>
        /// The sms_fallback_method
        /// </summary>
        [JsonProperty("sms_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; private set; }
        /// <summary>
        /// The sms_fallback_url
        /// </summary>
        [JsonProperty("sms_fallback_url")]
        public Uri SmsFallbackUrl { get; private set; }
        /// <summary>
        /// The sms_method
        /// </summary>
        [JsonProperty("sms_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod SmsMethod { get; private set; }
        /// <summary>
        /// The sms_url
        /// </summary>
        [JsonProperty("sms_url")]
        public Uri SmsUrl { get; private set; }
        /// <summary>
        /// The status_callback
        /// </summary>
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }
        /// <summary>
        /// The status_callback_method
        /// </summary>
        [JsonProperty("status_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; private set; }
        /// <summary>
        /// The trunk_sid
        /// </summary>
        [JsonProperty("trunk_sid")]
        public string TrunkSid { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The voice_application_sid
        /// </summary>
        [JsonProperty("voice_application_sid")]
        public string VoiceApplicationSid { get; private set; }
        /// <summary>
        /// The voice_caller_id_lookup
        /// </summary>
        [JsonProperty("voice_caller_id_lookup")]
        public bool? VoiceCallerIdLookup { get; private set; }
        /// <summary>
        /// The voice_fallback_method
        /// </summary>
        [JsonProperty("voice_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; private set; }
        /// <summary>
        /// The voice_fallback_url
        /// </summary>
        [JsonProperty("voice_fallback_url")]
        public Uri VoiceFallbackUrl { get; private set; }
        /// <summary>
        /// The voice_method
        /// </summary>
        [JsonProperty("voice_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceMethod { get; private set; }
        /// <summary>
        /// The voice_url
        /// </summary>
        [JsonProperty("voice_url")]
        public Uri VoiceUrl { get; private set; }
    
        private MobileResource()
        {
        
        }
    }

}