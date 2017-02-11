using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker 
{

    public class WorkerChannelResource : Resource 
    {
        private static Request BuildReadRequest(ReadWorkerChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Workers/" + options.WorkerSid + "/Channels",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read WorkerChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkerChannel </returns> 
        public static ResourceSet<WorkerChannelResource> Read(ReadWorkerChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<WorkerChannelResource>.FromJson("channels", response.Content);
            return new ResourceSet<WorkerChannelResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read WorkerChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkerChannel </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<WorkerChannelResource>> ReadAsync(ReadWorkerChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<WorkerChannelResource>.FromJson("channels", response.Content);
            return new ResourceSet<WorkerChannelResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkerChannel </returns> 
        public static ResourceSet<WorkerChannelResource> Read(string workspaceSid, string workerSid, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadWorkerChannelOptions(workspaceSid, workerSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkerChannel </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<WorkerChannelResource>> ReadAsync(string workspaceSid, string workerSid, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadWorkerChannelOptions(workspaceSid, workerSid){PageSize = pageSize, Limit = limit};
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
        public static Page<WorkerChannelResource> NextPage(Page<WorkerChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Taskrouter,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<WorkerChannelResource>.FromJson("channels", response.Content);
        }
    
        private static Request BuildFetchRequest(FetchWorkerChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Workers/" + options.WorkerSid + "/Channels/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch WorkerChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkerChannel </returns> 
        public static WorkerChannelResource Fetch(FetchWorkerChannelOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Fetch WorkerChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkerChannel </returns> 
        public static async System.Threading.Tasks.Task<WorkerChannelResource> FetchAsync(FetchWorkerChannelOptions options, ITwilioRestClient client = null)
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
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkerChannel </returns> 
        public static WorkerChannelResource Fetch(string workspaceSid, string workerSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchWorkerChannelOptions(workspaceSid, workerSid, sid);
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkerChannel </returns> 
        public static async System.Threading.Tasks.Task<WorkerChannelResource> FetchAsync(string workspaceSid, string workerSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchWorkerChannelOptions(workspaceSid, workerSid, sid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateWorkerChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Workers/" + options.WorkerSid + "/Channels/" + options.Sid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update WorkerChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkerChannel </returns> 
        public static WorkerChannelResource Update(UpdateWorkerChannelOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Update WorkerChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkerChannel </returns> 
        public static async System.Threading.Tasks.Task<WorkerChannelResource> UpdateAsync(UpdateWorkerChannelOptions options, ITwilioRestClient client = null)
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
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="capacity"> The capacity </param>
        /// <param name="available"> The available </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkerChannel </returns> 
        public static WorkerChannelResource Update(string workspaceSid, string workerSid, string sid, int? capacity = null, bool? available = null, ITwilioRestClient client = null)
        {
            var options = new UpdateWorkerChannelOptions(workspaceSid, workerSid, sid){Capacity = capacity, Available = available};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="capacity"> The capacity </param>
        /// <param name="available"> The available </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkerChannel </returns> 
        public static async System.Threading.Tasks.Task<WorkerChannelResource> UpdateAsync(string workspaceSid, string workerSid, string sid, int? capacity = null, bool? available = null, ITwilioRestClient client = null)
        {
            var options = new UpdateWorkerChannelOptions(workspaceSid, workerSid, sid){Capacity = capacity, Available = available};
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a WorkerChannelResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkerChannelResource object represented by the provided JSON </returns> 
        public static WorkerChannelResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<WorkerChannelResource>(json);
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
        /// The assigned_tasks
        /// </summary>
        [JsonProperty("assigned_tasks")]
        public int? AssignedTasks { get; private set; }
        /// <summary>
        /// The available
        /// </summary>
        [JsonProperty("available")]
        public bool? Available { get; private set; }
        /// <summary>
        /// The available_capacity_percentage
        /// </summary>
        [JsonProperty("available_capacity_percentage")]
        public int? AvailableCapacityPercentage { get; private set; }
        /// <summary>
        /// The configured_capacity
        /// </summary>
        [JsonProperty("configured_capacity")]
        public int? ConfiguredCapacity { get; private set; }
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
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The task_channel_sid
        /// </summary>
        [JsonProperty("task_channel_sid")]
        public string TaskChannelSid { get; private set; }
        /// <summary>
        /// The task_channel_unique_name
        /// </summary>
        [JsonProperty("task_channel_unique_name")]
        public string TaskChannelUniqueName { get; private set; }
        /// <summary>
        /// The worker_sid
        /// </summary>
        [JsonProperty("worker_sid")]
        public string WorkerSid { get; private set; }
        /// <summary>
        /// The workspace_sid
        /// </summary>
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
    
        private WorkerChannelResource()
        {
        
        }
    }

}