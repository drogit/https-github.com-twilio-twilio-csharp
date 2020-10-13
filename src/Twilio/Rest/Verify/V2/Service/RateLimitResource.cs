/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// RateLimitResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Verify.V2.Service
{

    public class RateLimitResource : Resource
    {
        private static Request BuildCreateRequest(CreateRateLimitOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/RateLimits",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Create a new Rate Limit for a Service
        /// </summary>
        /// <param name="options"> Create RateLimit parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RateLimit </returns>
        public static RateLimitResource Create(CreateRateLimitOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Rate Limit for a Service
        /// </summary>
        /// <param name="options"> Create RateLimit parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RateLimit </returns>
        public static async System.Threading.Tasks.Task<RateLimitResource> CreateAsync(CreateRateLimitOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Rate Limit for a Service
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="uniqueName"> A unique, developer assigned name of this Rate Limit. </param>
        /// <param name="description"> Description of this Rate Limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RateLimit </returns>
        public static RateLimitResource Create(string pathServiceSid,
                                               string uniqueName,
                                               string description = null,
                                               ITwilioRestClient client = null)
        {
            var options = new CreateRateLimitOptions(pathServiceSid, uniqueName){Description = description};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Rate Limit for a Service
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="uniqueName"> A unique, developer assigned name of this Rate Limit. </param>
        /// <param name="description"> Description of this Rate Limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RateLimit </returns>
        public static async System.Threading.Tasks.Task<RateLimitResource> CreateAsync(string pathServiceSid,
                                                                                       string uniqueName,
                                                                                       string description = null,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new CreateRateLimitOptions(pathServiceSid, uniqueName){Description = description};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateRateLimitOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/RateLimits/" + options.PathSid + "",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Update a specific Rate Limit.
        /// </summary>
        /// <param name="options"> Update RateLimit parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RateLimit </returns>
        public static RateLimitResource Update(UpdateRateLimitOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update a specific Rate Limit.
        /// </summary>
        /// <param name="options"> Update RateLimit parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RateLimit </returns>
        public static async System.Threading.Tasks.Task<RateLimitResource> UpdateAsync(UpdateRateLimitOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update a specific Rate Limit.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="description"> Description of this Rate Limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RateLimit </returns>
        public static RateLimitResource Update(string pathServiceSid,
                                               string pathSid,
                                               string description = null,
                                               ITwilioRestClient client = null)
        {
            var options = new UpdateRateLimitOptions(pathServiceSid, pathSid){Description = description};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update a specific Rate Limit.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="description"> Description of this Rate Limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RateLimit </returns>
        public static async System.Threading.Tasks.Task<RateLimitResource> UpdateAsync(string pathServiceSid,
                                                                                       string pathSid,
                                                                                       string description = null,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new UpdateRateLimitOptions(pathServiceSid, pathSid){Description = description};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchRateLimitOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/RateLimits/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Fetch a specific Rate Limit.
        /// </summary>
        /// <param name="options"> Fetch RateLimit parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RateLimit </returns>
        public static RateLimitResource Fetch(FetchRateLimitOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Rate Limit.
        /// </summary>
        /// <param name="options"> Fetch RateLimit parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RateLimit </returns>
        public static async System.Threading.Tasks.Task<RateLimitResource> FetchAsync(FetchRateLimitOptions options,
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific Rate Limit.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RateLimit </returns>
        public static RateLimitResource Fetch(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchRateLimitOptions(pathServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Rate Limit.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RateLimit </returns>
        public static async System.Threading.Tasks.Task<RateLimitResource> FetchAsync(string pathServiceSid,
                                                                                      string pathSid,
                                                                                      ITwilioRestClient client = null)
        {
            var options = new FetchRateLimitOptions(pathServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadRateLimitOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/RateLimits",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Retrieve a list of all Rate Limits for a service.
        /// </summary>
        /// <param name="options"> Read RateLimit parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RateLimit </returns>
        public static ResourceSet<RateLimitResource> Read(ReadRateLimitOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<RateLimitResource>.FromJson("rate_limits", response.Content);
            return new ResourceSet<RateLimitResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Rate Limits for a service.
        /// </summary>
        /// <param name="options"> Read RateLimit parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RateLimit </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<RateLimitResource>> ReadAsync(ReadRateLimitOptions options,
                                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<RateLimitResource>.FromJson("rate_limits", response.Content);
            return new ResourceSet<RateLimitResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Rate Limits for a service.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RateLimit </returns>
        public static ResourceSet<RateLimitResource> Read(string pathServiceSid,
                                                          int? pageSize = null,
                                                          long? limit = null,
                                                          ITwilioRestClient client = null)
        {
            var options = new ReadRateLimitOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Rate Limits for a service.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RateLimit </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<RateLimitResource>> ReadAsync(string pathServiceSid,
                                                                                                  int? pageSize = null,
                                                                                                  long? limit = null,
                                                                                                  ITwilioRestClient client = null)
        {
            var options = new ReadRateLimitOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<RateLimitResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<RateLimitResource>.FromJson("rate_limits", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<RateLimitResource> NextPage(Page<RateLimitResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Verify)
            );

            var response = client.Request(request);
            return Page<RateLimitResource>.FromJson("rate_limits", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<RateLimitResource> PreviousPage(Page<RateLimitResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Verify)
            );

            var response = client.Request(request);
            return Page<RateLimitResource>.FromJson("rate_limits", response.Content);
        }

        private static Request BuildDeleteRequest(DeleteRateLimitOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/RateLimits/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Delete a specific Rate Limit.
        /// </summary>
        /// <param name="options"> Delete RateLimit parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RateLimit </returns>
        public static bool Delete(DeleteRateLimitOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Rate Limit.
        /// </summary>
        /// <param name="options"> Delete RateLimit parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RateLimit </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteRateLimitOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a specific Rate Limit.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RateLimit </returns>
        public static bool Delete(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteRateLimitOptions(pathServiceSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Rate Limit.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service that the resource is associated with </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RateLimit </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid,
                                                                          string pathSid,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteRateLimitOptions(pathServiceSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a RateLimitResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RateLimitResource object represented by the provided JSON </returns>
        public static RateLimitResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<RateLimitResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Rate Limit.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Service that the resource is associated with
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// A unique, developer assigned name of this Rate Limit.
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// Description of this Rate Limit
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The URLs of related resources
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private RateLimitResource()
        {

        }
    }

}