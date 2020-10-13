/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// WorkflowRealTimeStatisticsResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Workflow
{

    public class WorkflowRealTimeStatisticsResource : Resource
    {
        private static Request BuildFetchRequest(FetchWorkflowRealTimeStatisticsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Workflows/" + options.PathWorkflowSid + "/RealTimeStatistics",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch WorkflowRealTimeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkflowRealTimeStatistics </returns>
        public static WorkflowRealTimeStatisticsResource Fetch(FetchWorkflowRealTimeStatisticsOptions options,
                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch WorkflowRealTimeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkflowRealTimeStatistics </returns>
        public static async System.Threading.Tasks.Task<WorkflowRealTimeStatisticsResource> FetchAsync(FetchWorkflowRealTimeStatisticsOptions options,
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
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to fetch </param>
        /// <param name="pathWorkflowSid"> Returns the list of Tasks that are being controlled by the Workflow with the
        ///                       specified SID value </param>
        /// <param name="taskChannel"> Only calculate real-time statistics on this TaskChannel </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkflowRealTimeStatistics </returns>
        public static WorkflowRealTimeStatisticsResource Fetch(string pathWorkspaceSid,
                                                               string pathWorkflowSid,
                                                               string taskChannel = null,
                                                               ITwilioRestClient client = null)
        {
            var options = new FetchWorkflowRealTimeStatisticsOptions(pathWorkspaceSid, pathWorkflowSid){TaskChannel = taskChannel};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to fetch </param>
        /// <param name="pathWorkflowSid"> Returns the list of Tasks that are being controlled by the Workflow with the
        ///                       specified SID value </param>
        /// <param name="taskChannel"> Only calculate real-time statistics on this TaskChannel </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkflowRealTimeStatistics </returns>
        public static async System.Threading.Tasks.Task<WorkflowRealTimeStatisticsResource> FetchAsync(string pathWorkspaceSid,
                                                                                                       string pathWorkflowSid,
                                                                                                       string taskChannel = null,
                                                                                                       ITwilioRestClient client = null)
        {
            var options = new FetchWorkflowRealTimeStatisticsOptions(pathWorkspaceSid, pathWorkflowSid){TaskChannel = taskChannel};
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a WorkflowRealTimeStatisticsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkflowRealTimeStatisticsResource object represented by the provided JSON </returns>
        public static WorkflowRealTimeStatisticsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<WorkflowRealTimeStatisticsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The age of the longest waiting Task
        /// </summary>
        [JsonProperty("longest_task_waiting_age")]
        public int? LongestTaskWaitingAge { get; private set; }
        /// <summary>
        /// The SID of the longest waiting Task
        /// </summary>
        [JsonProperty("longest_task_waiting_sid")]
        public string LongestTaskWaitingSid { get; private set; }
        /// <summary>
        /// The number of Tasks by priority
        /// </summary>
        [JsonProperty("tasks_by_priority")]
        public object TasksByPriority { get; private set; }
        /// <summary>
        /// The number of Tasks by their current status
        /// </summary>
        [JsonProperty("tasks_by_status")]
        public object TasksByStatus { get; private set; }
        /// <summary>
        /// The total number of Tasks
        /// </summary>
        [JsonProperty("total_tasks")]
        public int? TotalTasks { get; private set; }
        /// <summary>
        /// Returns the list of Tasks that are being controlled by the Workflow with the specified SID value
        /// </summary>
        [JsonProperty("workflow_sid")]
        public string WorkflowSid { get; private set; }
        /// <summary>
        /// The SID of the Workspace that contains the Workflow.
        /// </summary>
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }
        /// <summary>
        /// The absolute URL of the Workflow statistics resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private WorkflowRealTimeStatisticsResource()
        {

        }
    }

}