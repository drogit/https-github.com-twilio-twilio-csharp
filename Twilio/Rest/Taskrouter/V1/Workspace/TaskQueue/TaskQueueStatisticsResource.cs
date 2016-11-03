using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace.TaskQueue 
{

    public class TaskQueueStatisticsResource : Resource 
    {
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="taskQueueSid"> The task_queue_sid </param>
        /// <returns> TaskQueueStatisticsFetcher capable of executing the fetch </returns> 
        public static TaskQueueStatisticsFetcher Fetcher(string workspaceSid, string taskQueueSid)
        {
            return new TaskQueueStatisticsFetcher(workspaceSid, taskQueueSid);
        }
    
        /// <summary>
        /// Converts a JSON string into a TaskQueueStatisticsResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TaskQueueStatisticsResource object represented by the provided JSON </returns> 
        public static TaskQueueStatisticsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TaskQueueStatisticsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        public string accountSid { get; set; }
        [JsonProperty("cumulative")]
        public Dictionary<string, string> cumulative { get; set; }
        [JsonProperty("realtime")]
        public Object realtime { get; set; }
        [JsonProperty("task_queue_sid")]
        public string taskQueueSid { get; set; }
        [JsonProperty("workspace_sid")]
        public string workspaceSid { get; set; }
    
        public TaskQueueStatisticsResource()
        {
        
        }
    
        private TaskQueueStatisticsResource([JsonProperty("account_sid")]
                                            string accountSid, 
                                            [JsonProperty("cumulative")]
                                            Dictionary<string, string> cumulative, 
                                            [JsonProperty("realtime")]
                                            Object realtime, 
                                            [JsonProperty("task_queue_sid")]
                                            string taskQueueSid, 
                                            [JsonProperty("workspace_sid")]
                                            string workspaceSid)
                                            {
            this.accountSid = accountSid;
            this.cumulative = cumulative;
            this.realtime = realtime;
            this.taskQueueSid = taskQueueSid;
            this.workspaceSid = workspaceSid;
        }
    }
}