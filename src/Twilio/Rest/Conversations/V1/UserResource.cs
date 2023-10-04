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


namespace Twilio.Rest.Conversations.V1
{
    public class UserResource : Resource
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

        
        private static Request BuildCreateRequest(CreateUserOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Users";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Conversations,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> Add a new conversation user to your account's default service </summary>
        /// <param name="options"> Create User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static UserResource Create(CreateUserOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Add a new conversation user to your account's default service </summary>
        /// <param name="options"> Create User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        public static async System.Threading.Tasks.Task<UserResource> CreateAsync(CreateUserOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Add a new conversation user to your account's default service </summary>
        /// <param name="identity"> The application-defined string that uniquely identifies the resource's User within the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource). This value is often a username or an email address, and is case-sensitive. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>
        /// <param name="attributes"> The JSON Object string that stores application-specific data. If attributes have not been set, `{}` is returned. </param>
        /// <param name="roleSid"> The SID of a service-level [Role](https://www.twilio.com/docs/conversations/api/role-resource) to assign to the user. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static UserResource Create(
                                          string identity,
                                          string friendlyName = null,
                                          string attributes = null,
                                          string roleSid = null,
                                          UserResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateUserOptions(identity){  FriendlyName = friendlyName, Attributes = attributes, RoleSid = roleSid, XTwilioWebhookEnabled = xTwilioWebhookEnabled };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Add a new conversation user to your account's default service </summary>
        /// <param name="identity"> The application-defined string that uniquely identifies the resource's User within the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource). This value is often a username or an email address, and is case-sensitive. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>
        /// <param name="attributes"> The JSON Object string that stores application-specific data. If attributes have not been set, `{}` is returned. </param>
        /// <param name="roleSid"> The SID of a service-level [Role](https://www.twilio.com/docs/conversations/api/role-resource) to assign to the user. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        public static async System.Threading.Tasks.Task<UserResource> CreateAsync(
                                                                                  string identity,
                                                                                  string friendlyName = null,
                                                                                  string attributes = null,
                                                                                  string roleSid = null,
                                                                                  UserResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateUserOptions(identity){  FriendlyName = friendlyName, Attributes = attributes, RoleSid = roleSid, XTwilioWebhookEnabled = xTwilioWebhookEnabled };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Remove a conversation user from your account's default service </summary>
        /// <param name="options"> Delete User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        private static Request BuildDeleteRequest(DeleteUserOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Users/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Conversations,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> Remove a conversation user from your account's default service </summary>
        /// <param name="options"> Delete User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static bool Delete(DeleteUserOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Remove a conversation user from your account's default service </summary>
        /// <param name="options"> Delete User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteUserOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Remove a conversation user from your account's default service </summary>
        /// <param name="pathSid"> The SID of the User resource to delete. This value can be either the `sid` or the `identity` of the User resource to delete. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static bool Delete(string pathSid, UserResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null, ITwilioRestClient client = null)
        {
            var options = new DeleteUserOptions(pathSid)      { XTwilioWebhookEnabled = xTwilioWebhookEnabled }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Remove a conversation user from your account's default service </summary>
        /// <param name="pathSid"> The SID of the User resource to delete. This value can be either the `sid` or the `identity` of the User resource to delete. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, UserResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null, ITwilioRestClient client = null)
        {
            var options = new DeleteUserOptions(pathSid)  { XTwilioWebhookEnabled = xTwilioWebhookEnabled };
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchUserOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Users/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a conversation user from your account's default service </summary>
        /// <param name="options"> Fetch User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static UserResource Fetch(FetchUserOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a conversation user from your account's default service </summary>
        /// <param name="options"> Fetch User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        public static async System.Threading.Tasks.Task<UserResource> FetchAsync(FetchUserOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a conversation user from your account's default service </summary>
        /// <param name="pathSid"> The SID of the User resource to fetch. This value can be either the `sid` or the `identity` of the User resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static UserResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchUserOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a conversation user from your account's default service </summary>
        /// <param name="pathSid"> The SID of the User resource to fetch. This value can be either the `sid` or the `identity` of the User resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        public static async System.Threading.Tasks.Task<UserResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchUserOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadUserOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Users";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all conversation users in your account's default service </summary>
        /// <param name="options"> Read User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static ResourceSet<UserResource> Read(ReadUserOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<UserResource>.FromJson("users", response.Content);
            return new ResourceSet<UserResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all conversation users in your account's default service </summary>
        /// <param name="options"> Read User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<UserResource>> ReadAsync(ReadUserOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<UserResource>.FromJson("users", response.Content);
            return new ResourceSet<UserResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all conversation users in your account's default service </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static ResourceSet<UserResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadUserOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all conversation users in your account's default service </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<UserResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadUserOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<UserResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<UserResource>.FromJson("users", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<UserResource> NextPage(Page<UserResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<UserResource>.FromJson("users", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<UserResource> PreviousPage(Page<UserResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<UserResource>.FromJson("users", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateUserOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Users/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Conversations,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> Update an existing conversation user in your account's default service </summary>
        /// <param name="options"> Update User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static UserResource Update(UpdateUserOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update an existing conversation user in your account's default service </summary>
        /// <param name="options"> Update User parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<UserResource> UpdateAsync(UpdateUserOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update an existing conversation user in your account's default service </summary>
        /// <param name="pathSid"> The SID of the User resource to update. This value can be either the `sid` or the `identity` of the User resource to update. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>
        /// <param name="attributes"> The JSON Object string that stores application-specific data. If attributes have not been set, `{}` is returned. </param>
        /// <param name="roleSid"> The SID of a service-level [Role](https://www.twilio.com/docs/conversations/api/role-resource) to assign to the user. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of User </returns>
        public static UserResource Update(
                                          string pathSid,
                                          string friendlyName = null,
                                          string attributes = null,
                                          string roleSid = null,
                                          UserResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateUserOptions(pathSid){ FriendlyName = friendlyName, Attributes = attributes, RoleSid = roleSid, XTwilioWebhookEnabled = xTwilioWebhookEnabled };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update an existing conversation user in your account's default service </summary>
        /// <param name="pathSid"> The SID of the User resource to update. This value can be either the `sid` or the `identity` of the User resource to update. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>
        /// <param name="attributes"> The JSON Object string that stores application-specific data. If attributes have not been set, `{}` is returned. </param>
        /// <param name="roleSid"> The SID of a service-level [Role](https://www.twilio.com/docs/conversations/api/role-resource) to assign to the user. </param>
        /// <param name="xTwilioWebhookEnabled"> The X-Twilio-Webhook-Enabled HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of User </returns>
        public static async System.Threading.Tasks.Task<UserResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              string attributes = null,
                                                                              string roleSid = null,
                                                                              UserResource.WebhookEnabledTypeEnum xTwilioWebhookEnabled = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateUserOptions(pathSid){ FriendlyName = friendlyName, Attributes = attributes, RoleSid = roleSid, XTwilioWebhookEnabled = xTwilioWebhookEnabled };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a UserResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UserResource object represented by the provided JSON </returns>
        public static UserResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<UserResource>(json);
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

    
        ///<summary> The unique string that we created to identify the User resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the User resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the User resource is associated with. </summary> 
        [JsonProperty("chat_service_sid")]
        public string ChatServiceSid { get; private set; }

        ///<summary> The SID of a service-level [Role](https://www.twilio.com/docs/conversations/api/role-resource) assigned to the user. </summary> 
        [JsonProperty("role_sid")]
        public string RoleSid { get; private set; }

        ///<summary> The application-defined string that uniquely identifies the resource's User within the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource). This value is often a username or an email address, and is case-sensitive. </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The JSON Object string that stores application-specific data. If attributes have not been set, `{}` is returned. </summary> 
        [JsonProperty("attributes")]
        public string Attributes { get; private set; }

        ///<summary> Whether the User is actively connected to this Conversations Service and online. This value is only returned by Fetch actions that return a single resource and `null` is always returned by a Read action. This value is `null` if the Service's `reachability_enabled` is `false`, if the User has never been online for this Conversations Service, even if the Service's `reachability_enabled` is `true`. </summary> 
        [JsonProperty("is_online")]
        public bool? IsOnline { get; private set; }

        ///<summary> Whether the User has a potentially valid Push Notification registration (APN or GCM) for this Conversations Service. If at least one registration exists, `true`; otherwise `false`. This value is only returned by Fetch actions that return a single resource and `null` is always returned by a Read action. This value is `null` if the Service's `reachability_enabled` is `false`, and if the User has never had a notification registration, even if the Service's `reachability_enabled` is `true`. </summary> 
        [JsonProperty("is_notifiable")]
        public bool? IsNotifiable { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> An absolute API resource URL for this user. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The links </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private UserResource() {

        }
    }
}

