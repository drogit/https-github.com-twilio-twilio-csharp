/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Media
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


namespace Twilio.Rest.Media.V1
{
    public class MediaRecordingResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Processing = new StatusEnum("processing");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Deleted = new StatusEnum("deleted");
            public static readonly StatusEnum Failed = new StatusEnum("failed");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class FormatEnum : StringEnum
        {
            private FormatEnum(string value) : base(value) {}
            public FormatEnum() {}
            public static implicit operator FormatEnum(string value)
            {
                return new FormatEnum(value);
            }
            public static readonly FormatEnum Mp4 = new FormatEnum("mp4");
            public static readonly FormatEnum Webm = new FormatEnum("webm");

        }
        public sealed class OrderEnum : StringEnum
        {
            private OrderEnum(string value) : base(value) {}
            public OrderEnum() {}
            public static implicit operator OrderEnum(string value)
            {
                return new OrderEnum(value);
            }
            public static readonly OrderEnum Asc = new OrderEnum("asc");
            public static readonly OrderEnum Desc = new OrderEnum("desc");

        }

        
        /// <summary> Deletes a MediaRecording resource identified by a SID. </summary>
        /// <param name="options"> Delete MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        private static Request BuildDeleteRequest(DeleteMediaRecordingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/MediaRecordings/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Media,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Deletes a MediaRecording resource identified by a SID. </summary>
        /// <param name="options"> Delete MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        public static bool Delete(DeleteMediaRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Deletes a MediaRecording resource identified by a SID. </summary>
        /// <param name="options"> Delete MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MediaRecording </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteMediaRecordingOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Deletes a MediaRecording resource identified by a SID. </summary>
        /// <param name="pathSid"> The SID of the MediaRecording resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteMediaRecordingOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Deletes a MediaRecording resource identified by a SID. </summary>
        /// <param name="pathSid"> The SID of the MediaRecording resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MediaRecording </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteMediaRecordingOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchMediaRecordingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/MediaRecordings/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Media,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Returns a single MediaRecording resource identified by a SID. </summary>
        /// <param name="options"> Fetch MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        public static MediaRecordingResource Fetch(FetchMediaRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Returns a single MediaRecording resource identified by a SID. </summary>
        /// <param name="options"> Fetch MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MediaRecording </returns>
        public static async System.Threading.Tasks.Task<MediaRecordingResource> FetchAsync(FetchMediaRecordingOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Returns a single MediaRecording resource identified by a SID. </summary>
        /// <param name="pathSid"> The SID of the MediaRecording resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        public static MediaRecordingResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchMediaRecordingOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Returns a single MediaRecording resource identified by a SID. </summary>
        /// <param name="pathSid"> The SID of the MediaRecording resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MediaRecording </returns>
        public static async System.Threading.Tasks.Task<MediaRecordingResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchMediaRecordingOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadMediaRecordingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/MediaRecordings";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Media,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Returns a list of MediaRecordings. </summary>
        /// <param name="options"> Read MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        public static ResourceSet<MediaRecordingResource> Read(ReadMediaRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<MediaRecordingResource>.FromJson("media_recordings", response.Content);
            return new ResourceSet<MediaRecordingResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Returns a list of MediaRecordings. </summary>
        /// <param name="options"> Read MediaRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MediaRecording </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MediaRecordingResource>> ReadAsync(ReadMediaRecordingOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<MediaRecordingResource>.FromJson("media_recordings", response.Content);
            return new ResourceSet<MediaRecordingResource>(page, options, client);
        }
        #endif
        /// <summary> Returns a list of MediaRecordings. </summary>
        /// <param name="order"> The sort order of the list by `date_created`. Can be: `asc` (ascending) or `desc` (descending) with `desc` as the default. </param>
        /// <param name="status"> Status to filter by, with possible values `processing`, `completed`, `deleted`, or `failed`. </param>
        /// <param name="processorSid"> SID of a MediaProcessor to filter by. </param>
        /// <param name="sourceSid"> SID of a MediaRecording source to filter by. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of MediaRecording </returns>
        public static ResourceSet<MediaRecordingResource> Read(
                                                     MediaRecordingResource.OrderEnum order = null,
                                                     MediaRecordingResource.StatusEnum status = null,
                                                     string processorSid = null,
                                                     string sourceSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadMediaRecordingOptions(){ Order = order, Status = status, ProcessorSid = processorSid, SourceSid = sourceSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Returns a list of MediaRecordings. </summary>
        /// <param name="order"> The sort order of the list by `date_created`. Can be: `asc` (ascending) or `desc` (descending) with `desc` as the default. </param>
        /// <param name="status"> Status to filter by, with possible values `processing`, `completed`, `deleted`, or `failed`. </param>
        /// <param name="processorSid"> SID of a MediaProcessor to filter by. </param>
        /// <param name="sourceSid"> SID of a MediaRecording source to filter by. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of MediaRecording </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MediaRecordingResource>> ReadAsync(
                                                                                             MediaRecordingResource.OrderEnum order = null,
                                                                                             MediaRecordingResource.StatusEnum status = null,
                                                                                             string processorSid = null,
                                                                                             string sourceSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadMediaRecordingOptions(){ Order = order, Status = status, ProcessorSid = processorSid, SourceSid = sourceSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<MediaRecordingResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<MediaRecordingResource>.FromJson("media_recordings", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<MediaRecordingResource> NextPage(Page<MediaRecordingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<MediaRecordingResource>.FromJson("media_recordings", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<MediaRecordingResource> PreviousPage(Page<MediaRecordingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<MediaRecordingResource>.FromJson("media_recordings", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a MediaRecordingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MediaRecordingResource object represented by the provided JSON </returns>
        public static MediaRecordingResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<MediaRecordingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the MediaRecording resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The duration of the MediaRecording in seconds. </summary> 
        [JsonProperty("duration")]
        public int? Duration { get; private set; }

        
        [JsonProperty("format")]
        public MediaRecordingResource.FormatEnum Format { get; private set; }

        ///<summary> The URLs of related resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        ///<summary> The SID of the MediaProcessor resource which produced the MediaRecording. </summary> 
        [JsonProperty("processor_sid")]
        public string ProcessorSid { get; private set; }

        ///<summary> The dimensions of the video image in pixels expressed as columns (width) and rows (height). </summary> 
        [JsonProperty("resolution")]
        public string Resolution { get; private set; }

        ///<summary> The SID of the resource that generated the original media track(s) of the MediaRecording. </summary> 
        [JsonProperty("source_sid")]
        public string SourceSid { get; private set; }

        ///<summary> The unique string generated to identify the MediaRecording resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The size of the recording media in bytes. </summary> 
        [JsonProperty("media_size")]
        public long? MediaSize { get; private set; }

        
        [JsonProperty("status")]
        public MediaRecordingResource.StatusEnum Status { get; private set; }

        ///<summary> The URL to which Twilio will send asynchronous webhook requests for every MediaRecording event. See [Status Callbacks](/docs/live/api/status-callbacks) for more details. </summary> 
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }

        ///<summary> The HTTP method Twilio should use to call the `status_callback` URL. Can be `POST` or `GET` and the default is `POST`. </summary> 
        [JsonProperty("status_callback_method")]
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private MediaRecordingResource() {

        }
    }
}

