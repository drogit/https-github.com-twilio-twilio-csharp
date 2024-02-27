/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
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



namespace Twilio.Rest.Messaging.V1
{

    /// <summary> create </summary>
    public class CreateTollfreeVerificationOptions : IOptions<TollfreeVerificationResource>
    {
        
        ///<summary> The name of the business or organization using the Tollfree number. </summary> 
        public string BusinessName { get; }

        ///<summary> The website of the business or organization using the Tollfree number. </summary> 
        public string BusinessWebsite { get; }

        ///<summary> The email address to receive the notification about the verification result. . </summary> 
        public string NotificationEmail { get; }

        ///<summary> The category of the use case for the Tollfree Number. List as many are applicable.. </summary> 
        public List<string> UseCaseCategories { get; }

        ///<summary> Use this to further explain how messaging is used by the business or organization. </summary> 
        public string UseCaseSummary { get; }

        ///<summary> An example of message content, i.e. a sample message. </summary> 
        public string ProductionMessageSample { get; }

        ///<summary> Link to an image that shows the opt-in workflow. Multiple images allowed and must be a publicly hosted URL. </summary> 
        public List<string> OptInImageUrls { get; }

        
        public TollfreeVerificationResource.OptInTypeEnum OptInType { get; }

        ///<summary> Estimate monthly volume of messages from the Tollfree Number. </summary> 
        public string MessageVolume { get; }

        ///<summary> The SID of the Phone Number associated with the Tollfree Verification. </summary> 
        public string TollfreePhoneNumberSid { get; }

        ///<summary> Customer's Profile Bundle BundleSid. </summary> 
        public string CustomerProfileSid { get; set; }

        ///<summary> The address of the business or organization using the Tollfree number. </summary> 
        public string BusinessStreetAddress { get; set; }

        ///<summary> The address of the business or organization using the Tollfree number. </summary> 
        public string BusinessStreetAddress2 { get; set; }

        ///<summary> The city of the business or organization using the Tollfree number. </summary> 
        public string BusinessCity { get; set; }

        ///<summary> The state/province/region of the business or organization using the Tollfree number. </summary> 
        public string BusinessStateProvinceRegion { get; set; }

        ///<summary> The postal code of the business or organization using the Tollfree number. </summary> 
        public string BusinessPostalCode { get; set; }

        ///<summary> The country of the business or organization using the Tollfree number. </summary> 
        public string BusinessCountry { get; set; }

        ///<summary> Additional information to be provided for verification. </summary> 
        public string AdditionalInformation { get; set; }

        ///<summary> The first name of the contact for the business or organization using the Tollfree number. </summary> 
        public string BusinessContactFirstName { get; set; }

        ///<summary> The last name of the contact for the business or organization using the Tollfree number. </summary> 
        public string BusinessContactLastName { get; set; }

        ///<summary> The email address of the contact for the business or organization using the Tollfree number. </summary> 
        public string BusinessContactEmail { get; set; }

        ///<summary> The E.164 formatted phone number of the contact for the business or organization using the Tollfree number. </summary> 
        public Types.PhoneNumber BusinessContactPhone { get; set; }

        ///<summary> An optional external reference ID supplied by customer and echoed back on status retrieval. </summary> 
        public string ExternalReferenceId { get; set; }


        /// <summary> Construct a new CreateTollfreeVerificationOptions </summary>
        /// <param name="businessName"> The name of the business or organization using the Tollfree number. </param>
        /// <param name="businessWebsite"> The website of the business or organization using the Tollfree number. </param>
        /// <param name="notificationEmail"> The email address to receive the notification about the verification result. . </param>
        /// <param name="useCaseCategories"> The category of the use case for the Tollfree Number. List as many are applicable.. </param>
        /// <param name="useCaseSummary"> Use this to further explain how messaging is used by the business or organization. </param>
        /// <param name="productionMessageSample"> An example of message content, i.e. a sample message. </param>
        /// <param name="optInImageUrls"> Link to an image that shows the opt-in workflow. Multiple images allowed and must be a publicly hosted URL. </param>
        /// <param name="optInType">  </param>
        /// <param name="messageVolume"> Estimate monthly volume of messages from the Tollfree Number. </param>
        /// <param name="tollfreePhoneNumberSid"> The SID of the Phone Number associated with the Tollfree Verification. </param>
        public CreateTollfreeVerificationOptions(string businessName, string businessWebsite, string notificationEmail, List<string> useCaseCategories, string useCaseSummary, string productionMessageSample, List<string> optInImageUrls, TollfreeVerificationResource.OptInTypeEnum optInType, string messageVolume, string tollfreePhoneNumberSid)
        {
            BusinessName = businessName;
            BusinessWebsite = businessWebsite;
            NotificationEmail = notificationEmail;
            UseCaseCategories = useCaseCategories;
            UseCaseSummary = useCaseSummary;
            ProductionMessageSample = productionMessageSample;
            OptInImageUrls = optInImageUrls;
            OptInType = optInType;
            MessageVolume = messageVolume;
            TollfreePhoneNumberSid = tollfreePhoneNumberSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (BusinessName != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessName", BusinessName));
            }
            if (BusinessWebsite != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessWebsite", BusinessWebsite));
            }
            if (NotificationEmail != null)
            {
                p.Add(new KeyValuePair<string, string>("NotificationEmail", NotificationEmail));
            }
            if (UseCaseCategories != null)
            {
                p.AddRange(UseCaseCategories.Select(UseCaseCategories => new KeyValuePair<string, string>("UseCaseCategories", UseCaseCategories)));
            }
            if (UseCaseSummary != null)
            {
                p.Add(new KeyValuePair<string, string>("UseCaseSummary", UseCaseSummary));
            }
            if (ProductionMessageSample != null)
            {
                p.Add(new KeyValuePair<string, string>("ProductionMessageSample", ProductionMessageSample));
            }
            if (OptInImageUrls != null)
            {
                p.AddRange(OptInImageUrls.Select(OptInImageUrls => new KeyValuePair<string, string>("OptInImageUrls", OptInImageUrls)));
            }
            if (OptInType != null)
            {
                p.Add(new KeyValuePair<string, string>("OptInType", OptInType.ToString()));
            }
            if (MessageVolume != null)
            {
                p.Add(new KeyValuePair<string, string>("MessageVolume", MessageVolume));
            }
            if (TollfreePhoneNumberSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TollfreePhoneNumberSid", TollfreePhoneNumberSid));
            }
            if (CustomerProfileSid != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomerProfileSid", CustomerProfileSid));
            }
            if (BusinessStreetAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessStreetAddress", BusinessStreetAddress));
            }
            if (BusinessStreetAddress2 != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessStreetAddress2", BusinessStreetAddress2));
            }
            if (BusinessCity != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessCity", BusinessCity));
            }
            if (BusinessStateProvinceRegion != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessStateProvinceRegion", BusinessStateProvinceRegion));
            }
            if (BusinessPostalCode != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessPostalCode", BusinessPostalCode));
            }
            if (BusinessCountry != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessCountry", BusinessCountry));
            }
            if (AdditionalInformation != null)
            {
                p.Add(new KeyValuePair<string, string>("AdditionalInformation", AdditionalInformation));
            }
            if (BusinessContactFirstName != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessContactFirstName", BusinessContactFirstName));
            }
            if (BusinessContactLastName != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessContactLastName", BusinessContactLastName));
            }
            if (BusinessContactEmail != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessContactEmail", BusinessContactEmail));
            }
            if (BusinessContactPhone != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessContactPhone", BusinessContactPhone.ToString()));
            }
            if (ExternalReferenceId != null)
            {
                p.Add(new KeyValuePair<string, string>("ExternalReferenceId", ExternalReferenceId));
            }
            return p;
        }

        

    }
    /// <summary> delete </summary>
    public class DeleteTollfreeVerificationOptions : IOptions<TollfreeVerificationResource>
    {
        
        ///<summary> The unique string to identify Tollfree Verification. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteTollfreeVerificationOptions </summary>
        /// <param name="pathSid"> The unique string to identify Tollfree Verification. </param>
        public DeleteTollfreeVerificationOptions(string pathSid)
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


    /// <summary> fetch </summary>
    public class FetchTollfreeVerificationOptions : IOptions<TollfreeVerificationResource>
    {
    
        ///<summary> The unique string to identify Tollfree Verification. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchTollfreeVerificationOptions </summary>
        /// <param name="pathSid"> The unique string to identify Tollfree Verification. </param>
        public FetchTollfreeVerificationOptions(string pathSid)
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


    /// <summary> read </summary>
    public class ReadTollfreeVerificationOptions : ReadOptions<TollfreeVerificationResource>
    {
    
        ///<summary> The SID of the Phone Number associated with the Tollfree Verification. </summary> 
        public string TollfreePhoneNumberSid { get; set; }

        ///<summary> The compliance status of the Tollfree Verification record. </summary> 
        public TollfreeVerificationResource.StatusEnum Status { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (TollfreePhoneNumberSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TollfreePhoneNumberSid", TollfreePhoneNumberSid));
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

    /// <summary> update </summary>
    public class UpdateTollfreeVerificationOptions : IOptions<TollfreeVerificationResource>
    {
    
        ///<summary> The unique string to identify Tollfree Verification. </summary> 
        public string PathSid { get; }

        ///<summary> The name of the business or organization using the Tollfree number. </summary> 
        public string BusinessName { get; set; }

        ///<summary> The website of the business or organization using the Tollfree number. </summary> 
        public string BusinessWebsite { get; set; }

        ///<summary> The email address to receive the notification about the verification result. . </summary> 
        public string NotificationEmail { get; set; }

        ///<summary> The category of the use case for the Tollfree Number. List as many are applicable.. </summary> 
        public List<string> UseCaseCategories { get; set; }

        ///<summary> Use this to further explain how messaging is used by the business or organization. </summary> 
        public string UseCaseSummary { get; set; }

        ///<summary> An example of message content, i.e. a sample message. </summary> 
        public string ProductionMessageSample { get; set; }

        ///<summary> Link to an image that shows the opt-in workflow. Multiple images allowed and must be a publicly hosted URL. </summary> 
        public List<string> OptInImageUrls { get; set; }

        
        public TollfreeVerificationResource.OptInTypeEnum OptInType { get; set; }

        ///<summary> Estimate monthly volume of messages from the Tollfree Number. </summary> 
        public string MessageVolume { get; set; }

        ///<summary> The address of the business or organization using the Tollfree number. </summary> 
        public string BusinessStreetAddress { get; set; }

        ///<summary> The address of the business or organization using the Tollfree number. </summary> 
        public string BusinessStreetAddress2 { get; set; }

        ///<summary> The city of the business or organization using the Tollfree number. </summary> 
        public string BusinessCity { get; set; }

        ///<summary> The state/province/region of the business or organization using the Tollfree number. </summary> 
        public string BusinessStateProvinceRegion { get; set; }

        ///<summary> The postal code of the business or organization using the Tollfree number. </summary> 
        public string BusinessPostalCode { get; set; }

        ///<summary> The country of the business or organization using the Tollfree number. </summary> 
        public string BusinessCountry { get; set; }

        ///<summary> Additional information to be provided for verification. </summary> 
        public string AdditionalInformation { get; set; }

        ///<summary> The first name of the contact for the business or organization using the Tollfree number. </summary> 
        public string BusinessContactFirstName { get; set; }

        ///<summary> The last name of the contact for the business or organization using the Tollfree number. </summary> 
        public string BusinessContactLastName { get; set; }

        ///<summary> The email address of the contact for the business or organization using the Tollfree number. </summary> 
        public string BusinessContactEmail { get; set; }

        ///<summary> The E.164 formatted phone number of the contact for the business or organization using the Tollfree number. </summary> 
        public Types.PhoneNumber BusinessContactPhone { get; set; }

        ///<summary> Describe why the verification is being edited. If the verification was rejected because of a technical issue, such as the website being down, and the issue has been resolved this parameter should be set to something similar to 'Website fixed'. </summary> 
        public string EditReason { get; set; }



        /// <summary> Construct a new UpdateTollfreeVerificationOptions </summary>
        /// <param name="pathSid"> The unique string to identify Tollfree Verification. </param>
        public UpdateTollfreeVerificationOptions(string pathSid)
        {
            PathSid = pathSid;
            UseCaseCategories = new List<string>();
            OptInImageUrls = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (BusinessName != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessName", BusinessName));
            }
            if (BusinessWebsite != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessWebsite", BusinessWebsite));
            }
            if (NotificationEmail != null)
            {
                p.Add(new KeyValuePair<string, string>("NotificationEmail", NotificationEmail));
            }
            if (UseCaseCategories != null)
            {
                p.AddRange(UseCaseCategories.Select(UseCaseCategories => new KeyValuePair<string, string>("UseCaseCategories", UseCaseCategories)));
            }
            if (UseCaseSummary != null)
            {
                p.Add(new KeyValuePair<string, string>("UseCaseSummary", UseCaseSummary));
            }
            if (ProductionMessageSample != null)
            {
                p.Add(new KeyValuePair<string, string>("ProductionMessageSample", ProductionMessageSample));
            }
            if (OptInImageUrls != null)
            {
                p.AddRange(OptInImageUrls.Select(OptInImageUrls => new KeyValuePair<string, string>("OptInImageUrls", OptInImageUrls)));
            }
            if (OptInType != null)
            {
                p.Add(new KeyValuePair<string, string>("OptInType", OptInType.ToString()));
            }
            if (MessageVolume != null)
            {
                p.Add(new KeyValuePair<string, string>("MessageVolume", MessageVolume));
            }
            if (BusinessStreetAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessStreetAddress", BusinessStreetAddress));
            }
            if (BusinessStreetAddress2 != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessStreetAddress2", BusinessStreetAddress2));
            }
            if (BusinessCity != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessCity", BusinessCity));
            }
            if (BusinessStateProvinceRegion != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessStateProvinceRegion", BusinessStateProvinceRegion));
            }
            if (BusinessPostalCode != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessPostalCode", BusinessPostalCode));
            }
            if (BusinessCountry != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessCountry", BusinessCountry));
            }
            if (AdditionalInformation != null)
            {
                p.Add(new KeyValuePair<string, string>("AdditionalInformation", AdditionalInformation));
            }
            if (BusinessContactFirstName != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessContactFirstName", BusinessContactFirstName));
            }
            if (BusinessContactLastName != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessContactLastName", BusinessContactLastName));
            }
            if (BusinessContactEmail != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessContactEmail", BusinessContactEmail));
            }
            if (BusinessContactPhone != null)
            {
                p.Add(new KeyValuePair<string, string>("BusinessContactPhone", BusinessContactPhone.ToString()));
            }
            if (EditReason != null)
            {
                p.Add(new KeyValuePair<string, string>("EditReason", EditReason));
            }
            return p;
        }

        

    }


}

