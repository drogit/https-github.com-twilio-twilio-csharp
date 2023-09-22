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



namespace Twilio.Rest.IpMessaging.V1.Service.Channel
{
    public class InviteResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateInviteOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Channels/{ChannelSid}/Invites";

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
        /// <param name="options"> Create Invite parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Invite </returns>
        public static InviteResource Create(CreateInviteOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Invite parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Invite </returns>
        public static async System.Threading.Tasks.Task<InviteResource> CreateAsync(CreateInviteOptions options,
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
        /// <param name="identity">  </param>
        /// <param name="roleSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Invite </returns>
        public static InviteResource Create(
                                          string pathServiceSid,
                                          string pathChannelSid,
                                          string identity,
                                          string roleSid = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateInviteOptions(pathServiceSid, pathChannelSid, identity){  RoleSid = roleSid };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="identity">  </param>
        /// <param name="roleSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Invite </returns>
        public static async System.Threading.Tasks.Task<InviteResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  string pathChannelSid,
                                                                                  string identity,
                                                                                  string roleSid = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateInviteOptions(pathServiceSid, pathChannelSid, identity){  RoleSid = roleSid };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> delete </summary>
        /// <param name="options"> Delete Invite parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Invite </returns>
        private static Request BuildDeleteRequest(DeleteInviteOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Channels/{ChannelSid}/Invites/{Sid}";

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
        /// <param name="options"> Delete Invite parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Invite </returns>
        public static bool Delete(DeleteInviteOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Invite parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Invite </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteInviteOptions options,
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
        /// <returns> A single instance of Invite </returns>
        public static bool Delete(string pathServiceSid, string pathChannelSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteInviteOptions(pathServiceSid, pathChannelSid, pathSid)           ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Invite </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathChannelSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteInviteOptions(pathServiceSid, pathChannelSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchInviteOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Channels/{ChannelSid}/Invites/{Sid}";

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
        /// <param name="options"> Fetch Invite parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Invite </returns>
        public static InviteResource Fetch(FetchInviteOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Invite parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Invite </returns>
        public static async System.Threading.Tasks.Task<InviteResource> FetchAsync(FetchInviteOptions options,
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
        /// <returns> A single instance of Invite </returns>
        public static InviteResource Fetch(
                                         string pathServiceSid, 
                                         string pathChannelSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchInviteOptions(pathServiceSid, pathChannelSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Invite </returns>
        public static async System.Threading.Tasks.Task<InviteResource> FetchAsync(string pathServiceSid, string pathChannelSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchInviteOptions(pathServiceSid, pathChannelSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadInviteOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Channels/{ChannelSid}/Invites";

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
        /// <param name="options"> Read Invite parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Invite </returns>
        public static ResourceSet<InviteResource> Read(ReadInviteOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<InviteResource>.FromJson("invites", response.Content);
            return new ResourceSet<InviteResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Invite parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Invite </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InviteResource>> ReadAsync(ReadInviteOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<InviteResource>.FromJson("invites", response.Content);
            return new ResourceSet<InviteResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="identity">  </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Invite </returns>
        public static ResourceSet<InviteResource> Read(
                                                     string pathServiceSid,
                                                     string pathChannelSid,
                                                     List<string> identity = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadInviteOptions(pathServiceSid, pathChannelSid){ Identity = identity, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathChannelSid">  </param>
        /// <param name="identity">  </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Invite </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InviteResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             string pathChannelSid,
                                                                                             List<string> identity = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadInviteOptions(pathServiceSid, pathChannelSid){ Identity = identity, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<InviteResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<InviteResource>.FromJson("invites", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<InviteResource> NextPage(Page<InviteResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InviteResource>.FromJson("invites", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<InviteResource> PreviousPage(Page<InviteResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InviteResource>.FromJson("invites", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a InviteResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InviteResource object represented by the provided JSON </returns>
        public static InviteResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<InviteResource>(json);
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

        ///<summary> The channel_sid </summary> 
        [JsonProperty("channel_sid")]
        public string ChannelSid { get; private set; }

        ///<summary> The service_sid </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The identity </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }

        ///<summary> The date_created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date_updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The role_sid </summary> 
        [JsonProperty("role_sid")]
        public string RoleSid { get; private set; }

        ///<summary> The created_by </summary> 
        [JsonProperty("created_by")]
        public string CreatedBy { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private InviteResource() {

        }
    }
}

