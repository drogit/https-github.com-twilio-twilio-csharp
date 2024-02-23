/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Studio
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




namespace Twilio.Rest.Studio.V1.Flow.Engagement
{
    /// <summary> Retrieve a Step. </summary>
    public class FetchStepOptions : IOptions<StepResource>
    {
    
        ///<summary> The SID of the Flow with the Step to fetch. </summary> 
        public string PathFlowSid { get; }

        ///<summary> The SID of the Engagement with the Step to fetch. </summary> 
        public string PathEngagementSid { get; }

        ///<summary> The SID of the Step resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchStepOptions </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Step to fetch. </param>
        /// <param name="pathEngagementSid"> The SID of the Engagement with the Step to fetch. </param>
        /// <param name="pathSid"> The SID of the Step resource to fetch. </param>
        public FetchStepOptions(string pathFlowSid, string pathEngagementSid, string pathSid)
        {
            PathFlowSid = pathFlowSid;
            PathEngagementSid = pathEngagementSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Retrieve a list of all Steps for an Engagement. </summary>
    public class ReadStepOptions : ReadOptions<StepResource>
    {
    
        ///<summary> The SID of the Flow with the Step to read. </summary> 
        public string PathFlowSid { get; }

        ///<summary> The SID of the Engagement with the Step to read. </summary> 
        public string PathEngagementSid { get; }



        /// <summary> Construct a new ListStepOptions </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Step to read. </param>
        /// <param name="pathEngagementSid"> The SID of the Engagement with the Step to read. </param>
        public ReadStepOptions(string pathFlowSid, string pathEngagementSid)
        {
            PathFlowSid = pathFlowSid;
            PathEngagementSid = pathEngagementSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

}

