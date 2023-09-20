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




namespace Twilio.Rest.Api.V2010.Account.Queue
{
    /// <summary> Fetch a specific member from the queue </summary>
    public class FetchMemberOptions : IOptions<MemberResource>
    {
    
        ///<summary> The SID of the Queue in which to find the members to fetch. </summary> 
        public string PathQueueSid { get; }

        ///<summary> The [Call](https://www.twilio.com/docs/voice/api/call-resource) SID of the resource(s) to fetch. </summary> 
        public string PathCallSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Member resource(s) to fetch. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchMemberOptions </summary>
        /// <param name="pathQueueSid"> The SID of the Queue in which to find the members to fetch. </param>
        /// <param name="pathCallSid"> The [Call](https://www.twilio.com/docs/voice/api/call-resource) SID of the resource(s) to fetch. </param>
        public FetchMemberOptions(string pathQueueSid, string pathCallSid)
        {
            PathQueueSid = pathQueueSid;
            PathCallSid = pathCallSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve the members of the queue </summary>
    public class ReadMemberOptions : ReadOptions<MemberResource>
    {
    
        ///<summary> The SID of the Queue in which to find the members </summary> 
        public string PathQueueSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Member resource(s) to read. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new ListMemberOptions </summary>
        /// <param name="pathQueueSid"> The SID of the Queue in which to find the members </param>
        public ReadMemberOptions(string pathQueueSid)
        {
            PathQueueSid = pathQueueSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Dequeue a member from a queue and have the member's call begin executing the TwiML document at that URL </summary>
    public class UpdateMemberOptions : IOptions<MemberResource>
    {
    
        ///<summary> The SID of the Queue in which to find the members to update. </summary> 
        public string PathQueueSid { get; }

        ///<summary> The [Call](https://www.twilio.com/docs/voice/api/call-resource) SID of the resource(s) to update. </summary> 
        public string PathCallSid { get; }

        ///<summary> The absolute URL of the Queue resource. </summary> 
        public Uri Url { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Member resource(s) to update. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> How to pass the update request data. Can be `GET` or `POST` and the default is `POST`. `POST` sends the data as encoded form data and `GET` sends the data as query parameters. </summary> 
        public Twilio.Http.HttpMethod Method { get; set; }



        /// <summary> Construct a new UpdateMemberOptions </summary>
        /// <param name="pathQueueSid"> The SID of the Queue in which to find the members to update. </param>
        /// <param name="pathCallSid"> The [Call](https://www.twilio.com/docs/voice/api/call-resource) SID of the resource(s) to update. </param>
        /// <param name="url"> The absolute URL of the Queue resource. </param>
        public UpdateMemberOptions(string pathQueueSid, string pathCallSid, Uri url)
        {
            PathQueueSid = pathQueueSid;
            PathCallSid = pathCallSid;
            Url = url;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Url != null)
            {
                p.Add(new KeyValuePair<string, string>("Url", Serializers.Url(Url)));
            }
            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method.ToString()));
            }
            return p;
        }
        

    }


}

