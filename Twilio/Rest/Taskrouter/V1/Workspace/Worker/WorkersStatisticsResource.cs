using Newtonsoft.Json;
using System;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker 
{

    public class WorkersStatisticsResource : Resource 
    {
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <returns> WorkersStatisticsFetcher capable of executing the fetch </returns> 
        public static WorkersStatisticsFetcher Fetcher(string workspaceSid)
        {
            return new WorkersStatisticsFetcher(workspaceSid);
        }
    
        /// <summary>
        /// Converts a JSON string into a WorkersStatisticsResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkersStatisticsResource object represented by the provided JSON </returns> 
        public static WorkersStatisticsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<WorkersStatisticsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        public string accountSid { get; set; }
        [JsonProperty("cumulative")]
        public Object cumulative { get; set; }
        [JsonProperty("realtime")]
        public Object realtime { get; set; }
        [JsonProperty("workspace_sid")]
        public string workspaceSid { get; set; }
    
        public WorkersStatisticsResource()
        {
        
        }
    
        private WorkersStatisticsResource([JsonProperty("account_sid")]
                                          string accountSid, 
                                          [JsonProperty("cumulative")]
                                          Object cumulative, 
                                          [JsonProperty("realtime")]
                                          Object realtime, 
                                          [JsonProperty("workspace_sid")]
                                          string workspaceSid)
                                          {
            this.accountSid = accountSid;
            this.cumulative = cumulative;
            this.realtime = realtime;
            this.workspaceSid = workspaceSid;
        }
    }
}