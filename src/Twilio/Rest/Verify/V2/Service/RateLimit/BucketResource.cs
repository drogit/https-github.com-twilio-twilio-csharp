/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Verify
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.Verify.V2.Service.RateLimit
{
    public class BucketResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateBucketOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/RateLimits/{RateLimitSid}/Buckets";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathRateLimitSid = options.PathRateLimitSid;
            path = path.Replace("{"+"RateLimitSid"+"}", PathRateLimitSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Bucket for a Rate Limit </summary>
        /// <param name="options"> Create Bucket parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bucket </returns>
        public static BucketResource Create(CreateBucketOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Bucket for a Rate Limit </summary>
        /// <param name="options"> Create Bucket parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bucket </returns>
        public static async System.Threading.Tasks.Task<BucketResource> CreateAsync(CreateBucketOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Bucket for a Rate Limit </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="max"> Maximum number of requests permitted in during the interval. </param>
        /// <param name="interval"> Number of seconds that the rate limit will be enforced over. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bucket </returns>
        public static BucketResource Create(
                                          string pathServiceSid,
                                          string pathRateLimitSid,
                                          int? max,
                                          int? interval,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateBucketOptions(pathServiceSid, pathRateLimitSid, max, interval){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Bucket for a Rate Limit </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="max"> Maximum number of requests permitted in during the interval. </param>
        /// <param name="interval"> Number of seconds that the rate limit will be enforced over. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bucket </returns>
        public static async System.Threading.Tasks.Task<BucketResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  string pathRateLimitSid,
                                                                                  int? max,
                                                                                  int? interval,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateBucketOptions(pathServiceSid, pathRateLimitSid, max, interval){  };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a specific Bucket. </summary>
        /// <param name="options"> Delete Bucket parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bucket </returns>
        private static Request BuildDeleteRequest(DeleteBucketOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/RateLimits/{RateLimitSid}/Buckets/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathRateLimitSid = options.PathRateLimitSid;
            path = path.Replace("{"+"RateLimitSid"+"}", PathRateLimitSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Bucket. </summary>
        /// <param name="options"> Delete Bucket parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bucket </returns>
        public static bool Delete(DeleteBucketOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific Bucket. </summary>
        /// <param name="options"> Delete Bucket parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bucket </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteBucketOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific Bucket. </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Bucket. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bucket </returns>
        public static bool Delete(string pathServiceSid, string pathRateLimitSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteBucketOptions(pathServiceSid, pathRateLimitSid, pathSid)           ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific Bucket. </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Bucket. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bucket </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathRateLimitSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteBucketOptions(pathServiceSid, pathRateLimitSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchBucketOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/RateLimits/{RateLimitSid}/Buckets/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathRateLimitSid = options.PathRateLimitSid;
            path = path.Replace("{"+"RateLimitSid"+"}", PathRateLimitSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific Bucket. </summary>
        /// <param name="options"> Fetch Bucket parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bucket </returns>
        public static BucketResource Fetch(FetchBucketOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Bucket. </summary>
        /// <param name="options"> Fetch Bucket parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bucket </returns>
        public static async System.Threading.Tasks.Task<BucketResource> FetchAsync(FetchBucketOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Bucket. </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Bucket. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bucket </returns>
        public static BucketResource Fetch(
                                         string pathServiceSid, 
                                         string pathRateLimitSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchBucketOptions(pathServiceSid, pathRateLimitSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Bucket. </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Bucket. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bucket </returns>
        public static async System.Threading.Tasks.Task<BucketResource> FetchAsync(string pathServiceSid, string pathRateLimitSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchBucketOptions(pathServiceSid, pathRateLimitSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadBucketOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/RateLimits/{RateLimitSid}/Buckets";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathRateLimitSid = options.PathRateLimitSid;
            path = path.Replace("{"+"RateLimitSid"+"}", PathRateLimitSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Buckets for a Rate Limit. </summary>
        /// <param name="options"> Read Bucket parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bucket </returns>
        public static ResourceSet<BucketResource> Read(ReadBucketOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<BucketResource>.FromJson("buckets", response.Content);
            return new ResourceSet<BucketResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Buckets for a Rate Limit. </summary>
        /// <param name="options"> Read Bucket parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bucket </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BucketResource>> ReadAsync(ReadBucketOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<BucketResource>.FromJson("buckets", response.Content);
            return new ResourceSet<BucketResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Buckets for a Rate Limit. </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of Bucket </returns>
        public static ResourceSet<BucketResource> Read(
                                                     string pathServiceSid,
                                                     string pathRateLimitSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadBucketOptions(pathServiceSid, pathRateLimitSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Buckets for a Rate Limit. </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of Bucket </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BucketResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             string pathRateLimitSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadBucketOptions(pathServiceSid, pathRateLimitSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<BucketResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<BucketResource>.FromJson("buckets", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<BucketResource> NextPage(Page<BucketResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<BucketResource>.FromJson("buckets", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<BucketResource> PreviousPage(Page<BucketResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<BucketResource>.FromJson("buckets", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateBucketOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/RateLimits/{RateLimitSid}/Buckets/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathRateLimitSid = options.PathRateLimitSid;
            path = path.Replace("{"+"RateLimitSid"+"}", PathRateLimitSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update a specific Bucket. </summary>
        /// <param name="options"> Update Bucket parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bucket </returns>
        public static BucketResource Update(UpdateBucketOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a specific Bucket. </summary>
        /// <param name="options"> Update Bucket parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bucket </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<BucketResource> UpdateAsync(UpdateBucketOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update a specific Bucket. </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Bucket. </param>
        /// <param name="max"> Maximum number of requests permitted in during the interval. </param>
        /// <param name="interval"> Number of seconds that the rate limit will be enforced over. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bucket </returns>
        public static BucketResource Update(
                                          string pathServiceSid,
                                          string pathRateLimitSid,
                                          string pathSid,
                                          int? max = null,
                                          int? interval = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateBucketOptions(pathServiceSid, pathRateLimitSid, pathSid){ Max = max, Interval = interval };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update a specific Bucket. </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </param>
        /// <param name="pathRateLimitSid"> The Twilio-provided string that uniquely identifies the Rate Limit resource. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Bucket. </param>
        /// <param name="max"> Maximum number of requests permitted in during the interval. </param>
        /// <param name="interval"> Number of seconds that the rate limit will be enforced over. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bucket </returns>
        public static async System.Threading.Tasks.Task<BucketResource> UpdateAsync(
                                                                              string pathServiceSid,
                                                                              string pathRateLimitSid,
                                                                              string pathSid,
                                                                              int? max = null,
                                                                              int? interval = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateBucketOptions(pathServiceSid, pathRateLimitSid, pathSid){ Max = max, Interval = interval };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a BucketResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BucketResource object represented by the provided JSON </returns>
        public static BucketResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BucketResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> A 34 character string that uniquely identifies this Bucket. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The Twilio-provided string that uniquely identifies the Rate Limit resource. </summary> 
        [JsonProperty("rate_limit_sid")]
        public string RateLimitSid { get; private set; }

        ///<summary> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) the resource is associated with. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Rate Limit resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> Maximum number of requests permitted in during the interval. </summary> 
        [JsonProperty("max")]
        public int? Max { get; private set; }

        ///<summary> Number of seconds that the rate limit will be enforced over. </summary> 
        [JsonProperty("interval")]
        public int? Interval { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private BucketResource() {

        }
    }
}

