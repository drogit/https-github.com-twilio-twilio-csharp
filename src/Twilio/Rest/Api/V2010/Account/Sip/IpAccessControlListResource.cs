using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Sip 
{

    public class IpAccessControlListResource : Resource 
    {
        private static Request BuildReadRequest(ReadIpAccessControlListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SIP/IpAccessControlLists.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of ip-access-control-lists belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns> 
        public static ResourceSet<IpAccessControlListResource> Read(ReadIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<IpAccessControlListResource>.FromJson("ip_access_control_lists", response.Content);
            return new ResourceSet<IpAccessControlListResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of ip-access-control-lists belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<IpAccessControlListResource>> ReadAsync(ReadIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<IpAccessControlListResource>.FromJson("ip_access_control_lists", response.Content);
            return new ResourceSet<IpAccessControlListResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of ip-access-control-lists belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns> 
        public static ResourceSet<IpAccessControlListResource> Read(string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadIpAccessControlListOptions{AccountSid = accountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of ip-access-control-lists belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<IpAccessControlListResource>> ReadAsync(string accountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadIpAccessControlListOptions{AccountSid = accountSid, PageSize = pageSize, Limit = limit};
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
        public static Page<IpAccessControlListResource> NextPage(Page<IpAccessControlListResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<IpAccessControlListResource>.FromJson("ip_access_control_lists", response.Content);
        }
    
        private static Request BuildCreateRequest(CreateIpAccessControlListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SIP/IpAccessControlLists.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Create a new IpAccessControlList resource
        /// </summary>
        ///
        /// <param name="options"> Create IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns> 
        public static IpAccessControlListResource Create(CreateIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Create a new IpAccessControlList resource
        /// </summary>
        ///
        /// <param name="options"> Create IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns> 
        public static async System.Threading.Tasks.Task<IpAccessControlListResource> CreateAsync(CreateIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Create a new IpAccessControlList resource
        /// </summary>
        ///
        /// <param name="friendlyName"> A human readable description of this resource </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns> 
        public static IpAccessControlListResource Create(string friendlyName, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new CreateIpAccessControlListOptions(friendlyName){AccountSid = accountSid};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Create a new IpAccessControlList resource
        /// </summary>
        ///
        /// <param name="friendlyName"> A human readable description of this resource </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns> 
        public static async System.Threading.Tasks.Task<IpAccessControlListResource> CreateAsync(string friendlyName, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new CreateIpAccessControlListOptions(friendlyName){AccountSid = accountSid};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildFetchRequest(FetchIpAccessControlListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SIP/IpAccessControlLists/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch a specific instance of an IpAccessControlList
        /// </summary>
        ///
        /// <param name="options"> Fetch IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns> 
        public static IpAccessControlListResource Fetch(FetchIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch a specific instance of an IpAccessControlList
        /// </summary>
        ///
        /// <param name="options"> Fetch IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns> 
        public static async System.Threading.Tasks.Task<IpAccessControlListResource> FetchAsync(FetchIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch a specific instance of an IpAccessControlList
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique ip-access-control-list Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns> 
        public static IpAccessControlListResource Fetch(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchIpAccessControlListOptions(sid){AccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch a specific instance of an IpAccessControlList
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique ip-access-control-list Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns> 
        public static async System.Threading.Tasks.Task<IpAccessControlListResource> FetchAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchIpAccessControlListOptions(sid){AccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateIpAccessControlListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SIP/IpAccessControlLists/" + options.Sid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Rename an IpAccessControlList
        /// </summary>
        ///
        /// <param name="options"> Update IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns> 
        public static IpAccessControlListResource Update(UpdateIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Rename an IpAccessControlList
        /// </summary>
        ///
        /// <param name="options"> Update IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns> 
        public static async System.Threading.Tasks.Task<IpAccessControlListResource> UpdateAsync(UpdateIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Rename an IpAccessControlList
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="friendlyName"> A human readable description of this resource </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns> 
        public static IpAccessControlListResource Update(string sid, string friendlyName, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new UpdateIpAccessControlListOptions(sid, friendlyName){AccountSid = accountSid};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Rename an IpAccessControlList
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="friendlyName"> A human readable description of this resource </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns> 
        public static async System.Threading.Tasks.Task<IpAccessControlListResource> UpdateAsync(string sid, string friendlyName, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new UpdateIpAccessControlListOptions(sid, friendlyName){AccountSid = accountSid};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteIpAccessControlListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/SIP/IpAccessControlLists/" + options.Sid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Delete an IpAccessControlList from the requested account
        /// </summary>
        ///
        /// <param name="options"> Delete IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns> 
        public static bool Delete(DeleteIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// Delete an IpAccessControlList from the requested account
        /// </summary>
        ///
        /// <param name="options"> Delete IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// Delete an IpAccessControlList from the requested account
        /// </summary>
        ///
        /// <param name="sid"> Delete by unique ip-access-control-list Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns> 
        public static bool Delete(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteIpAccessControlListOptions(sid){AccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Delete an IpAccessControlList from the requested account
        /// </summary>
        ///
        /// <param name="sid"> Delete by unique ip-access-control-list Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteIpAccessControlListOptions(sid){AccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a IpAccessControlListResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> IpAccessControlListResource object represented by the provided JSON </returns> 
        public static IpAccessControlListResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<IpAccessControlListResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// A string that uniquely identifies this resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The date this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The subresource_uris
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }
        /// <summary>
        /// The URI for this resource
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
    
        private IpAccessControlListResource()
        {
        
        }
    }

}