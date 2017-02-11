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

    public class AddressResource : Resource 
    {
        private static Request BuildCreateRequest(CreateAddressOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Addresses.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns> 
        public static AddressResource Create(CreateAddressOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Create Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns> 
        public static async System.Threading.Tasks.Task<AddressResource> CreateAsync(CreateAddressOptions options, ITwilioRestClient client = null)
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
        /// <param name="customerName"> The customer_name </param>
        /// <param name="street"> The street </param>
        /// <param name="city"> The city </param>
        /// <param name="region"> The region </param>
        /// <param name="postalCode"> The postal_code </param>
        /// <param name="isoCountry"> The iso_country </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="emergencyEnabled"> The emergency_enabled </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns> 
        public static AddressResource Create(string customerName, string street, string city, string region, string postalCode, string isoCountry, string accountSid = null, string friendlyName = null, bool? emergencyEnabled = null, ITwilioRestClient client = null)
        {
            var options = new CreateAddressOptions(customerName, street, city, region, postalCode, isoCountry){AccountSid = accountSid, FriendlyName = friendlyName, EmergencyEnabled = emergencyEnabled};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="customerName"> The customer_name </param>
        /// <param name="street"> The street </param>
        /// <param name="city"> The city </param>
        /// <param name="region"> The region </param>
        /// <param name="postalCode"> The postal_code </param>
        /// <param name="isoCountry"> The iso_country </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="emergencyEnabled"> The emergency_enabled </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns> 
        public static async System.Threading.Tasks.Task<AddressResource> CreateAsync(string customerName, string street, string city, string region, string postalCode, string isoCountry, string accountSid = null, string friendlyName = null, bool? emergencyEnabled = null, ITwilioRestClient client = null)
        {
            var options = new CreateAddressOptions(customerName, street, city, region, postalCode, isoCountry){AccountSid = accountSid, FriendlyName = friendlyName, EmergencyEnabled = emergencyEnabled};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteAddressOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Addresses/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns> 
        public static bool Delete(DeleteAddressOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAddressOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns> 
        public static bool Delete(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteAddressOptions(sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteAddressOptions(sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildFetchRequest(FetchAddressOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Addresses/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns> 
        public static AddressResource Fetch(FetchAddressOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Fetch Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns> 
        public static async System.Threading.Tasks.Task<AddressResource> FetchAsync(FetchAddressOptions options, ITwilioRestClient client = null)
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
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns> 
        public static AddressResource Fetch(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchAddressOptions(sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns> 
        public static async System.Threading.Tasks.Task<AddressResource> FetchAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchAddressOptions(sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateAddressOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Addresses/" + options.Sid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns> 
        public static AddressResource Update(UpdateAddressOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns> 
        public static async System.Threading.Tasks.Task<AddressResource> UpdateAsync(UpdateAddressOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="customerName"> The customer_name </param>
        /// <param name="street"> The street </param>
        /// <param name="city"> The city </param>
        /// <param name="region"> The region </param>
        /// <param name="postalCode"> The postal_code </param>
        /// <param name="emergencyEnabled"> The emergency_enabled </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns> 
        public static AddressResource Update(string sid, string accountSid = null, string friendlyName = null, string customerName = null, string street = null, string city = null, string region = null, string postalCode = null, bool? emergencyEnabled = null, ITwilioRestClient client = null)
        {
            var options = new UpdateAddressOptions(sid){AccountSid = accountSid, FriendlyName = friendlyName, CustomerName = customerName, Street = street, City = city, Region = region, PostalCode = postalCode, EmergencyEnabled = emergencyEnabled};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="customerName"> The customer_name </param>
        /// <param name="street"> The street </param>
        /// <param name="city"> The city </param>
        /// <param name="region"> The region </param>
        /// <param name="postalCode"> The postal_code </param>
        /// <param name="emergencyEnabled"> The emergency_enabled </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns> 
        public static async System.Threading.Tasks.Task<AddressResource> UpdateAsync(string sid, string accountSid = null, string friendlyName = null, string customerName = null, string street = null, string city = null, string region = null, string postalCode = null, bool? emergencyEnabled = null, ITwilioRestClient client = null)
        {
            var options = new UpdateAddressOptions(sid){AccountSid = accountSid, FriendlyName = friendlyName, CustomerName = customerName, Street = street, City = city, Region = region, PostalCode = postalCode, EmergencyEnabled = emergencyEnabled};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadAddressOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/Addresses.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns> 
        public static ResourceSet<AddressResource> Read(ReadAddressOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<AddressResource>.FromJson("addresses", response.Content);
            return new ResourceSet<AddressResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AddressResource>> ReadAsync(ReadAddressOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<AddressResource>.FromJson("addresses", response.Content);
            return new ResourceSet<AddressResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="customerName"> The customer_name </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="isoCountry"> The iso_country </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns> 
        public static ResourceSet<AddressResource> Read(string accountSid = null, string customerName = null, string friendlyName = null, string isoCountry = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAddressOptions{AccountSid = accountSid, CustomerName = customerName, FriendlyName = friendlyName, IsoCountry = isoCountry, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="customerName"> The customer_name </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="isoCountry"> The iso_country </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AddressResource>> ReadAsync(string accountSid = null, string customerName = null, string friendlyName = null, string isoCountry = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAddressOptions{AccountSid = accountSid, CustomerName = customerName, FriendlyName = friendlyName, IsoCountry = isoCountry, PageSize = pageSize, Limit = limit};
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
        public static Page<AddressResource> NextPage(Page<AddressResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<AddressResource>.FromJson("addresses", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a AddressResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AddressResource object represented by the provided JSON </returns> 
        public static AddressResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AddressResource>(json);
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
        /// The city
        /// </summary>
        [JsonProperty("city")]
        public string City { get; private set; }
        /// <summary>
        /// The customer_name
        /// </summary>
        [JsonProperty("customer_name")]
        public string CustomerName { get; private set; }
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
        /// The iso_country
        /// </summary>
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }
        /// <summary>
        /// The postal_code
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode { get; private set; }
        /// <summary>
        /// The region
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The street
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The emergency_enabled
        /// </summary>
        [JsonProperty("emergency_enabled")]
        public bool? EmergencyEnabled { get; private set; }
    
        private AddressResource()
        {
        
        }
    }

}