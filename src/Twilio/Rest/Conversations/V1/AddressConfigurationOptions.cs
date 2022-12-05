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



namespace Twilio.Rest.Conversations.V1
{

    /// <summary> Create a new address configuration </summary>
    public class CreateAddressConfigurationOptions : IOptions<AddressConfigurationResource>
    {
        
        
        public AddressConfigurationResource.TypeEnum Type { get; }

        ///<summary> The unique address to be configured. The address can be a whatsapp address or phone number </summary> 
        public string Address { get; }

        ///<summary> The human-readable name of this configuration, limited to 256 characters. Optional. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Enable/Disable auto-creating conversations for messages to this address </summary> 
        public bool? AutoCreationEnabled { get; set; }

        
        public AddressConfigurationResource.AutoCreationTypeEnum AutoCreationType { get; set; }

        ///<summary> Conversation Service for the auto-created conversation. If not set, the conversation is created in the default service. </summary> 
        public string AutoCreationConversationServiceSid { get; set; }

        ///<summary> For type `webhook`, the url for the webhook request. </summary> 
        public string AutoCreationWebhookUrl { get; set; }

        
        public AddressConfigurationResource.MethodEnum AutoCreationWebhookMethod { get; set; }

        ///<summary> The list of events, firing webhook event for this Conversation. Values can be any of the following: `onMessageAdded`, `onMessageUpdated`, `onMessageRemoved`, `onConversationUpdated`, `onConversationStateUpdated`, `onConversationRemoved`, `onParticipantAdded`, `onParticipantUpdated`, `onParticipantRemoved`, `onDeliveryUpdated` </summary> 
        public List<string> AutoCreationWebhookFilters { get; set; }

        ///<summary> For type `studio`, the studio flow SID where the webhook should be sent to. </summary> 
        public string AutoCreationStudioFlowSid { get; set; }

        ///<summary> For type `studio`, number of times to retry the webhook request </summary> 
        public int? AutoCreationStudioRetryCount { get; set; }


        /// <summary> Construct a new CreateConfigurationAddressOptions </summary>
        /// <param name="type">  </param>
        /// <param name="address"> The unique address to be configured. The address can be a whatsapp address or phone number </param>
        public CreateAddressConfigurationOptions(AddressConfigurationResource.TypeEnum type, string address)
        {
            Type = type;
            Address = address;
            AutoCreationWebhookFilters = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }
            if (Address != null)
            {
                p.Add(new KeyValuePair<string, string>("Address", Address));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (AutoCreationEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.Enabled", AutoCreationEnabled.Value.ToString().ToLower()));
            }
            if (AutoCreationType != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.Type", AutoCreationType.ToString()));
            }
            if (AutoCreationConversationServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.ConversationServiceSid", AutoCreationConversationServiceSid));
            }
            if (AutoCreationWebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.WebhookUrl", AutoCreationWebhookUrl));
            }
            if (AutoCreationWebhookMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.WebhookMethod", AutoCreationWebhookMethod.ToString()));
            }
            if (AutoCreationWebhookFilters != null)
            {
                p.AddRange(AutoCreation.WebhookFilters.Select(AutoCreation.WebhookFilters => new KeyValuePair<string, string>("AutoCreation.WebhookFilters", AutoCreationWebhookFilters)));
            }
            if (AutoCreationStudioFlowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.StudioFlowSid", AutoCreationStudioFlowSid));
            }
            if (AutoCreationStudioRetryCount != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.StudioRetryCount", AutoCreationStudioRetryCount.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> Remove an existing address configuration </summary>
    public class DeleteAddressConfigurationOptions : IOptions<AddressConfigurationResource>
    {
        
        ///<summary> The SID of the Address Configuration resource. This value can be either the `sid` or the `address` of the configuration </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteConfigurationAddressOptions </summary>
        /// <param name="pathSid"> The SID of the Address Configuration resource. This value can be either the `sid` or the `address` of the configuration </param>
        public DeleteAddressConfigurationOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch an address configuration  </summary>
    public class FetchAddressConfigurationOptions : IOptions<AddressConfigurationResource>
    {
    
        ///<summary> The SID of the Address Configuration resource. This value can be either the `sid` or the `address` of the configuration </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchConfigurationAddressOptions </summary>
        /// <param name="pathSid"> The SID of the Address Configuration resource. This value can be either the `sid` or the `address` of the configuration </param>
        public FetchAddressConfigurationOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of address configurations for an account </summary>
    public class ReadAddressConfigurationOptions : ReadOptions<AddressConfigurationResource>
    {
    
        ///<summary> Filter the address configurations by its type. This value can be one of: `whatsapp`, `sms`. </summary> 
        public string Type { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Update an existing address configuration </summary>
    public class UpdateAddressConfigurationOptions : IOptions<AddressConfigurationResource>
    {
    
        ///<summary> The SID of the Address Configuration resource. This value can be either the `sid` or the `address` of the configuration </summary> 
        public string PathSid { get; }

        ///<summary> The human-readable name of this configuration, limited to 256 characters. Optional. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Enable/Disable auto-creating conversations for messages to this address </summary> 
        public bool? AutoCreationEnabled { get; set; }

        
        public AddressConfigurationResource.AutoCreationTypeEnum AutoCreationType { get; set; }

        ///<summary> Conversation Service for the auto-created conversation. If not set, the conversation is created in the default service. </summary> 
        public string AutoCreationConversationServiceSid { get; set; }

        ///<summary> For type `webhook`, the url for the webhook request. </summary> 
        public string AutoCreationWebhookUrl { get; set; }

        
        public AddressConfigurationResource.MethodEnum AutoCreationWebhookMethod { get; set; }

        ///<summary> The list of events, firing webhook event for this Conversation. Values can be any of the following: `onMessageAdded`, `onMessageUpdated`, `onMessageRemoved`, `onConversationUpdated`, `onConversationStateUpdated`, `onConversationRemoved`, `onParticipantAdded`, `onParticipantUpdated`, `onParticipantRemoved`, `onDeliveryUpdated` </summary> 
        public List<string> AutoCreationWebhookFilters { get; set; }

        ///<summary> For type `studio`, the studio flow SID where the webhook should be sent to. </summary> 
        public string AutoCreationStudioFlowSid { get; set; }

        ///<summary> For type `studio`, number of times to retry the webhook request </summary> 
        public int? AutoCreationStudioRetryCount { get; set; }



        /// <summary> Construct a new UpdateConfigurationAddressOptions </summary>
        /// <param name="pathSid"> The SID of the Address Configuration resource. This value can be either the `sid` or the `address` of the configuration </param>
        public UpdateAddressConfigurationOptions(string pathSid)
        {
            PathSid = pathSid;
            AutoCreationWebhookFilters = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (AutoCreationEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.Enabled", AutoCreationEnabled.Value.ToString().ToLower()));
            }
            if (AutoCreationType != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.Type", AutoCreationType.ToString()));
            }
            if (AutoCreationConversationServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.ConversationServiceSid", AutoCreationConversationServiceSid));
            }
            if (AutoCreationWebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.WebhookUrl", AutoCreationWebhookUrl));
            }
            if (AutoCreationWebhookMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.WebhookMethod", AutoCreationWebhookMethod.ToString()));
            }
            if (AutoCreationWebhookFilters != null)
            {
                p.AddRange(AutoCreation.WebhookFilters.Select(AutoCreation.WebhookFilters => new KeyValuePair<string, string>("AutoCreation.WebhookFilters", AutoCreationWebhookFilters)));
            }
            if (AutoCreationStudioFlowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.StudioFlowSid", AutoCreationStudioFlowSid));
            }
            if (AutoCreationStudioRetryCount != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreation.StudioRetryCount", AutoCreationStudioRetryCount.ToString()));
            }
            return p;
        }
        

    }


}

