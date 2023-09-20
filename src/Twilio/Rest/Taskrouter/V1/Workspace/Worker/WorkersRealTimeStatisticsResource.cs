/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Taskrouter
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



namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker
{
    public class WorkersRealTimeStatisticsResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchWorkersRealTimeStatisticsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/Workers/RealTimeStatistics";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch WorkersRealTimeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkersRealTimeStatistics </returns>
        public static WorkersRealTimeStatisticsResource Fetch(FetchWorkersRealTimeStatisticsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch WorkersRealTimeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkersRealTimeStatistics </returns>
        public static async System.Threading.Tasks.Task<WorkersRealTimeStatisticsResource> FetchAsync(FetchWorkersRealTimeStatisticsOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the resource to fetch. </param>
        /// <param name="taskChannel"> Only calculate real-time statistics on this TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkersRealTimeStatistics </returns>
        public static WorkersRealTimeStatisticsResource Fetch(
                                         string pathWorkspaceSid, 
                                         string taskChannel = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchWorkersRealTimeStatisticsOptions(pathWorkspaceSid){ TaskChannel = taskChannel };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the resource to fetch. </param>
        /// <param name="taskChannel"> Only calculate real-time statistics on this TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkersRealTimeStatistics </returns>
        public static async System.Threading.Tasks.Task<WorkersRealTimeStatisticsResource> FetchAsync(string pathWorkspaceSid, string taskChannel = null, ITwilioRestClient client = null)
        {
            var options = new FetchWorkersRealTimeStatisticsOptions(pathWorkspaceSid){ TaskChannel = taskChannel };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a WorkersRealTimeStatisticsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkersRealTimeStatisticsResource object represented by the provided JSON </returns>
        public static WorkersRealTimeStatisticsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<WorkersRealTimeStatisticsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Worker resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The number of current Workers by Activity. </summary> 
        [JsonProperty("activity_statistics")]
        public List<object> ActivityStatistics { get; private set; }

        ///<summary> The total number of Workers. </summary> 
        [JsonProperty("total_workers")]
        public int? TotalWorkers { get; private set; }

        ///<summary> The SID of the Workspace that contains the Workers. </summary> 
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }

        ///<summary> The absolute URL of the Workers statistics resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private WorkersRealTimeStatisticsResource() {

        }
    }
}

