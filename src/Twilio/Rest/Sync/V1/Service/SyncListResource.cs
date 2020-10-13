/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// SyncListResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Sync.V1.Service
{

    public class SyncListResource : Resource
    {
        private static Request BuildFetchRequest(FetchSyncListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Lists/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch SyncList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncList </returns>
        public static SyncListResource Fetch(FetchSyncListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch SyncList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncList </returns>
        public static async System.Threading.Tasks.Task<SyncListResource> FetchAsync(FetchSyncListOptions options,
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List resource to fetch </param>
        /// <param name="pathSid"> The SID of the Sync List resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncList </returns>
        public static SyncListResource Fetch(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchSyncListOptions(pathServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List resource to fetch </param>
        /// <param name="pathSid"> The SID of the Sync List resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncList </returns>
        public static async System.Threading.Tasks.Task<SyncListResource> FetchAsync(string pathServiceSid,
                                                                                     string pathSid,
                                                                                     ITwilioRestClient client = null)
        {
            var options = new FetchSyncListOptions(pathServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteSyncListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Lists/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete SyncList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncList </returns>
        public static bool Delete(DeleteSyncListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete SyncList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncList </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSyncListOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List resource to delete </param>
        /// <param name="pathSid"> The SID of the Sync List resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncList </returns>
        public static bool Delete(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteSyncListOptions(pathServiceSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List resource to delete </param>
        /// <param name="pathSid"> The SID of the Sync List resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncList </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid,
                                                                          string pathSid,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteSyncListOptions(pathServiceSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateSyncListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Lists",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create SyncList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncList </returns>
        public static SyncListResource Create(CreateSyncListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create SyncList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncList </returns>
        public static async System.Threading.Tasks.Task<SyncListResource> CreateAsync(CreateSyncListOptions options,
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service  to create the new Sync List in </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource </param>
        /// <param name="ttl"> Alias for collection_ttl </param>
        /// <param name="collectionTtl"> How long, in seconds, before the Sync List expires and is deleted </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncList </returns>
        public static SyncListResource Create(string pathServiceSid,
                                              string uniqueName = null,
                                              int? ttl = null,
                                              int? collectionTtl = null,
                                              ITwilioRestClient client = null)
        {
            var options = new CreateSyncListOptions(pathServiceSid){UniqueName = uniqueName, Ttl = ttl, CollectionTtl = collectionTtl};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service  to create the new Sync List in </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource </param>
        /// <param name="ttl"> Alias for collection_ttl </param>
        /// <param name="collectionTtl"> How long, in seconds, before the Sync List expires and is deleted </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncList </returns>
        public static async System.Threading.Tasks.Task<SyncListResource> CreateAsync(string pathServiceSid,
                                                                                      string uniqueName = null,
                                                                                      int? ttl = null,
                                                                                      int? collectionTtl = null,
                                                                                      ITwilioRestClient client = null)
        {
            var options = new CreateSyncListOptions(pathServiceSid){UniqueName = uniqueName, Ttl = ttl, CollectionTtl = collectionTtl};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateSyncListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Lists/" + options.PathSid + "",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update SyncList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncList </returns>
        public static SyncListResource Update(UpdateSyncListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update SyncList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncList </returns>
        public static async System.Threading.Tasks.Task<SyncListResource> UpdateAsync(UpdateSyncListOptions options,
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List resource to update </param>
        /// <param name="pathSid"> The SID of the Sync List resource to update </param>
        /// <param name="ttl"> An alias for collection_ttl </param>
        /// <param name="collectionTtl"> How long, in seconds, before the Sync List expires and is deleted </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncList </returns>
        public static SyncListResource Update(string pathServiceSid,
                                              string pathSid,
                                              int? ttl = null,
                                              int? collectionTtl = null,
                                              ITwilioRestClient client = null)
        {
            var options = new UpdateSyncListOptions(pathServiceSid, pathSid){Ttl = ttl, CollectionTtl = collectionTtl};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List resource to update </param>
        /// <param name="pathSid"> The SID of the Sync List resource to update </param>
        /// <param name="ttl"> An alias for collection_ttl </param>
        /// <param name="collectionTtl"> How long, in seconds, before the Sync List expires and is deleted </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncList </returns>
        public static async System.Threading.Tasks.Task<SyncListResource> UpdateAsync(string pathServiceSid,
                                                                                      string pathSid,
                                                                                      int? ttl = null,
                                                                                      int? collectionTtl = null,
                                                                                      ITwilioRestClient client = null)
        {
            var options = new UpdateSyncListOptions(pathServiceSid, pathSid){Ttl = ttl, CollectionTtl = collectionTtl};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadSyncListOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Lists",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read SyncList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncList </returns>
        public static ResourceSet<SyncListResource> Read(ReadSyncListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<SyncListResource>.FromJson("lists", response.Content);
            return new ResourceSet<SyncListResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read SyncList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncList </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SyncListResource>> ReadAsync(ReadSyncListOptions options,
                                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SyncListResource>.FromJson("lists", response.Content);
            return new ResourceSet<SyncListResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncList </returns>
        public static ResourceSet<SyncListResource> Read(string pathServiceSid,
                                                         int? pageSize = null,
                                                         long? limit = null,
                                                         ITwilioRestClient client = null)
        {
            var options = new ReadSyncListOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncList </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SyncListResource>> ReadAsync(string pathServiceSid,
                                                                                                 int? pageSize = null,
                                                                                                 long? limit = null,
                                                                                                 ITwilioRestClient client = null)
        {
            var options = new ReadSyncListOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SyncListResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SyncListResource>.FromJson("lists", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SyncListResource> NextPage(Page<SyncListResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Sync)
            );

            var response = client.Request(request);
            return Page<SyncListResource>.FromJson("lists", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SyncListResource> PreviousPage(Page<SyncListResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Sync)
            );

            var response = client.Request(request);
            return Page<SyncListResource>.FromJson("lists", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a SyncListResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SyncListResource object represented by the provided JSON </returns>
        public static SyncListResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SyncListResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// An application-defined string that uniquely identifies the resource
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The SID of the Sync Service that the resource is associated with
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The absolute URL of the Sync List resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The URLs of the Sync List's nested resources
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
        /// <summary>
        /// The current revision of the Sync List, represented as a string
        /// </summary>
        [JsonProperty("revision")]
        public string Revision { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the Sync List expires
        /// </summary>
        [JsonProperty("date_expires")]
        public DateTime? DateExpires { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The identity of the Sync List's creator
        /// </summary>
        [JsonProperty("created_by")]
        public string CreatedBy { get; private set; }

        private SyncListResource()
        {

        }
    }

}