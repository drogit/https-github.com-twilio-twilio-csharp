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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Taskrouter.V1
{

    /// <summary> Fetch a Task Queue Real Time Statistics in bulk for the array of TaskQueue SIDs, support upto 50 in a request. </summary>
    public class CreateTaskQueueBulkRealTimeStatisticsOptions : IOptions<TaskQueueBulkRealTimeStatisticsResource>
    {
        
        ///<summary> The unique SID identifier of the Workspace. </summary> 
        public string PathWorkspaceSid { get; }


        /// <summary> Construct a new CreateTaskQueueBulkRealTimeStatisticsOptions </summary>
        /// <param name="pathWorkspaceSid"> The unique SID identifier of the Workspace. </param>
        public CreateTaskQueueBulkRealTimeStatisticsOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }
}
