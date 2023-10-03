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
using System.Linq;



namespace Twilio.Rest.Studio.V2.Flow
{
    /// <summary> Fetch flow test users </summary>
    public class FetchFlowTestUserOptions : IOptions<FlowTestUserResource>
    {
    
        ///<summary> Unique identifier of the flow. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchTestUserOptions </summary>
        /// <param name="pathSid"> Unique identifier of the flow. </param>
        public FetchFlowTestUserOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Update flow test users </summary>
    public class UpdateFlowTestUserOptions : IOptions<FlowTestUserResource>
    {
    
        ///<summary> Unique identifier of the flow. </summary> 
        public string PathSid { get; }

        ///<summary> List of test user identities that can test draft versions of the flow. </summary> 
        public List<string> TestUsers { get; }



        /// <summary> Construct a new UpdateTestUserOptions </summary>
        /// <param name="pathSid"> Unique identifier of the flow. </param>
        /// <param name="testUsers"> List of test user identities that can test draft versions of the flow. </param>
        public UpdateFlowTestUserOptions(string pathSid, List<string> testUsers)
        {
            PathSid = pathSid;
            TestUsers = testUsers;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (TestUsers != null)
            {
                p.AddRange(TestUsers.Select(TestUsers => new KeyValuePair<string, string>("TestUsers", TestUsers)));
            }
            return p;
        }

        

    }


}

