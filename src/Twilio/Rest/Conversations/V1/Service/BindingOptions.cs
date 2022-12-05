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
using System.Linq;



namespace Twilio.Rest.Conversations.V1.Service
{
    /// <summary> Remove a push notification binding from the conversation service </summary>
    public class DeleteBindingOptions : IOptions<BindingResource>
    {
        
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) to delete the Binding resource from. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> The SID of the Binding resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteServiceBindingOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) to delete the Binding resource from. </param>
        /// <param name="pathSid"> The SID of the Binding resource to delete. </param>
        public DeleteBindingOptions(string pathChatServiceSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a push notification binding from the conversation service </summary>
    public class FetchBindingOptions : IOptions<BindingResource>
    {
    
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Binding resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchServiceBindingOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Binding resource is associated with. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchBindingOptions(string pathChatServiceSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all push notification bindings in the conversation service </summary>
    public class ReadBindingOptions : ReadOptions<BindingResource>
    {
    
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Binding resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> The push technology used by the Binding resources to read.  Can be: `apn`, `gcm`, or `fcm`.  See [push notification configuration](https://www.twilio.com/docs/chat/push-notification-configuration) for more info. </summary> 
        public List<BindingResource.BindingTypeEnum> BindingType { get; set; }

        ///<summary> The identity of a [Conversation User](https://www.twilio.com/docs/conversations/api/user-resource) this binding belongs to. See [access tokens](https://www.twilio.com/docs/conversations/create-tokens) for more details. </summary> 
        public List<string> Identity { get; set; }



        /// <summary> Construct a new ListServiceBindingOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Binding resource is associated with. </param>
        public ReadBindingOptions(string pathChatServiceSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            BindingType = new List<BindingResource.BindingTypeEnum>();
            Identity = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (BindingType != null)
            {
                p.AddRange(BindingType.Select(prop => new KeyValuePair<string, string>("BindingType", BindingType.ToString())));
            }
            if (Identity != null)
            {
                p.AddRange(Identity.Select(prop => new KeyValuePair<string, string>("Identity", Identity)));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}

