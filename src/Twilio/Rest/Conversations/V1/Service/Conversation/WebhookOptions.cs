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



namespace Twilio.Rest.Conversations.V1.Service.Conversation
{

    /// <summary> Create a new webhook scoped to the conversation in a specific service </summary>
    public class CreateWebhookOptions : IOptions<WebhookResource>
    {
        
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Participant resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this webhook. </summary> 
        public string PathConversationSid { get; }

        
        public WebhookResource.TargetEnum Target { get; }

        ///<summary> The absolute url the webhook request should be sent to. </summary> 
        public string ConfigurationUrl { get; set; }

        
        public WebhookResource.MethodEnum ConfigurationMethod { get; set; }

        ///<summary> The list of events, firing webhook event for this Conversation. </summary> 
        public List<string> ConfigurationFilters { get; set; }

        ///<summary> The list of keywords, firing webhook event for this Conversation. </summary> 
        public List<string> ConfigurationTriggers { get; set; }

        ///<summary> The studio flow SID, where the webhook should be sent to. </summary> 
        public string ConfigurationFlowSid { get; set; }

        ///<summary> The message index for which and it's successors the webhook will be replayed. Not set by default </summary> 
        public int? ConfigurationReplayAfter { get; set; }


        /// <summary> Construct a new CreateServiceConversationScopedWebhookOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="target">  </param>
        public CreateWebhookOptions(string pathChatServiceSid, string pathConversationSid, WebhookResource.TargetEnum target)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathConversationSid = pathConversationSid;
            Target = target;
            ConfigurationFilters = new List<string>();
            ConfigurationTriggers = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Target != null)
            {
                p.Add(new KeyValuePair<string, string>("Target", Target.ToString()));
            }
            if (ConfigurationUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.Url", ConfigurationUrl));
            }
            if (ConfigurationMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.Method", ConfigurationMethod.ToString()));
            }
            if (ConfigurationFilters != null)
            {
                p.AddRange(ConfigurationFilters.Select(ConfigurationFilters => new KeyValuePair<string, string>("Configuration.Filters", ConfigurationFilters)));
            }
            if (ConfigurationTriggers != null)
            {
                p.AddRange(ConfigurationTriggers.Select(ConfigurationTriggers => new KeyValuePair<string, string>("Configuration.Triggers", ConfigurationTriggers)));
            }
            if (ConfigurationFlowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.FlowSid", ConfigurationFlowSid));
            }
            if (ConfigurationReplayAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.ReplayAfter", ConfigurationReplayAfter.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> Remove an existing webhook scoped to the conversation </summary>
    public class DeleteWebhookOptions : IOptions<WebhookResource>
    {
        
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Participant resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this webhook. </summary> 
        public string PathConversationSid { get; }

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteServiceConversationScopedWebhookOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public DeleteWebhookOptions(string pathChatServiceSid, string pathConversationSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathConversationSid = pathConversationSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch the configuration of a conversation-scoped webhook </summary>
    public class FetchWebhookOptions : IOptions<WebhookResource>
    {
    
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Participant resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this webhook. </summary> 
        public string PathConversationSid { get; }

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchServiceConversationScopedWebhookOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchWebhookOptions(string pathChatServiceSid, string pathConversationSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathConversationSid = pathConversationSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all webhooks scoped to the conversation </summary>
    public class ReadWebhookOptions : ReadOptions<WebhookResource>
    {
    
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Participant resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this webhook. </summary> 
        public string PathConversationSid { get; }



        /// <summary> Construct a new ListServiceConversationScopedWebhookOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        public ReadWebhookOptions(string pathChatServiceSid, string pathConversationSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathConversationSid = pathConversationSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Update an existing conversation-scoped webhook </summary>
    public class UpdateWebhookOptions : IOptions<WebhookResource>
    {
    
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Participant resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this webhook. </summary> 
        public string PathConversationSid { get; }

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        public string PathSid { get; }

        ///<summary> The absolute url the webhook request should be sent to. </summary> 
        public string ConfigurationUrl { get; set; }

        
        public WebhookResource.MethodEnum ConfigurationMethod { get; set; }

        ///<summary> The list of events, firing webhook event for this Conversation. </summary> 
        public List<string> ConfigurationFilters { get; set; }

        ///<summary> The list of keywords, firing webhook event for this Conversation. </summary> 
        public List<string> ConfigurationTriggers { get; set; }

        ///<summary> The studio flow SID, where the webhook should be sent to. </summary> 
        public string ConfigurationFlowSid { get; set; }



        /// <summary> Construct a new UpdateServiceConversationScopedWebhookOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public UpdateWebhookOptions(string pathChatServiceSid, string pathConversationSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathConversationSid = pathConversationSid;
            PathSid = pathSid;
            ConfigurationFilters = new List<string>();
            ConfigurationTriggers = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ConfigurationUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.Url", ConfigurationUrl));
            }
            if (ConfigurationMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.Method", ConfigurationMethod.ToString()));
            }
            if (ConfigurationFilters != null)
            {
                p.AddRange(ConfigurationFilters.Select(ConfigurationFilters => new KeyValuePair<string, string>("Configuration.Filters", ConfigurationFilters)));
            }
            if (ConfigurationTriggers != null)
            {
                p.AddRange(ConfigurationTriggers.Select(ConfigurationTriggers => new KeyValuePair<string, string>("Configuration.Triggers", ConfigurationTriggers)));
            }
            if (ConfigurationFlowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.FlowSid", ConfigurationFlowSid));
            }
            return p;
        }
        

    }


}

