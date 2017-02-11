using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    public class TaskResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
        
            public static readonly StatusEnum Pending = new StatusEnum("pending");
            public static readonly StatusEnum Reserved = new StatusEnum("reserved");
            public static readonly StatusEnum Assigned = new StatusEnum("assigned");
            public static readonly StatusEnum Canceled = new StatusEnum("canceled");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
        }
    
        private static Request BuildFetchRequest(FetchTaskOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Tasks/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Task parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Task </returns> 
        public static TaskResource Fetch(FetchTaskOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Fetch Task parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Task </returns> 
        public static async System.Threading.Tasks.Task<TaskResource> FetchAsync(FetchTaskOptions options, ITwilioRestClient client = null)
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
        /// <returns> A single instance of Task </returns> 
        public static TaskResource Fetch(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchTaskOptions(workspaceSid, sid);
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
        /// <returns> Task that resolves to A single instance of Task </returns> 
        public static async System.Threading.Tasks.Task<TaskResource> FetchAsync(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchTaskOptions(workspaceSid, sid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateTaskOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Tasks/" + options.Sid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Task parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Task </returns> 
        public static TaskResource Update(UpdateTaskOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Update Task parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Task </returns> 
        public static async System.Threading.Tasks.Task<TaskResource> UpdateAsync(UpdateTaskOptions options, ITwilioRestClient client = null)
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
        /// <param name="attributes"> The attributes </param>
        /// <param name="assignmentStatus"> The assignment_status </param>
        /// <param name="reason"> The reason </param>
        /// <param name="priority"> The priority </param>
        /// <param name="taskChannel"> The task_channel </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Task </returns> 
        public static TaskResource Update(string workspaceSid, string sid, string attributes = null, TaskResource.StatusEnum assignmentStatus = null, string reason = null, int? priority = null, string taskChannel = null, ITwilioRestClient client = null)
        {
            var options = new UpdateTaskOptions(workspaceSid, sid){Attributes = attributes, AssignmentStatus = assignmentStatus, Reason = reason, Priority = priority, TaskChannel = taskChannel};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="attributes"> The attributes </param>
        /// <param name="assignmentStatus"> The assignment_status </param>
        /// <param name="reason"> The reason </param>
        /// <param name="priority"> The priority </param>
        /// <param name="taskChannel"> The task_channel </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Task </returns> 
        public static async System.Threading.Tasks.Task<TaskResource> UpdateAsync(string workspaceSid, string sid, string attributes = null, TaskResource.StatusEnum assignmentStatus = null, string reason = null, int? priority = null, string taskChannel = null, ITwilioRestClient client = null)
        {
            var options = new UpdateTaskOptions(workspaceSid, sid){Attributes = attributes, AssignmentStatus = assignmentStatus, Reason = reason, Priority = priority, TaskChannel = taskChannel};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteTaskOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Tasks/" + options.Sid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Task parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Task </returns> 
        public static bool Delete(DeleteTaskOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Delete Task parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Task </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteTaskOptions options, ITwilioRestClient client = null)
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
        /// <returns> A single instance of Task </returns> 
        public static bool Delete(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new DeleteTaskOptions(workspaceSid, sid);
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
        /// <returns> Task that resolves to A single instance of Task </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new DeleteTaskOptions(workspaceSid, sid);
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadTaskOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Tasks",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Task parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Task </returns> 
        public static ResourceSet<TaskResource> Read(ReadTaskOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<TaskResource>.FromJson("tasks", response.Content);
            return new ResourceSet<TaskResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Task parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Task </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TaskResource>> ReadAsync(ReadTaskOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<TaskResource>.FromJson("tasks", response.Content);
            return new ResourceSet<TaskResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="priority"> The priority </param>
        /// <param name="assignmentStatus"> The assignment_status </param>
        /// <param name="workflowSid"> The workflow_sid </param>
        /// <param name="workflowName"> The workflow_name </param>
        /// <param name="taskQueueSid"> The task_queue_sid </param>
        /// <param name="taskQueueName"> The task_queue_name </param>
        /// <param name="taskChannel"> The task_channel </param>
        /// <param name="evaluateTaskAttributes"> The evaluate_task_attributes </param>
        /// <param name="ordering"> The ordering </param>
        /// <param name="hasAddons"> The has_addons </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Task </returns> 
        public static ResourceSet<TaskResource> Read(string workspaceSid, int? priority = null, List<string> assignmentStatus = null, string workflowSid = null, string workflowName = null, string taskQueueSid = null, string taskQueueName = null, string taskChannel = null, string evaluateTaskAttributes = null, string ordering = null, bool? hasAddons = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadTaskOptions(workspaceSid){Priority = priority, AssignmentStatus = assignmentStatus, WorkflowSid = workflowSid, WorkflowName = workflowName, TaskQueueSid = taskQueueSid, TaskQueueName = taskQueueName, TaskChannel = taskChannel, EvaluateTaskAttributes = evaluateTaskAttributes, Ordering = ordering, HasAddons = hasAddons, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="priority"> The priority </param>
        /// <param name="assignmentStatus"> The assignment_status </param>
        /// <param name="workflowSid"> The workflow_sid </param>
        /// <param name="workflowName"> The workflow_name </param>
        /// <param name="taskQueueSid"> The task_queue_sid </param>
        /// <param name="taskQueueName"> The task_queue_name </param>
        /// <param name="taskChannel"> The task_channel </param>
        /// <param name="evaluateTaskAttributes"> The evaluate_task_attributes </param>
        /// <param name="ordering"> The ordering </param>
        /// <param name="hasAddons"> The has_addons </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Task </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TaskResource>> ReadAsync(string workspaceSid, int? priority = null, List<string> assignmentStatus = null, string workflowSid = null, string workflowName = null, string taskQueueSid = null, string taskQueueName = null, string taskChannel = null, string evaluateTaskAttributes = null, string ordering = null, bool? hasAddons = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadTaskOptions(workspaceSid){Priority = priority, AssignmentStatus = assignmentStatus, WorkflowSid = workflowSid, WorkflowName = workflowName, TaskQueueSid = taskQueueSid, TaskQueueName = taskQueueName, TaskChannel = taskChannel, EvaluateTaskAttributes = evaluateTaskAttributes, Ordering = ordering, HasAddons = hasAddons, PageSize = pageSize, Limit = limit};
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
        public static Page<TaskResource> NextPage(Page<TaskResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Taskrouter,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<TaskResource>.FromJson("tasks", response.Content);
        }
    
        private static Request BuildCreateRequest(CreateTaskOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.WorkspaceSid + "/Tasks",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Task parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Task </returns> 
        public static TaskResource Create(CreateTaskOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Create Task parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Task </returns> 
        public static async System.Threading.Tasks.Task<TaskResource> CreateAsync(CreateTaskOptions options, ITwilioRestClient client = null)
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
        /// <param name="timeout"> The timeout </param>
        /// <param name="priority"> The priority </param>
        /// <param name="taskChannel"> The task_channel </param>
        /// <param name="workflowSid"> The workflow_sid </param>
        /// <param name="attributes"> The attributes </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Task </returns> 
        public static TaskResource Create(string workspaceSid, int? timeout = null, int? priority = null, string taskChannel = null, string workflowSid = null, string attributes = null, ITwilioRestClient client = null)
        {
            var options = new CreateTaskOptions(workspaceSid){Timeout = timeout, Priority = priority, TaskChannel = taskChannel, WorkflowSid = workflowSid, Attributes = attributes};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="timeout"> The timeout </param>
        /// <param name="priority"> The priority </param>
        /// <param name="taskChannel"> The task_channel </param>
        /// <param name="workflowSid"> The workflow_sid </param>
        /// <param name="attributes"> The attributes </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Task </returns> 
        public static async System.Threading.Tasks.Task<TaskResource> CreateAsync(string workspaceSid, int? timeout = null, int? priority = null, string taskChannel = null, string workflowSid = null, string attributes = null, ITwilioRestClient client = null)
        {
            var options = new CreateTaskOptions(workspaceSid){Timeout = timeout, Priority = priority, TaskChannel = taskChannel, WorkflowSid = workflowSid, Attributes = attributes};
            return await CreateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a TaskResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TaskResource object represented by the provided JSON </returns> 
        public static TaskResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TaskResource>(json);
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
        /// The age
        /// </summary>
        [JsonProperty("age")]
        public int? Age { get; private set; }
        /// <summary>
        /// The assignment_status
        /// </summary>
        [JsonProperty("assignment_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TaskResource.StatusEnum AssignmentStatus { get; private set; }
        /// <summary>
        /// The attributes
        /// </summary>
        [JsonProperty("attributes")]
        public string Attributes { get; private set; }
        /// <summary>
        /// The addons
        /// </summary>
        [JsonProperty("addons")]
        public string Addons { get; private set; }
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
        /// The priority
        /// </summary>
        [JsonProperty("priority")]
        public int? Priority { get; private set; }
        /// <summary>
        /// The reason
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The task_queue_sid
        /// </summary>
        [JsonProperty("task_queue_sid")]
        public string TaskQueueSid { get; private set; }
        /// <summary>
        /// The task_queue_friendly_name
        /// </summary>
        [JsonProperty("task_queue_friendly_name")]
        public string TaskQueueFriendlyName { get; private set; }
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
        /// The timeout
        /// </summary>
        [JsonProperty("timeout")]
        public int? Timeout { get; private set; }
        /// <summary>
        /// The workflow_sid
        /// </summary>
        [JsonProperty("workflow_sid")]
        public string WorkflowSid { get; private set; }
        /// <summary>
        /// The workflow_friendly_name
        /// </summary>
        [JsonProperty("workflow_friendly_name")]
        public string WorkflowFriendlyName { get; private set; }
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
    
        private TaskResource()
        {
        
        }
    }

}