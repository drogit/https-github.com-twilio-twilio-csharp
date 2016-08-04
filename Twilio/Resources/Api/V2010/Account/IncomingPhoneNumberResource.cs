using Newtonsoft.Json;
using System;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Creators.Api.V2010.Account;
using Twilio.Deleters.Api.V2010.Account;
using Twilio.Exceptions;
using Twilio.Fetchers.Api.V2010.Account;
using Twilio.Http;
using Twilio.Readers.Api.V2010.Account;
using Twilio.Resources;
using Twilio.Types;
using Twilio.Updaters.Api.V2010.Account;

namespace Twilio.Resources.Api.V2010.Account {

    public class IncomingPhoneNumberResource : SidResource {
        public sealed class AddressRequirement : IStringEnum {
            public const string NONE="none";
            public const string ANY="any";
            public const string LOCAL="local";
            public const string FOREIGN="foreign";
        
            private string value;
            
            public AddressRequirement() { }
            
            public AddressRequirement(string value) {
                this.value = value;
            }
            
            public override string ToString() {
                return value;
            }
            
            public static implicit operator AddressRequirement(string value) {
                return new AddressRequirement(value);
            }
            
            public static implicit operator string(AddressRequirement value) {
                return value.ToString();
            }
            
            public void FromString(string value) {
                this.value = value;
            }
        }
    
        /**
         * Update an incoming-phone-number instance
         * 
         * @param ownerAccountSid The owner_account_sid
         * @param sid The sid
         * @return IncomingPhoneNumberUpdater capable of executing the update
         */
        public static IncomingPhoneNumberUpdater Update(string ownerAccountSid, string sid) {
            return new IncomingPhoneNumberUpdater(ownerAccountSid, sid);
        }
    
        /**
         * Create a IncomingPhoneNumberUpdater to execute update.
         * 
         * @param sid The sid
         * @return IncomingPhoneNumberUpdater capable of executing the update
         */
        public static IncomingPhoneNumberUpdater Update(string sid) {
            return new IncomingPhoneNumberUpdater(sid);
        }
    
        /**
         * Fetch an incoming-phone-number belonging to the account used to make the
         * request
         * 
         * @param ownerAccountSid The owner_account_sid
         * @param sid Fetch by unique incoming-phone-number Sid
         * @return IncomingPhoneNumberFetcher capable of executing the fetch
         */
        public static IncomingPhoneNumberFetcher Fetch(string ownerAccountSid, string sid) {
            return new IncomingPhoneNumberFetcher(ownerAccountSid, sid);
        }
    
        /**
         * Create a IncomingPhoneNumberFetcher to execute fetch.
         * 
         * @param sid Fetch by unique incoming-phone-number Sid
         * @return IncomingPhoneNumberFetcher capable of executing the fetch
         */
        public static IncomingPhoneNumberFetcher Fetch(string sid) {
            return new IncomingPhoneNumberFetcher(sid);
        }
    
        /**
         * Delete a phone-numbers belonging to the account used to make the request
         * 
         * @param ownerAccountSid The owner_account_sid
         * @param sid Delete by unique phone-number Sid
         * @return IncomingPhoneNumberDeleter capable of executing the delete
         */
        public static IncomingPhoneNumberDeleter Delete(string ownerAccountSid, string sid) {
            return new IncomingPhoneNumberDeleter(ownerAccountSid, sid);
        }
    
        /**
         * Create a IncomingPhoneNumberDeleter to execute delete.
         * 
         * @param sid Delete by unique phone-number Sid
         * @return IncomingPhoneNumberDeleter capable of executing the delete
         */
        public static IncomingPhoneNumberDeleter Delete(string sid) {
            return new IncomingPhoneNumberDeleter(sid);
        }
    
        /**
         * Retrieve a list of incoming-phone-numbers belonging to the account used to
         * make the request
         * 
         * @param ownerAccountSid The owner_account_sid
         * @return IncomingPhoneNumberReader capable of executing the read
         */
        public static IncomingPhoneNumberReader Read(string ownerAccountSid) {
            return new IncomingPhoneNumberReader(ownerAccountSid);
        }
    
        /**
         * Create a IncomingPhoneNumberReader to execute read.
         * 
         * @return IncomingPhoneNumberReader capable of executing the read
         */
        public static IncomingPhoneNumberReader Read() {
            return new IncomingPhoneNumberReader();
        }
    
        /**
         * Purchase a phone-number for the account
         * 
         * @param ownerAccountSid The owner_account_sid
         * @param phoneNumber The phone number
         * @return IncomingPhoneNumberCreator capable of executing the create
         */
        public static IncomingPhoneNumberCreator Create(string ownerAccountSid, Twilio.Types.PhoneNumber phoneNumber) {
            return new IncomingPhoneNumberCreator(ownerAccountSid, phoneNumber);
        }
    
        /**
         * Create a IncomingPhoneNumberCreator to execute create.
         * 
         * @param phoneNumber The phone number
         * @return IncomingPhoneNumberCreator capable of executing the create
         */
        public static IncomingPhoneNumberCreator Create(Twilio.Types.PhoneNumber phoneNumber) {
            return new IncomingPhoneNumberCreator(phoneNumber);
        }
    
        /**
         * Purchase a phone-number for the account
         * 
         * @param ownerAccountSid The owner_account_sid
         * @param areaCode The desired area code for the new number
         * @return IncomingPhoneNumberCreator capable of executing the create
         */
        public static IncomingPhoneNumberCreator Create(string ownerAccountSid, string areaCode) {
            return new IncomingPhoneNumberCreator(ownerAccountSid, areaCode);
        }
    
        /**
         * Create a IncomingPhoneNumberCreator to execute create.
         * 
         * @param areaCode The desired area code for the new number
         * @return IncomingPhoneNumberCreator capable of executing the create
         */
        public static IncomingPhoneNumberCreator Create(string areaCode) {
            return new IncomingPhoneNumberCreator(areaCode);
        }
    
        /**
         * Converts a JSON string into a IncomingPhoneNumberResource object
         * 
         * @param json Raw JSON string
         * @return IncomingPhoneNumberResource object represented by the provided JSON
         */
        public static IncomingPhoneNumberResource FromJson(string json) {
            // Convert all checked exceptions to Runtime
            try {
                return JsonConvert.DeserializeObject<IncomingPhoneNumberResource>(json);
            } catch (JsonException e) {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        private readonly string accountSid;
        [JsonProperty("address_requirements")]
        [JsonConverter(typeof(StringEnumConverter))]
        private readonly IncomingPhoneNumberResource.AddressRequirement addressRequirements;
        [JsonProperty("api_version")]
        private readonly string apiVersion;
        [JsonProperty("beta")]
        private readonly bool? beta;
        [JsonProperty("capabilities")]
        private readonly PhoneNumberCapabilities capabilities;
        [JsonProperty("date_created")]
        private readonly DateTime? dateCreated;
        [JsonProperty("date_updated")]
        private readonly DateTime? dateUpdated;
        [JsonProperty("friendly_name")]
        private readonly string friendlyName;
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        private readonly Twilio.Types.PhoneNumber phoneNumber;
        [JsonProperty("sid")]
        private readonly string sid;
        [JsonProperty("sms_application_sid")]
        private readonly string smsApplicationSid;
        [JsonProperty("sms_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        private readonly Twilio.Http.HttpMethod smsFallbackMethod;
        [JsonProperty("sms_fallback_url")]
        private readonly Uri smsFallbackUrl;
        [JsonProperty("sms_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        private readonly Twilio.Http.HttpMethod smsMethod;
        [JsonProperty("sms_url")]
        private readonly Uri smsUrl;
        [JsonProperty("status_callback")]
        private readonly Uri statusCallback;
        [JsonProperty("status_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        private readonly Twilio.Http.HttpMethod statusCallbackMethod;
        [JsonProperty("uri")]
        private readonly string uri;
        [JsonProperty("voice_application_sid")]
        private readonly string voiceApplicationSid;
        [JsonProperty("voice_caller_id_lookup")]
        private readonly bool? voiceCallerIdLookup;
        [JsonProperty("voice_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        private readonly Twilio.Http.HttpMethod voiceFallbackMethod;
        [JsonProperty("voice_fallback_url")]
        private readonly Uri voiceFallbackUrl;
        [JsonProperty("voice_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        private readonly Twilio.Http.HttpMethod voiceMethod;
        [JsonProperty("voice_url")]
        private readonly Uri voiceUrl;
    
        public IncomingPhoneNumberResource() {
        
        }
    
        private IncomingPhoneNumberResource([JsonProperty("account_sid")]
                                            string accountSid, 
                                            [JsonProperty("address_requirements")]
                                            IncomingPhoneNumberResource.AddressRequirement addressRequirements, 
                                            [JsonProperty("api_version")]
                                            string apiVersion, 
                                            [JsonProperty("beta")]
                                            bool? beta, 
                                            [JsonProperty("capabilities")]
                                            PhoneNumberCapabilities capabilities, 
                                            [JsonProperty("date_created")]
                                            string dateCreated, 
                                            [JsonProperty("date_updated")]
                                            string dateUpdated, 
                                            [JsonProperty("friendly_name")]
                                            string friendlyName, 
                                            [JsonProperty("phone_number")]
                                            Twilio.Types.PhoneNumber phoneNumber, 
                                            [JsonProperty("sid")]
                                            string sid, 
                                            [JsonProperty("sms_application_sid")]
                                            string smsApplicationSid, 
                                            [JsonProperty("sms_fallback_method")]
                                            Twilio.Http.HttpMethod smsFallbackMethod, 
                                            [JsonProperty("sms_fallback_url")]
                                            Uri smsFallbackUrl, 
                                            [JsonProperty("sms_method")]
                                            Twilio.Http.HttpMethod smsMethod, 
                                            [JsonProperty("sms_url")]
                                            Uri smsUrl, 
                                            [JsonProperty("status_callback")]
                                            Uri statusCallback, 
                                            [JsonProperty("status_callback_method")]
                                            Twilio.Http.HttpMethod statusCallbackMethod, 
                                            [JsonProperty("uri")]
                                            string uri, 
                                            [JsonProperty("voice_application_sid")]
                                            string voiceApplicationSid, 
                                            [JsonProperty("voice_caller_id_lookup")]
                                            bool? voiceCallerIdLookup, 
                                            [JsonProperty("voice_fallback_method")]
                                            Twilio.Http.HttpMethod voiceFallbackMethod, 
                                            [JsonProperty("voice_fallback_url")]
                                            Uri voiceFallbackUrl, 
                                            [JsonProperty("voice_method")]
                                            Twilio.Http.HttpMethod voiceMethod, 
                                            [JsonProperty("voice_url")]
                                            Uri voiceUrl) {
            this.accountSid = accountSid;
            this.addressRequirements = addressRequirements;
            this.apiVersion = apiVersion;
            this.beta = beta;
            this.capabilities = capabilities;
            this.dateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            this.dateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
            this.friendlyName = friendlyName;
            this.phoneNumber = phoneNumber;
            this.sid = sid;
            this.smsApplicationSid = smsApplicationSid;
            this.smsFallbackMethod = smsFallbackMethod;
            this.smsFallbackUrl = smsFallbackUrl;
            this.smsMethod = smsMethod;
            this.smsUrl = smsUrl;
            this.statusCallback = statusCallback;
            this.statusCallbackMethod = statusCallbackMethod;
            this.uri = uri;
            this.voiceApplicationSid = voiceApplicationSid;
            this.voiceCallerIdLookup = voiceCallerIdLookup;
            this.voiceFallbackMethod = voiceFallbackMethod;
            this.voiceFallbackUrl = voiceFallbackUrl;
            this.voiceMethod = voiceMethod;
            this.voiceUrl = voiceUrl;
        }
    
        /**
         * @return The unique sid that identifies this account
         */
        public string GetAccountSid() {
            return this.accountSid;
        }
    
        /**
         * @return Indicates if the customer requires an address
         */
        public IncomingPhoneNumberResource.AddressRequirement GetAddressRequirements() {
            return this.addressRequirements;
        }
    
        /**
         * @return The Twilio REST API version to use
         */
        public string GetApiVersion() {
            return this.apiVersion;
        }
    
        /**
         * @return Indicates if the phone number is a beta number
         */
        public bool? GetBeta() {
            return this.beta;
        }
    
        /**
         * @return Indicate if a phone can receive calls or messages
         */
        public PhoneNumberCapabilities GetCapabilities() {
            return this.capabilities;
        }
    
        /**
         * @return The date this resource was created
         */
        public DateTime? GetDateCreated() {
            return this.dateCreated;
        }
    
        /**
         * @return The date this resource was last updated
         */
        public DateTime? GetDateUpdated() {
            return this.dateUpdated;
        }
    
        /**
         * @return A human readable description of this resouce
         */
        public string GetFriendlyName() {
            return this.friendlyName;
        }
    
        /**
         * @return The incoming phone number
         */
        public Twilio.Types.PhoneNumber GetPhoneNumber() {
            return this.phoneNumber;
        }
    
        /**
         * @return A string that uniquely identifies this resource
         */
        public override string GetSid() {
            return this.sid;
        }
    
        /**
         * @return Unique string that identifies the application
         */
        public string GetSmsApplicationSid() {
            return this.smsApplicationSid;
        }
    
        /**
         * @return HTTP method used with sms fallback url
         */
        public Twilio.Http.HttpMethod GetSmsFallbackMethod() {
            return this.smsFallbackMethod;
        }
    
        /**
         * @return URL Twilio will request if an error occurs in executing TwiML
         */
        public Uri GetSmsFallbackUrl() {
            return this.smsFallbackUrl;
        }
    
        /**
         * @return HTTP method to use with sms url
         */
        public Twilio.Http.HttpMethod GetSmsMethod() {
            return this.smsMethod;
        }
    
        /**
         * @return URL Twilio will request when receiving an SMS
         */
        public Uri GetSmsUrl() {
            return this.smsUrl;
        }
    
        /**
         * @return URL Twilio will use to pass status parameters
         */
        public Uri GetStatusCallback() {
            return this.statusCallback;
        }
    
        /**
         * @return HTTP method twilio will use with status callback
         */
        public Twilio.Http.HttpMethod GetStatusCallbackMethod() {
            return this.statusCallbackMethod;
        }
    
        /**
         * @return The URI for this resource
         */
        public string GetUri() {
            return this.uri;
        }
    
        /**
         * @return The unique sid of the application to handle this number
         */
        public string GetVoiceApplicationSid() {
            return this.voiceApplicationSid;
        }
    
        /**
         * @return Look up the caller's caller-ID
         */
        public bool? GetVoiceCallerIdLookup() {
            return this.voiceCallerIdLookup;
        }
    
        /**
         * @return HTTP method used with fallback_url
         */
        public Twilio.Http.HttpMethod GetVoiceFallbackMethod() {
            return this.voiceFallbackMethod;
        }
    
        /**
         * @return URL Twilio will request when an error occurs in TwiML
         */
        public Uri GetVoiceFallbackUrl() {
            return this.voiceFallbackUrl;
        }
    
        /**
         * @return HTTP method used with the voice url
         */
        public Twilio.Http.HttpMethod GetVoiceMethod() {
            return this.voiceMethod;
        }
    
        /**
         * @return URL Twilio will request when receiving a call
         */
        public Uri GetVoiceUrl() {
            return this.voiceUrl;
        }
    }
}