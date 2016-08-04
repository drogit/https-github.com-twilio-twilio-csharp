using Newtonsoft.Json;
using System;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Readers.Api.V2010.Account.AvailablePhoneNumberCountry;
using Twilio.Resources;
using Twilio.Types;

namespace Twilio.Resources.Api.V2010.Account.AvailablePhoneNumberCountry {

    public class LocalResource : Resource {
        /**
         * read
         * 
         * @param accountSid The account_sid
         * @param countryCode The country_code
         * @return LocalReader capable of executing the read
         */
        public static LocalReader Read(string accountSid, string countryCode) {
            return new LocalReader(accountSid, countryCode);
        }
    
        /**
         * Create a LocalReader to execute read.
         * 
         * @param countryCode The country_code
         * @return LocalReader capable of executing the read
         */
        public static LocalReader Read(string countryCode) {
            return new LocalReader(countryCode);
        }
    
        /**
         * Converts a JSON string into a LocalResource object
         * 
         * @param json Raw JSON string
         * @return LocalResource object represented by the provided JSON
         */
        public static LocalResource FromJson(string json) {
            // Convert all checked exceptions to Runtime
            try {
                return JsonConvert.DeserializeObject<LocalResource>(json);
            } catch (JsonException e) {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("friendly_name")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        private readonly Twilio.Types.PhoneNumber friendlyName;
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        private readonly Twilio.Types.PhoneNumber phoneNumber;
        [JsonProperty("lata")]
        private readonly string lata;
        [JsonProperty("rate_center")]
        private readonly string rateCenter;
        [JsonProperty("latitude")]
        private readonly decimal? latitude;
        [JsonProperty("longitude")]
        private readonly decimal? longitude;
        [JsonProperty("region")]
        private readonly string region;
        [JsonProperty("postal_code")]
        private readonly string postalCode;
        [JsonProperty("iso_country")]
        private readonly string isoCountry;
        [JsonProperty("address_requirements")]
        private readonly string addressRequirements;
        [JsonProperty("beta")]
        private readonly bool? beta;
        [JsonProperty("capabilities")]
        private readonly PhoneNumberCapabilities capabilities;
    
        public LocalResource() {
        
        }
    
        private LocalResource([JsonProperty("friendly_name")]
                              Twilio.Types.PhoneNumber friendlyName, 
                              [JsonProperty("phone_number")]
                              Twilio.Types.PhoneNumber phoneNumber, 
                              [JsonProperty("lata")]
                              string lata, 
                              [JsonProperty("rate_center")]
                              string rateCenter, 
                              [JsonProperty("latitude")]
                              decimal? latitude, 
                              [JsonProperty("longitude")]
                              decimal? longitude, 
                              [JsonProperty("region")]
                              string region, 
                              [JsonProperty("postal_code")]
                              string postalCode, 
                              [JsonProperty("iso_country")]
                              string isoCountry, 
                              [JsonProperty("address_requirements")]
                              string addressRequirements, 
                              [JsonProperty("beta")]
                              bool? beta, 
                              [JsonProperty("capabilities")]
                              PhoneNumberCapabilities capabilities) {
            this.friendlyName = friendlyName;
            this.phoneNumber = phoneNumber;
            this.lata = lata;
            this.rateCenter = rateCenter;
            this.latitude = latitude;
            this.longitude = longitude;
            this.region = region;
            this.postalCode = postalCode;
            this.isoCountry = isoCountry;
            this.addressRequirements = addressRequirements;
            this.beta = beta;
            this.capabilities = capabilities;
        }
    
        /**
         * @return The friendly_name
         */
        public Twilio.Types.PhoneNumber GetFriendlyName() {
            return this.friendlyName;
        }
    
        /**
         * @return The phone_number
         */
        public Twilio.Types.PhoneNumber GetPhoneNumber() {
            return this.phoneNumber;
        }
    
        /**
         * @return The lata
         */
        public string GetLata() {
            return this.lata;
        }
    
        /**
         * @return The rate_center
         */
        public string GetRateCenter() {
            return this.rateCenter;
        }
    
        /**
         * @return The latitude
         */
        public decimal? GetLatitude() {
            return this.latitude;
        }
    
        /**
         * @return The longitude
         */
        public decimal? GetLongitude() {
            return this.longitude;
        }
    
        /**
         * @return The region
         */
        public string GetRegion() {
            return this.region;
        }
    
        /**
         * @return The postal_code
         */
        public string GetPostalCode() {
            return this.postalCode;
        }
    
        /**
         * @return The iso_country
         */
        public string GetIsoCountry() {
            return this.isoCountry;
        }
    
        /**
         * @return The address_requirements
         */
        public string GetAddressRequirements() {
            return this.addressRequirements;
        }
    
        /**
         * @return The beta
         */
        public bool? GetBeta() {
            return this.beta;
        }
    
        /**
         * @return The capabilities
         */
        public PhoneNumberCapabilities GetCapabilities() {
            return this.capabilities;
        }
    }
}