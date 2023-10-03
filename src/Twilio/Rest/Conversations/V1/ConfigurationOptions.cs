/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Conversations
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




namespace Twilio.Rest.Conversations.V1
{
    /// <summary> Fetch the global configuration of conversations on your account </summary>
    public class FetchConfigurationOptions : IOptions<ConfigurationResource>
    {
    



        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Update the global configuration of conversations on your account </summary>
    public class UpdateConfigurationOptions : IOptions<ConfigurationResource>
    {
    
        ///<summary> The SID of the default [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) to use when creating a conversation. </summary> 
        public string DefaultChatServiceSid { get; set; }

        ///<summary> The SID of the default [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) to use when creating a conversation. </summary> 
        public string DefaultMessagingServiceSid { get; set; }

        ///<summary> Default ISO8601 duration when conversation will be switched to `inactive` state. Minimum value for this timer is 1 minute. </summary> 
        public string DefaultInactiveTimer { get; set; }

        ///<summary> Default ISO8601 duration when conversation will be switched to `closed` state. Minimum value for this timer is 10 minutes. </summary> 
        public string DefaultClosedTimer { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (DefaultChatServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultChatServiceSid", DefaultChatServiceSid));
            }
            if (DefaultMessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultMessagingServiceSid", DefaultMessagingServiceSid));
            }
            if (DefaultInactiveTimer != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultInactiveTimer", DefaultInactiveTimer));
            }
            if (DefaultClosedTimer != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultClosedTimer", DefaultClosedTimer));
            }
            return p;
        }

        

    }


}

