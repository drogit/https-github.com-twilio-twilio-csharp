/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Accounts
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




namespace Twilio.Rest.Accounts.V1.Credential
{

    /// <summary> Create a new Public Key Credential </summary>
    public class CreatePublicKeyOptions : IOptions<PublicKeyResource>
    {
        
        ///<summary> A URL encoded representation of the public key. For example, `- - - - -BEGIN PUBLIC KEY- - - - -MIIBIjANB.pa9xQIDAQAB- - - - -END PUBLIC KEY- - - - -` </summary> 
        public string PublicKey { get; }

        ///<summary> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The SID of the Subaccount that this Credential should be associated with. Must be a valid Subaccount of the account issuing the request </summary> 
        public string AccountSid { get; set; }


        /// <summary> Construct a new CreateCredentialPublicKeyOptions </summary>
        /// <param name="publicKey"> A URL encoded representation of the public key. For example, `- - - - -BEGIN PUBLIC KEY- - - - -MIIBIjANB.pa9xQIDAQAB- - - - -END PUBLIC KEY- - - - -` </param>
        public CreatePublicKeyOptions(string publicKey)
        {
            PublicKey = publicKey;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PublicKey != null)
            {
                p.Add(new KeyValuePair<string, string>("PublicKey", PublicKey));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (AccountSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AccountSid", AccountSid));
            }
            return p;
        }
        

    }
    /// <summary> Delete a Credential from your account </summary>
    public class DeletePublicKeyOptions : IOptions<PublicKeyResource>
    {
        
        ///<summary> The Twilio-provided string that uniquely identifies the PublicKey resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteCredentialPublicKeyOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the PublicKey resource to delete. </param>
        public DeletePublicKeyOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch the public key specified by the provided Credential Sid </summary>
    public class FetchPublicKeyOptions : IOptions<PublicKeyResource>
    {
    
        ///<summary> The Twilio-provided string that uniquely identifies the PublicKey resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchCredentialPublicKeyOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the PublicKey resource to fetch. </param>
        public FetchPublicKeyOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieves a collection of Public Key Credentials belonging to the account used to make the request </summary>
    public class ReadPublicKeyOptions : ReadOptions<PublicKeyResource>
    {
    



        
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

    /// <summary> Modify the properties of a given Account </summary>
    public class UpdatePublicKeyOptions : IOptions<PublicKeyResource>
    {
    
        ///<summary> The Twilio-provided string that uniquely identifies the PublicKey resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; set; }



        /// <summary> Construct a new UpdateCredentialPublicKeyOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the PublicKey resource to update. </param>
        public UpdatePublicKeyOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            return p;
        }
        

    }


}

