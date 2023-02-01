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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Api.V2010.Account.Call
{

    /// <summary> Subscribe to User Defined Messages for a given Call SID. </summary>
    public class CreateUserDefinedMessageSubscriptionOptions : IOptions<UserDefinedMessageSubscriptionResource>
    {
        
        ///<summary> The SID of the [Call](https://www.twilio.com/docs/voice/api/call-resource) the User Defined Messages subscription is associated with. This refers to the Call SID that is producing the user defined messages. </summary> 
        public string PathCallSid { get; }

        ///<summary> The URL we should call using the `method` to send user defined events to your application. URLs must contain a valid hostname (underscores are not permitted). </summary> 
        public Uri Callback { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that subscribed to the User Defined Messages. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> A unique string value to identify API call. This should be a unique string value per API call and can be a randomly generated. </summary> 
        public string IdempotencyKey { get; set; }

        ///<summary> The HTTP method Twilio will use when requesting the above `Url`. Either `GET` or `POST`. Default is `POST`. </summary> 
        public Twilio.Http.HttpMethod Method { get; set; }


        /// <summary> Construct a new CreateUserDefinedMessageSubscriptionOptions </summary>
        /// <param name="pathCallSid"> The SID of the [Call](https://www.twilio.com/docs/voice/api/call-resource) the User Defined Messages subscription is associated with. This refers to the Call SID that is producing the user defined messages. </param>
        /// <param name="callback"> The URL we should call using the `method` to send user defined events to your application. URLs must contain a valid hostname (underscores are not permitted). </param>
        public CreateUserDefinedMessageSubscriptionOptions(string pathCallSid, Uri callback)
        {
            PathCallSid = pathCallSid;
            Callback = callback;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Callback != null)
            {
                p.Add(new KeyValuePair<string, string>("Callback", Serializers.Url(Callback)));
            }
            if (IdempotencyKey != null)
            {
                p.Add(new KeyValuePair<string, string>("IdempotencyKey", IdempotencyKey));
            }
            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> Delete a specific User Defined Message Subscription. </summary>
    public class DeleteUserDefinedMessageSubscriptionOptions : IOptions<UserDefinedMessageSubscriptionResource>
    {
        
        ///<summary> The SID of the [Call](https://www.twilio.com/docs/voice/api/call-resource) the User Defined Message Subscription is associated with. This refers to the Call SID that is producing the User Defined Messages. </summary> 
        public string PathCallSid { get; }

        ///<summary> The SID that uniquely identifies this User Defined Message Subscription. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that subscribed to the User Defined Messages. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteUserDefinedMessageSubscriptionOptions </summary>
        /// <param name="pathCallSid"> The SID of the [Call](https://www.twilio.com/docs/voice/api/call-resource) the User Defined Message Subscription is associated with. This refers to the Call SID that is producing the User Defined Messages. </param>
        /// <param name="pathSid"> The SID that uniquely identifies this User Defined Message Subscription. </param>
        public DeleteUserDefinedMessageSubscriptionOptions(string pathCallSid, string pathSid)
        {
            PathCallSid = pathCallSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


}

