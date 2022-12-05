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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;
using System.Linq;



namespace Twilio.Rest.IpMessaging.V2.Service
{

    /// <summary> create </summary>
    public class CreateRoleOptions : IOptions<RoleResource>
    {
        
        
        public string PathServiceSid { get; }

        
        public string FriendlyName { get; }

        
        public RoleResource.RoleTypeEnum Type { get; }

        
        public List<string> Permission { get; }


        /// <summary> Construct a new CreateRoleOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="friendlyName">  </param>
        /// <param name="type">  </param>
        /// <param name="permission">  </param>
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
        
        
        public string PathServiceSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new DeleteRoleOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathSid">  </param>
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
    
        
        public string PathServiceSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new FetchRoleOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathSid">  </param>
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
    
        
        public string PathServiceSid { get; }



        /// <summary> Construct a new ListRoleOptions </summary>
        /// <param name="pathServiceSid">  </param>
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
    
        
        public string PathServiceSid { get; }

        
        public string PathSid { get; }

        
        public List<string> Permission { get; }



        /// <summary> Construct a new UpdateRoleOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="permission">  </param>
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

