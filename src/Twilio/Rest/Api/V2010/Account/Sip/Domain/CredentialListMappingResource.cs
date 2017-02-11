using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Sip.Domain 
{

    public class CredentialListMappingResource : Resource 
    {
        private static Request BuildCreateRequest(CreateCredentialListMappingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.DomainSid + "/CredentialListMappings.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create CredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialListMapping </returns> 
        public static CredentialListMappingResource Create(CreateCredentialListMappingOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Create CredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<CredentialListMappingResource> CreateAsync(CreateCredentialListMappingOptions options, ITwilioRestClient client = null)
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
        /// <param name="domainSid"> The domain_sid </param>
        /// <param name="credentialListSid"> The credential_list_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialListMapping </returns> 
        public static CredentialListMappingResource Create(string domainSid, string credentialListSid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new CreateCredentialListMappingOptions(domainSid, credentialListSid){AccountSid = accountSid};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="domainSid"> The domain_sid </param>
        /// <param name="credentialListSid"> The credential_list_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<CredentialListMappingResource> CreateAsync(string domainSid, string credentialListSid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new CreateCredentialListMappingOptions(domainSid, credentialListSid){AccountSid = accountSid};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadCredentialListMappingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.DomainSid + "/CredentialListMappings.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read CredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialListMapping </returns> 
        public static ResourceSet<CredentialListMappingResource> Read(ReadCredentialListMappingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<CredentialListMappingResource>.FromJson("credential_list_mappings", response.Content);
            return new ResourceSet<CredentialListMappingResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read CredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialListMappingResource>> ReadAsync(ReadCredentialListMappingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<CredentialListMappingResource>.FromJson("credential_list_mappings", response.Content);
            return new ResourceSet<CredentialListMappingResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="domainSid"> The domain_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialListMapping </returns> 
        public static ResourceSet<CredentialListMappingResource> Read(string domainSid, string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadCredentialListMappingOptions(domainSid){AccountSid = accountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="domainSid"> The domain_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialListMappingResource>> ReadAsync(string domainSid, string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadCredentialListMappingOptions(domainSid){AccountSid = accountSid, PageSize = pageSize, Limit = limit};
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
        public static Page<CredentialListMappingResource> NextPage(Page<CredentialListMappingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<CredentialListMappingResource>.FromJson("credential_list_mappings", response.Content);
        }
    
        private static Request BuildFetchRequest(FetchCredentialListMappingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.DomainSid + "/CredentialListMappings/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch CredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialListMapping </returns> 
        public static CredentialListMappingResource Fetch(FetchCredentialListMappingOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Fetch CredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<CredentialListMappingResource> FetchAsync(FetchCredentialListMappingOptions options, ITwilioRestClient client = null)
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
        /// <param name="domainSid"> The domain_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialListMapping </returns> 
        public static CredentialListMappingResource Fetch(string domainSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchCredentialListMappingOptions(domainSid, sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="domainSid"> The domain_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<CredentialListMappingResource> FetchAsync(string domainSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchCredentialListMappingOptions(domainSid, sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteCredentialListMappingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.DomainSid + "/CredentialListMappings/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete CredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialListMapping </returns> 
        public static bool Delete(DeleteCredentialListMappingOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Delete CredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteCredentialListMappingOptions options, ITwilioRestClient client = null)
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
        /// <param name="domainSid"> The domain_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CredentialListMapping </returns> 
        public static bool Delete(string domainSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteCredentialListMappingOptions(domainSid, sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="domainSid"> The domain_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string domainSid, string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteCredentialListMappingOptions(domainSid, sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a CredentialListMappingResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CredentialListMappingResource object represented by the provided JSON </returns> 
        public static CredentialListMappingResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<CredentialListMappingResource>(json);
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
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The subresource_uris
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }
    
        private CredentialListMappingResource()
        {
        
        }
    }

}