/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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



namespace Twilio.Rest.Api.V2010.Account.Call
{
    public class UserDefinedMessageSubscriptionResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateUserDefinedMessageSubscriptionOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/Calls/{CallSid}/UserDefinedMessageSubscriptions.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathCallSid = options.PathCallSid;
            path = path.Replace("{"+"CallSid"+"}", PathCallSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Subscribe to User Defined Messages for a given Call SID. </summary>
        /// <param name="options"> Create UserDefinedMessageSubscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserDefinedMessageSubscription </returns>
        public static UserDefinedMessageSubscriptionResource Create(CreateUserDefinedMessageSubscriptionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Subscribe to User Defined Messages for a given Call SID. </summary>
        /// <param name="options"> Create UserDefinedMessageSubscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserDefinedMessageSubscription </returns>
        public static async System.Threading.Tasks.Task<UserDefinedMessageSubscriptionResource> CreateAsync(CreateUserDefinedMessageSubscriptionOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Subscribe to User Defined Messages for a given Call SID. </summary>
        /// <param name="pathCallSid"> The SID of the [Call](https://www.twilio.com/docs/voice/api/call-resource) the User Defined Messages subscription is associated with. This refers to the Call SID that is producing the user defined messages. </param>
        /// <param name="callback"> The URL we should call using the `method` to send user defined events to your application. URLs must contain a valid hostname (underscores are not permitted). </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that subscribed to the User Defined Messages. </param>
        /// <param name="idempotencyKey"> A unique string value to identify API call. This should be a unique string value per API call and can be a randomly generated. </param>
        /// <param name="method"> The HTTP method Twilio will use when requesting the above `Url`. Either `GET` or `POST`. Default is `POST`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserDefinedMessageSubscription </returns>
        public static UserDefinedMessageSubscriptionResource Create(
                                          string pathCallSid,
                                          Uri callback,
                                          string pathAccountSid = null,
                                          string idempotencyKey = null,
                                          Twilio.Http.HttpMethod method = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateUserDefinedMessageSubscriptionOptions(pathCallSid, callback){  PathAccountSid = pathAccountSid, IdempotencyKey = idempotencyKey, Method = method };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Subscribe to User Defined Messages for a given Call SID. </summary>
        /// <param name="pathCallSid"> The SID of the [Call](https://www.twilio.com/docs/voice/api/call-resource) the User Defined Messages subscription is associated with. This refers to the Call SID that is producing the user defined messages. </param>
        /// <param name="callback"> The URL we should call using the `method` to send user defined events to your application. URLs must contain a valid hostname (underscores are not permitted). </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that subscribed to the User Defined Messages. </param>
        /// <param name="idempotencyKey"> A unique string value to identify API call. This should be a unique string value per API call and can be a randomly generated. </param>
        /// <param name="method"> The HTTP method Twilio will use when requesting the above `Url`. Either `GET` or `POST`. Default is `POST`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserDefinedMessageSubscription </returns>
        public static async System.Threading.Tasks.Task<UserDefinedMessageSubscriptionResource> CreateAsync(
                                                                                  string pathCallSid,
                                                                                  Uri callback,
                                                                                  string pathAccountSid = null,
                                                                                  string idempotencyKey = null,
                                                                                  Twilio.Http.HttpMethod method = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateUserDefinedMessageSubscriptionOptions(pathCallSid, callback){  PathAccountSid = pathAccountSid, IdempotencyKey = idempotencyKey, Method = method };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a specific User Defined Message Subscription. </summary>
        /// <param name="options"> Delete UserDefinedMessageSubscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserDefinedMessageSubscription </returns>
        private static Request BuildDeleteRequest(DeleteUserDefinedMessageSubscriptionOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/Calls/{CallSid}/UserDefinedMessageSubscriptions/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathCallSid = options.PathCallSid;
            path = path.Replace("{"+"CallSid"+"}", PathCallSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific User Defined Message Subscription. </summary>
        /// <param name="options"> Delete UserDefinedMessageSubscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserDefinedMessageSubscription </returns>
        public static bool Delete(DeleteUserDefinedMessageSubscriptionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific User Defined Message Subscription. </summary>
        /// <param name="options"> Delete UserDefinedMessageSubscription parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserDefinedMessageSubscription </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteUserDefinedMessageSubscriptionOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific User Defined Message Subscription. </summary>
        /// <param name="pathCallSid"> The SID of the [Call](https://www.twilio.com/docs/voice/api/call-resource) the User Defined Message Subscription is associated with. This refers to the Call SID that is producing the User Defined Messages. </param>
        /// <param name="pathSid"> The SID that uniquely identifies this User Defined Message Subscription. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that subscribed to the User Defined Messages. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserDefinedMessageSubscription </returns>
        public static bool Delete(string pathCallSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteUserDefinedMessageSubscriptionOptions(pathCallSid, pathSid)         { PathAccountSid = pathAccountSid }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific User Defined Message Subscription. </summary>
        /// <param name="pathCallSid"> The SID of the [Call](https://www.twilio.com/docs/voice/api/call-resource) the User Defined Message Subscription is associated with. This refers to the Call SID that is producing the User Defined Messages. </param>
        /// <param name="pathSid"> The SID that uniquely identifies this User Defined Message Subscription. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that subscribed to the User Defined Messages. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserDefinedMessageSubscription </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathCallSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteUserDefinedMessageSubscriptionOptions(pathCallSid, pathSid)  { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a UserDefinedMessageSubscriptionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UserDefinedMessageSubscriptionResource object represented by the provided JSON </returns>
        public static UserDefinedMessageSubscriptionResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<UserDefinedMessageSubscriptionResource>(json);
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

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that subscribed to the User Defined Messages. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Call](https://www.twilio.com/docs/voice/api/call-resource) the User Defined Message Subscription is associated with. This refers to the Call SID that is producing the User Defined Messages. </summary> 
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }

        ///<summary> The SID that uniquely identifies this User Defined Message Subscription. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The date that this User Defined Message Subscription was created, given in RFC 2822 format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The URI of the User Defined Message Subscription Resource, relative to `https://api.twilio.com`. </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }



        private UserDefinedMessageSubscriptionResource() {

        }
    }
}

