/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// FunctionVersionResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Serverless.V1.Service.Function 
{

    public class FunctionVersionResource : Resource 
    {
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

        private static Request BuildReadRequest(ReadFunctionVersionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Functions/" + options.PathFunctionSid + "/Versions",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read FunctionVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FunctionVersion </returns> 
        public static ResourceSet<FunctionVersionResource> Read(ReadFunctionVersionOptions options, 
                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<FunctionVersionResource>.FromJson("function_versions", response.Content);
            return new ResourceSet<FunctionVersionResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read FunctionVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FunctionVersion </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<FunctionVersionResource>> ReadAsync(ReadFunctionVersionOptions options, 
                                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FunctionVersionResource>.FromJson("function_versions", response.Content);
            return new ResourceSet<FunctionVersionResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathFunctionSid"> The function_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FunctionVersion </returns> 
        public static ResourceSet<FunctionVersionResource> Read(string pathServiceSid, 
                                                                string pathFunctionSid, 
                                                                int? pageSize = null, 
                                                                long? limit = null, 
                                                                ITwilioRestClient client = null)
        {
            var options = new ReadFunctionVersionOptions(pathServiceSid, pathFunctionSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathFunctionSid"> The function_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FunctionVersion </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<FunctionVersionResource>> ReadAsync(string pathServiceSid, 
                                                                                                        string pathFunctionSid, 
                                                                                                        int? pageSize = null, 
                                                                                                        long? limit = null, 
                                                                                                        ITwilioRestClient client = null)
        {
            var options = new ReadFunctionVersionOptions(pathServiceSid, pathFunctionSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<FunctionVersionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FunctionVersionResource>.FromJson("function_versions", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<FunctionVersionResource> NextPage(Page<FunctionVersionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FunctionVersionResource>.FromJson("function_versions", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<FunctionVersionResource> PreviousPage(Page<FunctionVersionResource> page, 
                                                                 ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FunctionVersionResource>.FromJson("function_versions", response.Content);
        }

        private static Request BuildFetchRequest(FetchFunctionVersionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Functions/" + options.PathFunctionSid + "/Versions/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch FunctionVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FunctionVersion </returns> 
        public static FunctionVersionResource Fetch(FetchFunctionVersionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch FunctionVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FunctionVersion </returns> 
        public static async System.Threading.Tasks.Task<FunctionVersionResource> FetchAsync(FetchFunctionVersionOptions options, 
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
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathFunctionSid"> The function_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FunctionVersion </returns> 
        public static FunctionVersionResource Fetch(string pathServiceSid, 
                                                    string pathFunctionSid, 
                                                    string pathSid, 
                                                    ITwilioRestClient client = null)
        {
            var options = new FetchFunctionVersionOptions(pathServiceSid, pathFunctionSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathFunctionSid"> The function_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FunctionVersion </returns> 
        public static async System.Threading.Tasks.Task<FunctionVersionResource> FetchAsync(string pathServiceSid, 
                                                                                            string pathFunctionSid, 
                                                                                            string pathSid, 
                                                                                            ITwilioRestClient client = null)
        {
            var options = new FetchFunctionVersionOptions(pathServiceSid, pathFunctionSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateFunctionVersionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Functions/" + options.PathFunctionSid + "/Versions",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create FunctionVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FunctionVersion </returns> 
        public static FunctionVersionResource Create(CreateFunctionVersionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create FunctionVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FunctionVersion </returns> 
        public static async System.Threading.Tasks.Task<FunctionVersionResource> CreateAsync(CreateFunctionVersionOptions options, 
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
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathFunctionSid"> The function_sid </param>
        /// <param name="path"> The path </param>
        /// <param name="visibility"> The visibility </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FunctionVersion </returns> 
        public static FunctionVersionResource Create(string pathServiceSid, 
                                                     string pathFunctionSid, 
                                                     string path, 
                                                     FunctionVersionResource.VisibilityEnum visibility, 
                                                     ITwilioRestClient client = null)
        {
            var options = new CreateFunctionVersionOptions(pathServiceSid, pathFunctionSid, path, visibility);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathFunctionSid"> The function_sid </param>
        /// <param name="path"> The path </param>
        /// <param name="visibility"> The visibility </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FunctionVersion </returns> 
        public static async System.Threading.Tasks.Task<FunctionVersionResource> CreateAsync(string pathServiceSid, 
                                                                                             string pathFunctionSid, 
                                                                                             string path, 
                                                                                             FunctionVersionResource.VisibilityEnum visibility, 
                                                                                             ITwilioRestClient client = null)
        {
            var options = new CreateFunctionVersionOptions(pathServiceSid, pathFunctionSid, path, visibility);
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a FunctionVersionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FunctionVersionResource object represented by the provided JSON </returns> 
        public static FunctionVersionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FunctionVersionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The service_sid
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The function_sid
        /// </summary>
        [JsonProperty("function_sid")]
        public string FunctionSid { get; private set; }
        /// <summary>
        /// The path
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; private set; }
        /// <summary>
        /// The pre_signed_upload_url
        /// </summary>
        [JsonProperty("pre_signed_upload_url")]
        public object PreSignedUploadUrl { get; private set; }
        /// <summary>
        /// The visibility
        /// </summary>
        [JsonProperty("visibility")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FunctionVersionResource.VisibilityEnum Visibility { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private FunctionVersionResource()
        {

        }
    }

}