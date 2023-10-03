/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
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




namespace Twilio.Rest.Messaging.V1.Service
{
    /// <summary> fetch </summary>
    public class FetchUsAppToPersonUsecaseOptions : IOptions<UsAppToPersonUsecaseResource>
    {
    
        ///<summary> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) to fetch the resource from. </summary> 
        public string PathMessagingServiceSid { get; }

        ///<summary> The unique string to identify the A2P brand. </summary> 
        public string BrandRegistrationSid { get; set; }



        /// <summary> Construct a new FetchUsAppToPersonUsecaseOptions </summary>
        /// <param name="pathMessagingServiceSid"> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) to fetch the resource from. </param>
        public FetchUsAppToPersonUsecaseOptions(string pathMessagingServiceSid)
        {
            PathMessagingServiceSid = pathMessagingServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (BrandRegistrationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("BrandRegistrationSid", BrandRegistrationSid));
            }
            return p;
        }

        

    }


}

