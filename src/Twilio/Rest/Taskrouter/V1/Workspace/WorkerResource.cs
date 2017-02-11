using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    public class WorkerResource : Resource 
    {
        private static Request BuildReadRequest(ReadWorkerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Workers",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns> 
        public static ResourceSet<WorkerResource> Read(ReadWorkerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<WorkerResource>.FromJson("workers", response.Content);
            return new ResourceSet<WorkerResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<WorkerResource>> ReadAsync(ReadWorkerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<WorkerResource>.FromJson("workers", response.Content);
            return new ResourceSet<WorkerResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="activityName"> The activity_name </param>
        /// <param name="activitySid"> The activity_sid </param>
        /// <param name="available"> The available </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="targetWorkersExpression"> The target_workers_expression </param>
        /// <param name="taskQueueName"> The task_queue_name </param>
        /// <param name="taskQueueSid"> The task_queue_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns> 
        public static ResourceSet<WorkerResource> Read(string workspaceSid, string activityName = null, string activitySid = null, string available = null, string friendlyName = null, string targetWorkersExpression = null, string taskQueueName = null, string taskQueueSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadWorkerOptions(workspaceSid){ActivityName = activityName, ActivitySid = activitySid, Available = available, FriendlyName = friendlyName, TargetWorkersExpression = targetWorkersExpression, TaskQueueName = taskQueueName, TaskQueueSid = taskQueueSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="activityName"> The activity_name </param>
        /// <param name="activitySid"> The activity_sid </param>
        /// <param name="available"> The available </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="targetWorkersExpression"> The target_workers_expression </param>
        /// <param name="taskQueueName"> The task_queue_name </param>
        /// <param name="taskQueueSid"> The task_queue_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<WorkerResource>> ReadAsync(string workspaceSid, string activityName = null, string activitySid = null, string available = null, string friendlyName = null, string targetWorkersExpression = null, string taskQueueName = null, string taskQueueSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadWorkerOptions(workspaceSid){ActivityName = activityName, ActivitySid = activitySid, Available = available, FriendlyName = friendlyName, TargetWorkersExpression = targetWorkersExpression, TaskQueueName = taskQueueName, TaskQueueSid = taskQueueSid, PageSize = pageSize, Limit = limit};
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
        public static Page<WorkerResource> NextPage(Page<WorkerResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Taskrouter,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<WorkerResource>.FromJson("workers", response.Content);
        }
    
        private static Request BuildCreateRequest(CreateWorkerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Workers",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns> 
        public static WorkerResource Create(CreateWorkerOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Create Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns> 
        public static async System.Threading.Tasks.Task<WorkerResource> CreateAsync(CreateWorkerOptions options, ITwilioRestClient client = null)
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
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="activitySid"> The activity_sid </param>
        /// <param name="attributes"> The attributes </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns> 
        public static WorkerResource Create(string workspaceSid, string friendlyName, string activitySid = null, string attributes = null, ITwilioRestClient client = null)
        {
            var options = new CreateWorkerOptions(workspaceSid, friendlyName){ActivitySid = activitySid, Attributes = attributes};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="activitySid"> The activity_sid </param>
        /// <param name="attributes"> The attributes </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns> 
        public static async System.Threading.Tasks.Task<WorkerResource> CreateAsync(string workspaceSid, string friendlyName, string activitySid = null, string attributes = null, ITwilioRestClient client = null)
        {
            var options = new CreateWorkerOptions(workspaceSid, friendlyName){ActivitySid = activitySid, Attributes = attributes};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildFetchRequest(FetchWorkerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Workers/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns> 
        public static WorkerResource Fetch(FetchWorkerOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Fetch Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns> 
        public static async System.Threading.Tasks.Task<WorkerResource> FetchAsync(FetchWorkerOptions options, ITwilioRestClient client = null)
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
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns> 
        public static WorkerResource Fetch(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchWorkerOptions(workspaceSid, sid);
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns> 
        public static async System.Threading.Tasks.Task<WorkerResource> FetchAsync(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchWorkerOptions(workspaceSid, sid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateWorkerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Workers/" + options.Sid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns> 
        public static WorkerResource Update(UpdateWorkerOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Update Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns> 
        public static async System.Threading.Tasks.Task<WorkerResource> UpdateAsync(UpdateWorkerOptions options, ITwilioRestClient client = null)
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
        /// <param name="sid"> The sid </param>
        /// <param name="activitySid"> The activity_sid </param>
        /// <param name="attributes"> The attributes </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns> 
        public static WorkerResource Update(string workspaceSid, string sid, string activitySid = null, string attributes = null, string friendlyName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateWorkerOptions(workspaceSid, sid){ActivitySid = activitySid, Attributes = attributes, FriendlyName = friendlyName};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="activitySid"> The activity_sid </param>
        /// <param name="attributes"> The attributes </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns> 
        public static async System.Threading.Tasks.Task<WorkerResource> UpdateAsync(string workspaceSid, string sid, string activitySid = null, string attributes = null, string friendlyName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateWorkerOptions(workspaceSid, sid){ActivitySid = activitySid, Attributes = attributes, FriendlyName = friendlyName};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteWorkerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Workers/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns> 
        public static bool Delete(DeleteWorkerOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Delete Worker parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteWorkerOptions options, ITwilioRestClient client = null)
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
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Worker </returns> 
        public static bool Delete(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new DeleteWorkerOptions(workspaceSid, sid);
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Worker </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new DeleteWorkerOptions(workspaceSid, sid);
            return await DeleteAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a WorkerResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkerResource object represented by the provided JSON </returns> 
        public static WorkerResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<WorkerResource>(json);
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
        /// The activity_name
        /// </summary>
        [JsonProperty("activity_name")]
        public string ActivityName { get; private set; }
        /// <summary>
        /// The activity_sid
        /// </summary>
        [JsonProperty("activity_sid")]
        public string ActivitySid { get; private set; }
        /// <summary>
        /// The attributes
        /// </summary>
        [JsonProperty("attributes")]
        public string Attributes { get; private set; }
        /// <summary>
        /// The available
        /// </summary>
        [JsonProperty("available")]
        public bool? Available { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_status_changed
        /// </summary>
        [JsonProperty("date_status_changed")]
        public DateTime? DateStatusChanged { get; private set; }
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
        /// The workspace_sid
        /// </summary>
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
    
        private WorkerResource()
        {
        
        }
    }

}