using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account 
{

    public class AvailablePhoneNumberCountryResource : Resource 
    {
        private static Request BuildReadRequest(ReadAvailablePhoneNumberCountryOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/AvailablePhoneNumbers.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read AvailablePhoneNumberCountry parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailablePhoneNumberCountry </returns> 
        public static ResourceSet<AvailablePhoneNumberCountryResource> Read(ReadAvailablePhoneNumberCountryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<AvailablePhoneNumberCountryResource>.FromJson("countries", response.Content);
            return new ResourceSet<AvailablePhoneNumberCountryResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read AvailablePhoneNumberCountry parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailablePhoneNumberCountry </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AvailablePhoneNumberCountryResource>> ReadAsync(ReadAvailablePhoneNumberCountryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<AvailablePhoneNumberCountryResource>.FromJson("countries", response.Content);
            return new ResourceSet<AvailablePhoneNumberCountryResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailablePhoneNumberCountry </returns> 
        public static ResourceSet<AvailablePhoneNumberCountryResource> Read(string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAvailablePhoneNumberCountryOptions{AccountSid = accountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailablePhoneNumberCountry </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AvailablePhoneNumberCountryResource>> ReadAsync(string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAvailablePhoneNumberCountryOptions{AccountSid = accountSid, PageSize = pageSize, Limit = limit};
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
        public static Page<AvailablePhoneNumberCountryResource> NextPage(Page<AvailablePhoneNumberCountryResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<AvailablePhoneNumberCountryResource>.FromJson("countries", response.Content);
        }
    
        private static Request BuildFetchRequest(FetchAvailablePhoneNumberCountryOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/AvailablePhoneNumbers/" + options.CountryCode + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch AvailablePhoneNumberCountry parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailablePhoneNumberCountry </returns> 
        public static AvailablePhoneNumberCountryResource Fetch(FetchAvailablePhoneNumberCountryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch AvailablePhoneNumberCountry parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailablePhoneNumberCountry </returns> 
        public static async System.Threading.Tasks.Task<AvailablePhoneNumberCountryResource> FetchAsync(FetchAvailablePhoneNumberCountryOptions options, ITwilioRestClient client = null)
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
        /// <param name="countryCode"> The country_code </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailablePhoneNumberCountry </returns> 
        public static AvailablePhoneNumberCountryResource Fetch(string countryCode, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchAvailablePhoneNumberCountryOptions(countryCode){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="countryCode"> The country_code </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailablePhoneNumberCountry </returns> 
        public static async System.Threading.Tasks.Task<AvailablePhoneNumberCountryResource> FetchAsync(string countryCode, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchAvailablePhoneNumberCountryOptions(countryCode){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a AvailablePhoneNumberCountryResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AvailablePhoneNumberCountryResource object represented by the provided JSON </returns> 
        public static AvailablePhoneNumberCountryResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AvailablePhoneNumberCountryResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The ISO Country code to lookup phone numbers for.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; private set; }
        /// <summary>
        /// The country
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; private set; }
        /// <summary>
        /// The beta
        /// </summary>
        [JsonProperty("beta")]
        public bool? Beta { get; private set; }
        /// <summary>
        /// The subresource_uris
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }
    
        private AvailablePhoneNumberCountryResource()
        {
        
        }
    }

}