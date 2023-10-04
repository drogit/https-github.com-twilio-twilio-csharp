/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Ip_messaging
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


namespace Twilio.Rest.IpMessaging.V1.Service.Channel
{
    public class MessageResource : Resource
    {
    

    
        public sealed class OrderTypeEnum : StringEnum
        {
            private OrderTypeEnum(string value) : base(value) {}
            public OrderTypeEnum() {}
            public static implicit operator OrderTypeEnum(string value)
            {
                return new OrderTypeEnum(value);
            }
            public static readonly OrderTypeEnum Asc = new OrderTypeEnum("asc");
            public static readonly OrderTypeEnum Desc = new OrderTypeEnum("desc");

        }

        
        private static Request BuildCreateRequest(CreateMessageOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Channels/{ChannelSid}/Messages";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathChannelSid = options.PathChannelSid;
            path = path.Replace("{"+"ChannelSid"+"}", PathChannelSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.IpMessaging,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Create(CreateMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> CreateAsync(CreateMessageOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="body">  </param>
        /// <param name="from">  </param>
        /// <param name="attributes">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Create(
                                          string pathServiceSid,
                                          string pathChannelSid,
                                          string body,
                                          string from = null,
                                          string attributes = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateMessageOptions(pathServiceSid, pathChannelSid, body){  From = from, Attributes = attributes };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="body">  </param>
        /// <param name="from">  </param>
        /// <param name="attributes">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  string pathChannelSid,
                                                                                  string body,
                                                                                  string from = null,
                                                                                  string attributes = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateMessageOptions(pathServiceSid, pathChannelSid, body){  From = from, Attributes = attributes };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> delete </summary>
        /// <param name="options"> Delete Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        private static Request BuildDeleteRequest(DeleteMessageOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Channels/{ChannelSid}/Messages/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathChannelSid = options.PathChannelSid;
            path = path.Replace("{"+"ChannelSid"+"}", PathChannelSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.IpMessaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static bool Delete(DeleteMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteMessageOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static bool Delete(string pathServiceSid, string pathChannelSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteMessageOptions(pathServiceSid, pathChannelSid, pathSid)           ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathChannelSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteMessageOptions(pathServiceSid, pathChannelSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchMessageOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Channels/{ChannelSid}/Messages/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathChannelSid = options.PathChannelSid;
            path = path.Replace("{"+"ChannelSid"+"}", PathChannelSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Fetch(FetchMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> FetchAsync(FetchMessageOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Fetch(
                                         string pathServiceSid, 
                                         string pathChannelSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchMessageOptions(pathServiceSid, pathChannelSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> FetchAsync(string pathServiceSid, string pathChannelSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchMessageOptions(pathServiceSid, pathChannelSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadMessageOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Channels/{ChannelSid}/Messages";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathChannelSid = options.PathChannelSid;
            path = path.Replace("{"+"ChannelSid"+"}", PathChannelSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static ResourceSet<MessageResource> Read(ReadMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<MessageResource>.FromJson("messages", response.Content);
            return new ResourceSet<MessageResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MessageResource>> ReadAsync(ReadMessageOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<MessageResource>.FromJson("messages", response.Content);
            return new ResourceSet<MessageResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="order">  </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static ResourceSet<MessageResource> Read(
                                                     string pathServiceSid,
                                                     string pathChannelSid,
                                                     MessageResource.OrderTypeEnum order = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadMessageOptions(pathServiceSid, pathChannelSid){ Order = order, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="order">  </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MessageResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             string pathChannelSid,
                                                                                             MessageResource.OrderTypeEnum order = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadMessageOptions(pathServiceSid, pathChannelSid){ Order = order, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<MessageResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<MessageResource> NextPage(Page<MessageResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<MessageResource> PreviousPage(Page<MessageResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<MessageResource>.FromJson("messages", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateMessageOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Channels/{ChannelSid}/Messages/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathChannelSid = options.PathChannelSid;
            path = path.Replace("{"+"ChannelSid"+"}", PathChannelSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.IpMessaging,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Update(UpdateMessageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Message parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<MessageResource> UpdateAsync(UpdateMessageOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="body">  </param>
        /// <param name="attributes">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Message </returns>
        public static MessageResource Update(
                                          string pathServiceSid,
                                          string pathChannelSid,
                                          string pathSid,
                                          string body = null,
                                          string attributes = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateMessageOptions(pathServiceSid, pathChannelSid, pathSid){ Body = body, Attributes = attributes };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="body">  </param>
        /// <param name="attributes">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Message </returns>
        public static async System.Threading.Tasks.Task<MessageResource> UpdateAsync(
                                                                              string pathServiceSid,
                                                                              string pathChannelSid,
                                                                              string pathSid,
                                                                              string body = null,
                                                                              string attributes = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateMessageOptions(pathServiceSid, pathChannelSid, pathSid){ Body = body, Attributes = attributes };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a MessageResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MessageResource object represented by the provided JSON </returns>
        public static MessageResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<MessageResource>(json);
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

    
        ///<summary> The sid </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The account_sid </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The attributes </summary> 
        [JsonProperty("attributes")]
        public string Attributes { get; private set; }

        ///<summary> The service_sid </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The to </summary> 
        [JsonProperty("to")]
        public string To { get; private set; }

        ///<summary> The channel_sid </summary> 
        [JsonProperty("channel_sid")]
        public string ChannelSid { get; private set; }

        ///<summary> The date_created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date_updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The was_edited </summary> 
        [JsonProperty("was_edited")]
        public bool? WasEdited { get; private set; }

        ///<summary> The from </summary> 
        [JsonProperty("from")]
        public string From { get; private set; }

        ///<summary> The body </summary> 
        [JsonProperty("body")]
        public string Body { get; private set; }

        ///<summary> The index </summary> 
        [JsonProperty("index")]
        public int? Index { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private MessageResource() {

        }
    }
}

