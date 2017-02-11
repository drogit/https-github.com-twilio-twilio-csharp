using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.AvailablePhoneNumberCountry 
{

    public class MobileResource : Resource 
    {
        private static Request BuildReadRequest(ReadMobileOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/AvailablePhoneNumbers/" + options.CountryCode + "/Mobile.json",
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
            
            var page = Page<MobileResource>.FromJson("available_phone_numbers", response.Content);
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
            
            var page = Page<MobileResource>.FromJson("available_phone_numbers", response.Content);
            return new ResourceSet<MobileResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="countryCode"> The country_code </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="areaCode"> The area_code </param>
        /// <param name="contains"> The contains </param>
        /// <param name="smsEnabled"> The sms_enabled </param>
        /// <param name="mmsEnabled"> The mms_enabled </param>
        /// <param name="voiceEnabled"> The voice_enabled </param>
        /// <param name="excludeAllAddressRequired"> The exclude_all_address_required </param>
        /// <param name="excludeLocalAddressRequired"> The exclude_local_address_required </param>
        /// <param name="excludeForeignAddressRequired"> The exclude_foreign_address_required </param>
        /// <param name="beta"> The beta </param>
        /// <param name="nearNumber"> The near_number </param>
        /// <param name="nearLatLong"> The near_lat_long </param>
        /// <param name="distance"> The distance </param>
        /// <param name="inPostalCode"> The in_postal_code </param>
        /// <param name="inRegion"> The in_region </param>
        /// <param name="inRateCenter"> The in_rate_center </param>
        /// <param name="inLata"> The in_lata </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Mobile </returns> 
        public static ResourceSet<MobileResource> Read(string countryCode, string accountSid = null, int? areaCode = null, string contains = null, bool? smsEnabled = null, bool? mmsEnabled = null, bool? voiceEnabled = null, bool? excludeAllAddressRequired = null, bool? excludeLocalAddressRequired = null, bool? excludeForeignAddressRequired = null, bool? beta = null, Types.PhoneNumber nearNumber = null, string nearLatLong = null, int? distance = null, string inPostalCode = null, string inRegion = null, string inRateCenter = null, string inLata = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMobileOptions(countryCode){AccountSid = accountSid, AreaCode = areaCode, Contains = contains, SmsEnabled = smsEnabled, MmsEnabled = mmsEnabled, VoiceEnabled = voiceEnabled, ExcludeAllAddressRequired = excludeAllAddressRequired, ExcludeLocalAddressRequired = excludeLocalAddressRequired, ExcludeForeignAddressRequired = excludeForeignAddressRequired, Beta = beta, NearNumber = nearNumber, NearLatLong = nearLatLong, Distance = distance, InPostalCode = inPostalCode, InRegion = inRegion, InRateCenter = inRateCenter, InLata = inLata, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="countryCode"> The country_code </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="areaCode"> The area_code </param>
        /// <param name="contains"> The contains </param>
        /// <param name="smsEnabled"> The sms_enabled </param>
        /// <param name="mmsEnabled"> The mms_enabled </param>
        /// <param name="voiceEnabled"> The voice_enabled </param>
        /// <param name="excludeAllAddressRequired"> The exclude_all_address_required </param>
        /// <param name="excludeLocalAddressRequired"> The exclude_local_address_required </param>
        /// <param name="excludeForeignAddressRequired"> The exclude_foreign_address_required </param>
        /// <param name="beta"> The beta </param>
        /// <param name="nearNumber"> The near_number </param>
        /// <param name="nearLatLong"> The near_lat_long </param>
        /// <param name="distance"> The distance </param>
        /// <param name="inPostalCode"> The in_postal_code </param>
        /// <param name="inRegion"> The in_region </param>
        /// <param name="inRateCenter"> The in_rate_center </param>
        /// <param name="inLata"> The in_lata </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Mobile </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MobileResource>> ReadAsync(string countryCode, string accountSid = null, int? areaCode = null, string contains = null, bool? smsEnabled = null, bool? mmsEnabled = null, bool? voiceEnabled = null, bool? excludeAllAddressRequired = null, bool? excludeLocalAddressRequired = null, bool? excludeForeignAddressRequired = null, bool? beta = null, Types.PhoneNumber nearNumber = null, string nearLatLong = null, int? distance = null, string inPostalCode = null, string inRegion = null, string inRateCenter = null, string inLata = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMobileOptions(countryCode){AccountSid = accountSid, AreaCode = areaCode, Contains = contains, SmsEnabled = smsEnabled, MmsEnabled = mmsEnabled, VoiceEnabled = voiceEnabled, ExcludeAllAddressRequired = excludeAllAddressRequired, ExcludeLocalAddressRequired = excludeLocalAddressRequired, ExcludeForeignAddressRequired = excludeForeignAddressRequired, Beta = beta, NearNumber = nearNumber, NearLatLong = nearLatLong, Distance = distance, InPostalCode = inPostalCode, InRegion = inRegion, InRateCenter = inRateCenter, InLata = inLata, PageSize = pageSize, Limit = limit};
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
            return Page<MobileResource>.FromJson("available_phone_numbers", response.Content);
        }
    
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
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber FriendlyName { get; private set; }
        /// <summary>
        /// The phone_number
        /// </summary>
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }
        /// <summary>
        /// The lata
        /// </summary>
        [JsonProperty("lata")]
        public string Lata { get; private set; }
        /// <summary>
        /// The rate_center
        /// </summary>
        [JsonProperty("rate_center")]
        public string RateCenter { get; private set; }
        /// <summary>
        /// The latitude
        /// </summary>
        [JsonProperty("latitude")]
        public decimal? Latitude { get; private set; }
        /// <summary>
        /// The longitude
        /// </summary>
        [JsonProperty("longitude")]
        public decimal? Longitude { get; private set; }
        /// <summary>
        /// The region
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; private set; }
        /// <summary>
        /// The postal_code
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode { get; private set; }
        /// <summary>
        /// The iso_country
        /// </summary>
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }
        /// <summary>
        /// The address_requirements
        /// </summary>
        [JsonProperty("address_requirements")]
        public string AddressRequirements { get; private set; }
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
    
        private MobileResource()
        {
        
        }
    }

}