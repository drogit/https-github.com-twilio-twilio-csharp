/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Chat
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Constant;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;


namespace Twilio.Rest.Chat.V3
{
    public class ChannelResource : Resource
    {
    

    
        public sealed class WebhookEnabledTypeEnum : StringEnum
        {
            private WebhookEnabledTypeEnum(string value) : base(value) {}
            public WebhookEnabledTypeEnum() {}
            public static implicit operator WebhookEnabledTypeEnum(string value)
            {
                return new WebhookEnabledTypeEnum(value);
            }
            public static readonly WebhookEnabledTypeEnum True = new WebhookEnabledTypeEnum("true");
            public static readonly WebhookEnabledTypeEnum False = new WebhookEnabledTypeEnum("false");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class ChannelTypeEnum : StringEnum
        {
            private ChannelTypeEnum(string value) : base(value) {}
            public ChannelTypeEnum() {}
            public static implicit operator ChannelTypeEnum(string value)
            {
                return new ChannelTypeEnum(value);
            }
            public static readonly ChannelTypeEnum Public = new ChannelTypeEnum("public");
            public static readonly ChannelTypeEnum Private = new ChannelTypeEnum("private");

        }

        
        private static Request BuildUpdateRequest(UpdateChannelOptions options, ITwilioRestClient client)
        {
            
            string path = "/v3/Services/{ServiceSid}/Channels/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Chat,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> Update a specific Channel. </summary>
        /// <param name="options"> Update Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns>
        public static ChannelResource Update(UpdateChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a specific Channel. </summary>
        /// <param name="options"> Update Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<ChannelResource> UpdateAsync(UpdateChannelOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update a specific Channel. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Channel. </param>
        /// <param name="type">  </param>
        /// <param name="messagingServiceSid"> The unique ID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) this channel belongs to. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns>
        public static ChannelResource Update(
                                          string pathServiceSid,
                                          string pathSid,
                                          ChannelResource.ChannelTypeEnum type = null,
                                          string messagingServiceSid = null,
                                          ChannelResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateChannelOptions(pathServiceSid, pathSid){ Type = type, MessagingServiceSid = messagingServiceSid, XTwilioWebhookEnabled = xTwilioWebhookEnabled };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update a specific Channel. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Channel. </param>
        /// <param name="type">  </param>
        /// <param name="messagingServiceSid"> The unique ID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) this channel belongs to. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns>
        public static async System.Threading.Tasks.Task<ChannelResource> UpdateAsync(
                                                                              string pathServiceSid,
                                                                              string pathSid,
                                                                              ChannelResource.ChannelTypeEnum type = null,
                                                                              string messagingServiceSid = null,
                                                                              ChannelResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateChannelOptions(pathServiceSid, pathSid){ Type = type, MessagingServiceSid = messagingServiceSid, XTwilioWebhookEnabled = xTwilioWebhookEnabled };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a ChannelResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ChannelResource object represented by the provided JSON </returns>
        public static ChannelResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ChannelResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
        /// <summary>
    /// Converts an object into a json string
    /// </summary>
    /// <param name="model"> C# model </param>
    /// <returns> JSON string </returns>
    public static string ToJson(object model)
    {
        try
        {
            return JsonConvert.SerializeObject(model);
        }
        catch (JsonException e)
        {
            throw new ApiException(e.Message, e);
        }
    }

    
        ///<summary> The unique string that we created to identify the Channel resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Channel resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) the Channel resource is associated with. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used to address the resource in place of the resource's `sid` in the URL. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The JSON string that stores application-specific data. If attributes have not been set, `{}` is returned. </summary> 
        [JsonProperty("attributes")]
        public string Attributes { get; private set; }

        
        [JsonProperty("type")]
        public ChannelResource.ChannelTypeEnum Type { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The `identity` of the User that created the channel. If the Channel was created by using the API, the value is `system`. </summary> 
        [JsonProperty("created_by")]
        public string CreatedBy { get; private set; }

        ///<summary> The number of Members in the Channel. </summary> 
        [JsonProperty("members_count")]
        public int? MembersCount { get; private set; }

        ///<summary> The number of Messages that have been passed in the Channel. </summary> 
        [JsonProperty("messages_count")]
        public int? MessagesCount { get; private set; }

        ///<summary> The unique ID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) this channel belongs to. </summary> 
        [JsonProperty("messaging_service_sid")]
        public string MessagingServiceSid { get; private set; }

        ///<summary> The absolute URL of the Channel resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private ChannelResource() {

        }
    }
}

