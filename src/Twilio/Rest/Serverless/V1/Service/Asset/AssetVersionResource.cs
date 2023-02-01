/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Serverless
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
using Twilio.Types;


namespace Twilio.Rest.Serverless.V1.Service.Asset
{
    public class AssetVersionResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class VisibilityEnum : StringEnum
        {
            private VisibilityEnum(string value) : base(value) {}
            public VisibilityEnum() {}
            public static implicit operator VisibilityEnum(string value)
            {
                return new VisibilityEnum(value);
            }
            public static readonly VisibilityEnum Public = new VisibilityEnum("public");
            public static readonly VisibilityEnum Private = new VisibilityEnum("private");
            public static readonly VisibilityEnum Protected = new VisibilityEnum("protected");

        }

        
        private static Request BuildFetchRequest(FetchAssetVersionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Assets/{AssetSid}/Versions/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathAssetSid = options.PathAssetSid;
            path = path.Replace("{"+"AssetSid"+"}", PathAssetSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve a specific Asset Version. </summary>
        /// <param name="options"> Fetch AssetVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssetVersion </returns>
        public static AssetVersionResource Fetch(FetchAssetVersionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve a specific Asset Version. </summary>
        /// <param name="options"> Fetch AssetVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssetVersion </returns>
        public static async System.Threading.Tasks.Task<AssetVersionResource> FetchAsync(FetchAssetVersionOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve a specific Asset Version. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Asset Version resource from. </param>
        /// <param name="pathAssetSid"> The SID of the Asset resource that is the parent of the Asset Version resource to fetch. </param>
        /// <param name="pathSid"> The SID of the Asset Version resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssetVersion </returns>
        public static AssetVersionResource Fetch(
                                         string pathServiceSid, 
                                         string pathAssetSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchAssetVersionOptions(pathServiceSid, pathAssetSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a specific Asset Version. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Asset Version resource from. </param>
        /// <param name="pathAssetSid"> The SID of the Asset resource that is the parent of the Asset Version resource to fetch. </param>
        /// <param name="pathSid"> The SID of the Asset Version resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssetVersion </returns>
        public static async System.Threading.Tasks.Task<AssetVersionResource> FetchAsync(string pathServiceSid, string pathAssetSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchAssetVersionOptions(pathServiceSid, pathAssetSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadAssetVersionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Assets/{AssetSid}/Versions";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathAssetSid = options.PathAssetSid;
            path = path.Replace("{"+"AssetSid"+"}", PathAssetSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Asset Versions. </summary>
        /// <param name="options"> Read AssetVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssetVersion </returns>
        public static ResourceSet<AssetVersionResource> Read(ReadAssetVersionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AssetVersionResource>.FromJson("asset_versions", response.Content);
            return new ResourceSet<AssetVersionResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Asset Versions. </summary>
        /// <param name="options"> Read AssetVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssetVersion </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AssetVersionResource>> ReadAsync(ReadAssetVersionOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AssetVersionResource>.FromJson("asset_versions", response.Content);
            return new ResourceSet<AssetVersionResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Asset Versions. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Asset Version resource from. </param>
        /// <param name="pathAssetSid"> The SID of the Asset resource that is the parent of the Asset Version resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of AssetVersion </returns>
        public static ResourceSet<AssetVersionResource> Read(
                                                     string pathServiceSid,
                                                     string pathAssetSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadAssetVersionOptions(pathServiceSid, pathAssetSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Asset Versions. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Asset Version resource from. </param>
        /// <param name="pathAssetSid"> The SID of the Asset resource that is the parent of the Asset Version resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of AssetVersion </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AssetVersionResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             string pathAssetSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadAssetVersionOptions(pathServiceSid, pathAssetSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AssetVersionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AssetVersionResource>.FromJson("asset_versions", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AssetVersionResource> NextPage(Page<AssetVersionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AssetVersionResource>.FromJson("asset_versions", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AssetVersionResource> PreviousPage(Page<AssetVersionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AssetVersionResource>.FromJson("asset_versions", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a AssetVersionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AssetVersionResource object represented by the provided JSON </returns>
        public static AssetVersionResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AssetVersionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that we created to identify the Asset Version resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Asset Version resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Service that the Asset Version resource is associated with. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The SID of the Asset resource that is the parent of the Asset Version. </summary> 
        [JsonProperty("asset_sid")]
        public string AssetSid { get; private set; }

        ///<summary> The URL-friendly string by which the Asset Version can be referenced. It can be a maximum of 255 characters. All paths begin with a forward slash ('/'). If an Asset Version creation request is submitted with a path not containing a leading slash, the path will automatically be prepended with one. </summary> 
        [JsonProperty("path")]
        public string Path { get; private set; }

        
        [JsonProperty("visibility")]
        public AssetVersionResource.VisibilityEnum Visibility { get; private set; }

        ///<summary> The date and time in GMT when the Asset Version resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The absolute URL of the Asset Version resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private AssetVersionResource() {

        }
    }
}

