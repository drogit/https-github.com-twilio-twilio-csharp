/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Numbers
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




namespace Twilio.Rest.Numbers.V1
{

    /// <summary> Create a bulk eligibility check for a set of numbers that you want to host in Twilio. </summary>
    public class CreateBulkEligibilityOptions : IOptions<BulkEligibilityResource>
    {
        
        
        public object Body { get; set; }



        
        /// <summary> Generate the request body </summary>
        public string GetBody()
        {
            string body = "";

            if (Body != null)
            {
                body = BulkEligibilityResource.ToJson(Body);
            }
            return body;
        }
        

    }
    /// <summary> Fetch an eligibility bulk check that you requested to host in Twilio. </summary>
    public class FetchBulkEligibilityOptions : IOptions<BulkEligibilityResource>
    {
    
        ///<summary> The SID of the bulk eligibility check that you want to know about. </summary> 
        public string PathRequestId { get; }



        /// <summary> Construct a new FetchBulkEligibilityOptions </summary>
        /// <param name="pathRequestId"> The SID of the bulk eligibility check that you want to know about. </param>
        public FetchBulkEligibilityOptions(string pathRequestId)
        {
            PathRequestId = pathRequestId;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


}

