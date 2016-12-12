using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Lookups.V1 
{

    public class PhoneNumberResource : Resource 
    {
        public sealed class TypeEnum : StringEnum 
        {
            private TypeEnum(string value) : base(value) {}
            public TypeEnum() {}
        
            public static readonly TypeEnum Landline = new TypeEnum("landline");
            public static readonly TypeEnum Mobile = new TypeEnum("mobile");
            public static readonly TypeEnum Voip = new TypeEnum("voip");
        }
    
        private static Request BuildFetchRequest(FetchPhoneNumberOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Lookups,
                "/v1/PhoneNumbers/" + options.PhoneNumber + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns> 
        public static PhoneNumberResource Fetch(FetchPhoneNumberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if NET40
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns> 
        public static async System.Threading.Tasks.Task<PhoneNumberResource> FetchAsync(FetchPhoneNumberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="phoneNumber"> The phone_number </param>
        /// <param name="countryCode"> The country_code </param>
        /// <param name="type"> The type </param>
        /// <param name="addOns"> The add_ons </param>
        /// <param name="addOnsData"> The add_ons_data </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns> 
        public static PhoneNumberResource Fetch(Types.PhoneNumber phoneNumber, string countryCode = null, List<string> type = null, List<string> addOns = null, Dictionary<string, object> addOnsData = null, ITwilioRestClient client = null)
        {
            var options = new FetchPhoneNumberOptions(phoneNumber){CountryCode = countryCode, Type = type, AddOns = addOns, AddOnsData = addOnsData};
            return Fetch(options, client);
        }
    
        #if NET40
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="phoneNumber"> The phone_number </param>
        /// <param name="countryCode"> The country_code </param>
        /// <param name="type"> The type </param>
        /// <param name="addOns"> The add_ons </param>
        /// <param name="addOnsData"> The add_ons_data </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns> 
        public static async System.Threading.Tasks.Task<PhoneNumberResource> FetchAsync(Types.PhoneNumber phoneNumber, string countryCode = null, List<string> type = null, List<string> addOns = null, Dictionary<string, object> addOnsData = null, ITwilioRestClient client = null)
        {
            var options = new FetchPhoneNumberOptions(phoneNumber){CountryCode = countryCode, Type = type, AddOns = addOns, AddOnsData = addOnsData};
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a PhoneNumberResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PhoneNumberResource object represented by the provided JSON </returns> 
        public static PhoneNumberResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<PhoneNumberResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The caller_name
        /// </summary>
        [JsonProperty("caller_name")]
        public Dictionary<string, string> CallerName { get; private set; }
        /// <summary>
        /// The country_code
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; private set; }
        /// <summary>
        /// The phone_number
        /// </summary>
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }
        /// <summary>
        /// The national_format
        /// </summary>
        [JsonProperty("national_format")]
        public string NationalFormat { get; private set; }
        /// <summary>
        /// The carrier
        /// </summary>
        [JsonProperty("carrier")]
        public Dictionary<string, string> Carrier { get; private set; }
        /// <summary>
        /// The add_ons
        /// </summary>
        [JsonProperty("add_ons")]
        public object AddOns { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
    
        private PhoneNumberResource()
        {
        
        }
    }

}