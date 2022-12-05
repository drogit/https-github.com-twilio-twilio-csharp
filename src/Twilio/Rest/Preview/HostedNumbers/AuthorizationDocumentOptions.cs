/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Preview
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



namespace Twilio.Rest.Preview.HostedNumbers
{

    /// <summary> Create an AuthorizationDocument for authorizing the hosting of phone number capabilities on Twilio's platform. </summary>
    public class CreateAuthorizationDocumentOptions : IOptions<AuthorizationDocumentResource>
    {
        
        ///<summary> A list of HostedNumberOrder sids that this AuthorizationDocument will authorize for hosting phone number capabilities on Twilio's platform. </summary> 
        public List<string> HostedNumberOrderSids { get; }

        ///<summary> A 34 character string that uniquely identifies the Address resource that is associated with this AuthorizationDocument. </summary> 
        public string AddressSid { get; }

        ///<summary> Email that this AuthorizationDocument will be sent to for signing. </summary> 
        public string Email { get; }

        ///<summary> The title of the person authorized to sign the Authorization Document for this phone number. </summary> 
        public string ContactTitle { get; }

        ///<summary> The contact phone number of the person authorized to sign the Authorization Document. </summary> 
        public string ContactPhoneNumber { get; }

        ///<summary> Email recipients who will be informed when an Authorization Document has been sent and signed. </summary> 
        public List<string> CcEmails { get; set; }


        /// <summary> Construct a new CreateHostedNumbersAuthorizationDocumentOptions </summary>
        /// <param name="hostedNumberOrderSids"> A list of HostedNumberOrder sids that this AuthorizationDocument will authorize for hosting phone number capabilities on Twilio's platform. </param>
        /// <param name="addressSid"> A 34 character string that uniquely identifies the Address resource that is associated with this AuthorizationDocument. </param>
        /// <param name="email"> Email that this AuthorizationDocument will be sent to for signing. </param>
        /// <param name="contactTitle"> The title of the person authorized to sign the Authorization Document for this phone number. </param>
        /// <param name="contactPhoneNumber"> The contact phone number of the person authorized to sign the Authorization Document. </param>
        public CreateAuthorizationDocumentOptions(List<string> hostedNumberOrderSids, string addressSid, string email, string contactTitle, string contactPhoneNumber)
        {
            HostedNumberOrderSids = hostedNumberOrderSids;
            AddressSid = addressSid;
            Email = email;
            ContactTitle = contactTitle;
            ContactPhoneNumber = contactPhoneNumber;
            CcEmails = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (HostedNumberOrderSids != null)
            {
                p.AddRange(HostedNumberOrderSids.Select(prop => new KeyValuePair<string, string>("HostedNumberOrderSids", HostedNumberOrderSids)));
            }
            if (AddressSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressSid", AddressSid));
            }
            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }
            if (ContactTitle != null)
            {
                p.Add(new KeyValuePair<string, string>("ContactTitle", ContactTitle));
            }
            if (ContactPhoneNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("ContactPhoneNumber", ContactPhoneNumber));
            }
            if (CcEmails != null)
            {
                p.AddRange(CcEmails.Select(prop => new KeyValuePair<string, string>("CcEmails", CcEmails)));
            }
            return p;
        }
        

    }
    /// <summary> Fetch a specific AuthorizationDocument. </summary>
    public class FetchAuthorizationDocumentOptions : IOptions<AuthorizationDocumentResource>
    {
    
        ///<summary> A 34 character string that uniquely identifies this AuthorizationDocument. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchHostedNumbersAuthorizationDocumentOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this AuthorizationDocument. </param>
        public FetchAuthorizationDocumentOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of AuthorizationDocuments belonging to the account initiating the request. </summary>
    public class ReadAuthorizationDocumentOptions : ReadOptions<AuthorizationDocumentResource>
    {
    
        ///<summary> Email that this AuthorizationDocument will be sent to for signing. </summary> 
        public string Email { get; set; }

        ///<summary> Status of an instance resource. It can hold one of the values: 1. opened 2. signing, 3. signed LOA, 4. canceled, 5. failed. See the section entitled [Status Values](https://www.twilio.com/docs/api/phone-numbers/hosted-number-authorization-documents#status-values) for more information on each of these statuses. </summary> 
        public AuthorizationDocumentResource.StatusEnum Status { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Updates a specific AuthorizationDocument. </summary>
    public class UpdateAuthorizationDocumentOptions : IOptions<AuthorizationDocumentResource>
    {
    
        
        public string PathSid { get; }

        ///<summary> A list of HostedNumberOrder sids that this AuthorizationDocument will authorize for hosting phone number capabilities on Twilio's platform. </summary> 
        public List<string> HostedNumberOrderSids { get; set; }

        ///<summary> A 34 character string that uniquely identifies the Address resource that is associated with this AuthorizationDocument. </summary> 
        public string AddressSid { get; set; }

        ///<summary> Email that this AuthorizationDocument will be sent to for signing. </summary> 
        public string Email { get; set; }

        ///<summary> Email recipients who will be informed when an Authorization Document has been sent and signed </summary> 
        public List<string> CcEmails { get; set; }

        
        public AuthorizationDocumentResource.StatusEnum Status { get; set; }

        ///<summary> The title of the person authorized to sign the Authorization Document for this phone number. </summary> 
        public string ContactTitle { get; set; }

        ///<summary> The contact phone number of the person authorized to sign the Authorization Document. </summary> 
        public string ContactPhoneNumber { get; set; }



        /// <summary> Construct a new UpdateHostedNumbersAuthorizationDocumentOptions </summary>
        /// <param name="pathSid">  </param>
        public UpdateAuthorizationDocumentOptions(string pathSid)
        {
            PathSid = pathSid;
            HostedNumberOrderSids = new List<string>();
            CcEmails = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (HostedNumberOrderSids != null)
            {
                p.AddRange(HostedNumberOrderSids.Select(prop => new KeyValuePair<string, string>("HostedNumberOrderSids", HostedNumberOrderSids)));
            }
            if (AddressSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressSid", AddressSid));
            }
            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }
            if (CcEmails != null)
            {
                p.AddRange(CcEmails.Select(prop => new KeyValuePair<string, string>("CcEmails", CcEmails)));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (ContactTitle != null)
            {
                p.Add(new KeyValuePair<string, string>("ContactTitle", ContactTitle));
            }
            if (ContactPhoneNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("ContactPhoneNumber", ContactPhoneNumber));
            }
            return p;
        }
        

    }


}

