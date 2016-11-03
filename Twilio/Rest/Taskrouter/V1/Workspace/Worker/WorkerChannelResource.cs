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
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <returns> WorkerChannelReader capable of executing the read </returns> 
        public static WorkerChannelReader Reader(string workspaceSid, string workerSid)
        {
            return new WorkerChannelReader(workspaceSid, workerSid);
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <param name="sid"> The sid </param>
        /// <returns> WorkerChannelFetcher capable of executing the fetch </returns> 
        public static WorkerChannelFetcher Fetcher(string workspaceSid, string workerSid, string sid)
        {
            return new WorkerChannelFetcher(workspaceSid, workerSid, sid);
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <param name="sid"> The sid </param>
        /// <returns> WorkerChannelUpdater capable of executing the update </returns> 
        public static WorkerChannelUpdater Updater(string workspaceSid, string workerSid, string sid)
        {
            return new WorkerChannelUpdater(workspaceSid, workerSid, sid);
        }
    
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
    
        [JsonProperty("account_sid")]
        public string accountSid { get; set; }
        [JsonProperty("assigned_tasks")]
        public int? assignedTasks { get; set; }
        [JsonProperty("available")]
        public bool? available { get; set; }
        [JsonProperty("available_capacity_percentage")]
        public int? availableCapacityPercentage { get; set; }
        [JsonProperty("configured_capacity")]
        public int? configuredCapacity { get; set; }
        [JsonProperty("date_created")]
        public DateTime? dateCreated { get; set; }
        [JsonProperty("date_updated")]
        public DateTime? dateUpdated { get; set; }
        [JsonProperty("sid")]
        public string sid { get; set; }
        [JsonProperty("task_channel_sid")]
        public string taskChannelSid { get; set; }
        [JsonProperty("task_channel_unique_name")]
        public string taskChannelUniqueName { get; set; }
        [JsonProperty("worker_sid")]
        public string workerSid { get; set; }
        [JsonProperty("workspace_sid")]
        public string workspaceSid { get; set; }
        [JsonProperty("links")]
        public Dictionary<string, string> links { get; set; }
        [JsonProperty("url")]
        public Uri url { get; set; }
    
        public WorkerChannelResource()
        {
        
        }
    
        private WorkerChannelResource([JsonProperty("account_sid")]
                                      string accountSid, 
                                      [JsonProperty("assigned_tasks")]
                                      int? assignedTasks, 
                                      [JsonProperty("available")]
                                      bool? available, 
                                      [JsonProperty("available_capacity_percentage")]
                                      int? availableCapacityPercentage, 
                                      [JsonProperty("configured_capacity")]
                                      int? configuredCapacity, 
                                      [JsonProperty("date_created")]
                                      string dateCreated, 
                                      [JsonProperty("date_updated")]
                                      string dateUpdated, 
                                      [JsonProperty("sid")]
                                      string sid, 
                                      [JsonProperty("task_channel_sid")]
                                      string taskChannelSid, 
                                      [JsonProperty("task_channel_unique_name")]
                                      string taskChannelUniqueName, 
                                      [JsonProperty("worker_sid")]
                                      string workerSid, 
                                      [JsonProperty("workspace_sid")]
                                      string workspaceSid, 
                                      [JsonProperty("links")]
                                      Dictionary<string, string> links, 
                                      [JsonProperty("url")]
                                      Uri url)
                                      {
            this.accountSid = accountSid;
            this.assignedTasks = assignedTasks;
            this.available = available;
            this.availableCapacityPercentage = availableCapacityPercentage;
            this.configuredCapacity = configuredCapacity;
            this.dateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            this.dateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
            this.sid = sid;
            this.taskChannelSid = taskChannelSid;
            this.taskChannelUniqueName = taskChannelUniqueName;
            this.workerSid = workerSid;
            this.workspaceSid = workspaceSid;
            this.links = links;
            this.url = url;
        }
    }
}