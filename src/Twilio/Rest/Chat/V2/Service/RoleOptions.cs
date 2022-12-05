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



namespace Twilio.Rest.Chat.V2.Service
{

    /// <summary> create </summary>
    public class CreateRoleOptions : IOptions<RoleResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the Role resource under. </summary> 
        public string PathServiceSid { get; }

        ///<summary> A descriptive string that you create to describe the new resource. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; }

        
        public RoleResource.RoleTypeEnum Type { get; }

        ///<summary> A permission that you grant to the new role. Only one permission can be granted per parameter. To assign more than one permission, repeat this parameter for each permission value. The values for this parameter depend on the role's `type`. </summary> 
        public List<string> Permission { get; }


        /// <summary> Construct a new CreateRoleOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the Role resource under. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new resource. It can be up to 64 characters long. </param>
        /// <param name="type">  </param>
        /// <param name="permission"> A permission that you grant to the new role. Only one permission can be granted per parameter. To assign more than one permission, repeat this parameter for each permission value. The values for this parameter depend on the role's `type`. </param>
        public CreateRoleOptions(string pathServiceSid, string friendlyName, RoleResource.RoleTypeEnum type, List<string> permission)
        {
            PathServiceSid = pathServiceSid;
            FriendlyName = friendlyName;
            Type = type;
            Permission = permission;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }
            if (Permission != null)
            {
                p.AddRange(Permission.Select(prop => new KeyValuePair<string, string>("Permission", Permission)));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteRoleOptions : IOptions<RoleResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the Role resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Role resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteRoleOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the Role resource from. </param>
        /// <param name="pathSid"> The SID of the Role resource to delete. </param>
        public DeleteRoleOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> fetch </summary>
    public class FetchRoleOptions : IOptions<RoleResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the Role resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Role resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchRoleOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the Role resource from. </param>
        /// <param name="pathSid"> The SID of the Role resource to fetch. </param>
        public FetchRoleOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> read </summary>
    public class ReadRoleOptions : ReadOptions<RoleResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the Role resources from. </summary> 
        public string PathServiceSid { get; }



        /// <summary> Construct a new ListRoleOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the Role resources from. </param>
        public ReadRoleOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
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

    /// <summary> update </summary>
    public class UpdateRoleOptions : IOptions<RoleResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to update the Role resource in. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Role resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> A permission that you grant to the role. Only one permission can be granted per parameter. To assign more than one permission, repeat this parameter for each permission value. Note that the update action replaces all previously assigned permissions with those defined in the update action. To remove a permission, do not include it in the subsequent update action. The values for this parameter depend on the role's `type`. </summary> 
        public List<string> Permission { get; }



        /// <summary> Construct a new UpdateRoleOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to update the Role resource in. </param>
        /// <param name="pathSid"> The SID of the Role resource to update. </param>
        /// <param name="permission"> A permission that you grant to the role. Only one permission can be granted per parameter. To assign more than one permission, repeat this parameter for each permission value. Note that the update action replaces all previously assigned permissions with those defined in the update action. To remove a permission, do not include it in the subsequent update action. The values for this parameter depend on the role's `type`. </param>
        public UpdateRoleOptions(string pathServiceSid, string pathSid, List<string> permission)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
            Permission = permission;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Permission != null)
            {
                p.AddRange(Permission.Select(prop => new KeyValuePair<string, string>("Permission", Permission)));
            }
            return p;
        }
        

    }


}

