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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;
using System.Linq;



namespace Twilio.Rest.Chat.V2.Service.Channel
{

    /// <summary> create </summary>
    public class CreateInviteOptions : IOptions<InviteResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the Invite resource under. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the new Invite resource belongs to. This value can be the Channel resource's `sid` or `unique_name`. </summary> 
        public string PathChannelSid { get; }

        ///<summary> The `identity` value that uniquely identifies the new resource's [User](https://www.twilio.com/docs/chat/rest/user-resource) within the [Service](https://www.twilio.com/docs/chat/rest/service-resource). See [access tokens](https://www.twilio.com/docs/chat/create-tokens) for more info. </summary> 
        public string Identity { get; }

        ///<summary> The SID of the [Role](https://www.twilio.com/docs/chat/rest/role-resource) assigned to the new member. </summary> 
        public string RoleSid { get; set; }


        /// <summary> Construct a new CreateInviteOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the Invite resource under. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the new Invite resource belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="identity"> The `identity` value that uniquely identifies the new resource's [User](https://www.twilio.com/docs/chat/rest/user-resource) within the [Service](https://www.twilio.com/docs/chat/rest/service-resource). See [access tokens](https://www.twilio.com/docs/chat/create-tokens) for more info. </param>
        public CreateInviteOptions(string pathServiceSid, string pathChannelSid, string identity)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = identity;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }
            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid));
            }
            return p;
        }

        

    }
    /// <summary> delete </summary>
    public class DeleteInviteOptions : IOptions<InviteResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the Invite resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Invite resource to delete belongs to. This value can be the Channel resource's `sid` or `unique_name`. </summary> 
        public string PathChannelSid { get; }

        ///<summary> The SID of the Invite resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteInviteOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the Invite resource from. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Invite resource to delete belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="pathSid"> The SID of the Invite resource to delete. </param>
        public DeleteInviteOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> fetch </summary>
    public class FetchInviteOptions : IOptions<InviteResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the Invite resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Invite resource to fetch belongs to. This value can be the Channel resource's `sid` or `unique_name`. </summary> 
        public string PathChannelSid { get; }

        ///<summary> The SID of the Invite resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchInviteOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the Invite resource from. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Invite resource to fetch belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="pathSid"> The SID of the Invite resource to fetch. </param>
        public FetchInviteOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> read </summary>
    public class ReadInviteOptions : ReadOptions<InviteResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the Invite resources from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Invite resources to read belong to. This value can be the Channel resource's `sid` or `unique_name`. </summary> 
        public string PathChannelSid { get; }

        ///<summary> The [User](https://www.twilio.com/docs/chat/rest/user-resource)'s `identity` value of the resources to read. See [access tokens](https://www.twilio.com/docs/chat/create-tokens) for more details. </summary> 
        public List<string> Identity { get; set; }



        /// <summary> Construct a new ListInviteOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the Invite resources from. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Invite resources to read belong to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        public ReadInviteOptions(string pathServiceSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Identity != null)
            {
                p.AddRange(Identity.Select(Identity => new KeyValuePair<string, string>("Identity", Identity)));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

}

