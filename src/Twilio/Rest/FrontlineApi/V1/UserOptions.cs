/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Frontline
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




namespace Twilio.Rest.FrontlineApi.V1
{
    /// <summary> Fetch a frontline user </summary>
    public class FetchUserOptions : IOptions<UserResource>
    {
    
        ///<summary> The SID of the User resource to fetch. This value can be either the `sid` or the `identity` of the User resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchUserOptions </summary>
        /// <param name="pathSid"> The SID of the User resource to fetch. This value can be either the `sid` or the `identity` of the User resource to fetch. </param>
        public FetchUserOptions(string pathSid)
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


    /// <summary> Update an existing frontline user </summary>
    public class UpdateUserOptions : IOptions<UserResource>
    {
    
        ///<summary> The SID of the User resource to update. This value can be either the `sid` or the `identity` of the User resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> The string that you assigned to describe the User. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The avatar URL which will be shown in Frontline application. </summary> 
        public string Avatar { get; set; }

        
        public UserResource.StateTypeEnum State { get; set; }

        ///<summary> Whether the User is available for new conversations. Set to `false` to prevent User from receiving new inbound conversations if you are using [Pool Routing](https://www.twilio.com/docs/frontline/handle-incoming-conversations#3-pool-routing). </summary> 
        public bool? IsAvailable { get; set; }



        /// <summary> Construct a new UpdateUserOptions </summary>
        /// <param name="pathSid"> The SID of the User resource to update. This value can be either the `sid` or the `identity` of the User resource to update. </param>
        public UpdateUserOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Avatar != null)
            {
                p.Add(new KeyValuePair<string, string>("Avatar", Avatar));
            }
            if (State != null)
            {
                p.Add(new KeyValuePair<string, string>("State", State.ToString()));
            }
            if (IsAvailable != null)
            {
                p.Add(new KeyValuePair<string, string>("IsAvailable", IsAvailable.Value.ToString().ToLower()));
            }
            return p;
        }

        

    }


}

