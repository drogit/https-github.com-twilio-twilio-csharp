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

    /// <summary> Create a new Compliance Registration Inquiry for the authenticated account. This is necessary to start a new embedded session. </summary>
    public class CreateComplianceRegistrationInquiriesOptions : IOptions<ComplianceRegistrationInquiriesResource>
    {
        
        
        public ComplianceRegistrationInquiriesResource.EndUserTypeEnum EndUserType { get; }

        
        public ComplianceRegistrationInquiriesResource.PhoneNumberTypeEnum PhoneNumberType { get; }

        
        public ComplianceRegistrationInquiriesResource.BusinessIdentityTypeEnum BusinessIdentityType { get; set; }

        ///<summary> The authority that registered the business </summary> 
        public string BusinessRegistrationAuthority { get; set; }

        ///<summary> he name of the business or organization using the Tollfree number. </summary> 
        public string BusinessLegalName { get; set; }

        ///<summary> he email address to receive the notification about the verification result. </summary> 
        public string NotificationEmail { get; set; }

        ///<summary> The email address to receive the notification about the verification result. </summary> 
        public bool? AcceptedNotificationReceipt { get; set; }

        ///<summary> Business registration number of the business </summary> 
        public string BusinessRegistrationNumber { get; set; }

        ///<summary> The URL of the business website </summary> 
        public string BusinessWebsiteUrl { get; set; }

        ///<summary> Friendly name for your business information </summary> 
        public string FriendlyName { get; set; }

        ///<summary> First name of the authorized representative </summary> 
        public string AuthorizedRepresentative1FirstName { get; set; }

        ///<summary> Last name of the authorized representative </summary> 
        public string AuthorizedRepresentative1LastName { get; set; }

        ///<summary> Phone number of the authorized representative </summary> 
        public string AuthorizedRepresentative1Phone { get; set; }

        ///<summary> Email address of the authorized representative </summary> 
        public string AuthorizedRepresentative1Email { get; set; }

        ///<summary> Birthdate of the authorized representative </summary> 
        public string AuthorizedRepresentative1DateOfBirth { get; set; }

        ///<summary> Street address of the business </summary> 
        public string AddressStreet { get; set; }

        ///<summary> Street address of the business </summary> 
        public string AddressStreetSecondary { get; set; }

        ///<summary> City of the business </summary> 
        public string AddressCity { get; set; }

        ///<summary> State or province of the business </summary> 
        public string AddressSubdivision { get; set; }

        ///<summary> Postal code of the business </summary> 
        public string AddressPostalCode { get; set; }

        ///<summary> Country code of the business </summary> 
        public string AddressCountryCode { get; set; }

        ///<summary> Street address of the business </summary> 
        public string EmergencyAddressStreet { get; set; }

        ///<summary> Street address of the business </summary> 
        public string EmergencyAddressStreetSecondary { get; set; }

        ///<summary> City of the business </summary> 
        public string EmergencyAddressCity { get; set; }

        ///<summary> State or province of the business </summary> 
        public string EmergencyAddressSubdivision { get; set; }

        ///<summary> Postal code of the business </summary> 
        public string EmergencyAddressPostalCode { get; set; }

        ///<summary> Country code of the business </summary> 
        public string EmergencyAddressCountryCode { get; set; }

        ///<summary> Use the business address as the emergency address </summary> 
        public bool? UseAddressAsEmergencyAddress { get; set; }

        ///<summary> The name of the verification document to upload </summary> 
        public string FileName { get; set; }

        ///<summary> The verification document to upload </summary> 
        public string File { get; set; }


        /// <summary> Construct a new CreateComplianceRegistrationOptions </summary>
        /// <param name="endUserType">  </param>
        /// <param name="phoneNumberType">  </param>
        public CreateComplianceRegistrationInquiriesOptions(ComplianceRegistrationInquiriesResource.EndUserTypeEnum endUserType, ComplianceRegistrationInquiriesResource.PhoneNumberTypeEnum phoneNumberType)
        {
            EndUserType = endUserType;
            PhoneNumberType = phoneNumberType;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (EndUserType != null)
            {
                p.Add(new KeyValuePair<string, string>("EndUserType", EndUserType.ToString()));
            }
            if (PhoneNumberType != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumberType", PhoneNumberType.ToString()));
            }
            if (BusinessIdentityType != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessIdentityType", BusinessIdentityType.ToString()));
            }
            if (BusinessRegistrationAuthority != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessRegistrationAuthority", BusinessRegistrationAuthority));
            }
            if (BusinessLegalName != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessLegalName", BusinessLegalName));
            }
            if (NotificationEmail != null)
            {
                p.Add(new KeyValuePair<string, string>("NotificationEmail", NotificationEmail));
            }
            if (AcceptedNotificationReceipt != null)
            {
                p.Add(new KeyValuePair<string, string>("AcceptedNotificationReceipt", AcceptedNotificationReceipt.Value.ToString().ToLower()));
            }
            if (BusinessRegistrationNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessRegistrationNumber", BusinessRegistrationNumber));
            }
            if (BusinessWebsiteUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessWebsiteUrl", BusinessWebsiteUrl));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (AuthorizedRepresentative1FirstName != null)
            {
                p.Add(new KeyValuePair<string, string>("AuthorizedRepresentative1FirstName", AuthorizedRepresentative1FirstName));
            }
            if (AuthorizedRepresentative1LastName != null)
            {
                p.Add(new KeyValuePair<string, string>("AuthorizedRepresentative1LastName", AuthorizedRepresentative1LastName));
            }
            if (AuthorizedRepresentative1Phone != null)
            {
                p.Add(new KeyValuePair<string, string>("AuthorizedRepresentative1Phone", AuthorizedRepresentative1Phone));
            }
            if (AuthorizedRepresentative1Email != null)
            {
                p.Add(new KeyValuePair<string, string>("AuthorizedRepresentative1Email", AuthorizedRepresentative1Email));
            }
            if (AuthorizedRepresentative1DateOfBirth != null)
            {
                p.Add(new KeyValuePair<string, string>("AuthorizedRepresentative1DateOfBirth", AuthorizedRepresentative1DateOfBirth));
            }
            if (AddressStreet != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressStreet", AddressStreet));
            }
            if (AddressStreetSecondary != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressStreetSecondary", AddressStreetSecondary));
            }
            if (AddressCity != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressCity", AddressCity));
            }
            if (AddressSubdivision != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressSubdivision", AddressSubdivision));
            }
            if (AddressPostalCode != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressPostalCode", AddressPostalCode));
            }
            if (AddressCountryCode != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressCountryCode", AddressCountryCode));
            }
            if (EmergencyAddressStreet != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyAddressStreet", EmergencyAddressStreet));
            }
            if (EmergencyAddressStreetSecondary != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyAddressStreetSecondary", EmergencyAddressStreetSecondary));
            }
            if (EmergencyAddressCity != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyAddressCity", EmergencyAddressCity));
            }
            if (EmergencyAddressSubdivision != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyAddressSubdivision", EmergencyAddressSubdivision));
            }
            if (EmergencyAddressPostalCode != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyAddressPostalCode", EmergencyAddressPostalCode));
            }
            if (EmergencyAddressCountryCode != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyAddressCountryCode", EmergencyAddressCountryCode));
            }
            if (UseAddressAsEmergencyAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("UseAddressAsEmergencyAddress", UseAddressAsEmergencyAddress.Value.ToString().ToLower()));
            }
            if (FileName != null)
            {
                p.Add(new KeyValuePair<string, string>("FileName", FileName));
            }
            if (File != null)
            {
                p.Add(new KeyValuePair<string, string>("File", File));
            }
            return p;
        }

        

    }
}
