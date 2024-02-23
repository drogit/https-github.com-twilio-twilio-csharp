/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Verify
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




namespace Twilio.Rest.Verify.V2.Service.Entity.Challenge
{

    /// <summary> Create a new Notification for the corresponding Challenge </summary>
    public class CreateNotificationOptions : IOptions<NotificationResource>
    {
        
        ///<summary> The unique SID identifier of the Service. </summary> 
        public string PathServiceSid { get; }

        ///<summary> Customer unique identity for the Entity owner of the Challenge. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </summary> 
        public string PathIdentity { get; }

        ///<summary> The unique SID identifier of the Challenge. </summary> 
        public string PathChallengeSid { get; }

        ///<summary> How long, in seconds, the notification is valid. Can be an integer between 0 and 300. Default is 300. Delivery is attempted until the TTL elapses, even if the device is offline. 0 means that the notification delivery is attempted immediately, only once, and is not stored for future delivery. </summary> 
        public int? Ttl { get; set; }


        /// <summary> Construct a new CreateNotificationOptions </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Challenge. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="pathChallengeSid"> The unique SID identifier of the Challenge. </param>
        public CreateNotificationOptions(string pathServiceSid, string pathIdentity, string pathChallengeSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathChallengeSid = pathChallengeSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }
            return p;
        }

        

    }
}

