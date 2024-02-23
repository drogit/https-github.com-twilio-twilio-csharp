/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Trusthub
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




namespace Twilio.Rest.Trusthub.V1
{

    /// <summary> Create a new Compliance Inquiry for the authenticated account. This is necessary to start a new embedded session. </summary>
    public class CreateComplianceInquiriesOptions : IOptions<ComplianceInquiriesResource>
    {
        
        ///<summary> The unique SID identifier of the Primary Customer Profile that should be used as a parent. Only necessary when creating a secondary Customer Profile. </summary> 
        public string PrimaryProfileSid { get; }


        /// <summary> Construct a new CreateComplianceInquiryOptions </summary>
        /// <param name="primaryProfileSid"> The unique SID identifier of the Primary Customer Profile that should be used as a parent. Only necessary when creating a secondary Customer Profile. </param>
        public CreateComplianceInquiriesOptions(string primaryProfileSid)
        {
            PrimaryProfileSid = primaryProfileSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PrimaryProfileSid != null)
            {
                p.Add(new KeyValuePair<string, string>("PrimaryProfileSid", PrimaryProfileSid));
            }
            return p;
        }

        

    }
    /// <summary> Resume a specific Compliance Inquiry that has expired, or re-open a rejected Compliance Inquiry for editing. </summary>
    public class UpdateComplianceInquiriesOptions : IOptions<ComplianceInquiriesResource>
    {
    
        ///<summary> The unique CustomerId matching the Customer Profile/Compliance Inquiry that should be resumed or resubmitted. This value will have been returned by the initial Compliance Inquiry creation call. </summary> 
        public string PathCustomerId { get; }

        ///<summary> The unique SID identifier of the Primary Customer Profile that should be used as a parent. Only necessary when creating a secondary Customer Profile. </summary> 
        public string PrimaryProfileSid { get; }



        /// <summary> Construct a new UpdateComplianceInquiryOptions </summary>
        /// <param name="pathCustomerId"> The unique CustomerId matching the Customer Profile/Compliance Inquiry that should be resumed or resubmitted. This value will have been returned by the initial Compliance Inquiry creation call. </param>
        /// <param name="primaryProfileSid"> The unique SID identifier of the Primary Customer Profile that should be used as a parent. Only necessary when creating a secondary Customer Profile. </param>
        public UpdateComplianceInquiriesOptions(string pathCustomerId, string primaryProfileSid)
        {
            PathCustomerId = pathCustomerId;
            PrimaryProfileSid = primaryProfileSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PrimaryProfileSid != null)
            {
                p.Add(new KeyValuePair<string, string>("PrimaryProfileSid", PrimaryProfileSid));
            }
            return p;
        }

        

    }


}

