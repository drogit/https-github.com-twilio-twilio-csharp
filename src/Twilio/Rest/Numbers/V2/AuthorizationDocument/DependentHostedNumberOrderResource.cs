/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Numbers
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;


namespace Twilio.Rest.Numbers.V2.AuthorizationDocument
{
    public class DependentHostedNumberOrderResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Received = new StatusEnum("received");
            public static readonly StatusEnum Verified = new StatusEnum("verified");
            public static readonly StatusEnum PendingLoa = new StatusEnum("pending-loa");
            public static readonly StatusEnum CarrierProcessing = new StatusEnum("carrier-processing");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
            public static readonly StatusEnum ActionRequired = new StatusEnum("action-required");

        }

        
        private static Request BuildReadRequest(ReadDependentHostedNumberOrderOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/HostedNumber/AuthorizationDocuments/{SigningDocumentSid}/DependentHostedNumberOrders";

            string PathSigningDocumentSid = options.PathSigningDocumentSid;
            path = path.Replace("{"+"SigningDocumentSid"+"}", PathSigningDocumentSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of dependent HostedNumberOrders belonging to the AuthorizationDocument. </summary>
        /// <param name="options"> Read DependentHostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DependentHostedNumberOrder </returns>
        public static ResourceSet<DependentHostedNumberOrderResource> Read(ReadDependentHostedNumberOrderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<DependentHostedNumberOrderResource>.FromJson("items", response.Content);
            return new ResourceSet<DependentHostedNumberOrderResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of dependent HostedNumberOrders belonging to the AuthorizationDocument. </summary>
        /// <param name="options"> Read DependentHostedNumberOrder parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DependentHostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DependentHostedNumberOrderResource>> ReadAsync(ReadDependentHostedNumberOrderOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<DependentHostedNumberOrderResource>.FromJson("items", response.Content);
            return new ResourceSet<DependentHostedNumberOrderResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of dependent HostedNumberOrders belonging to the AuthorizationDocument. </summary>
        /// <param name="pathSigningDocumentSid"> A 34 character string that uniquely identifies the LOA document associated with this HostedNumberOrder. </param>
        /// <param name="status"> Status of an instance resource. It can hold one of the values: 1. opened 2. signing, 3. signed LOA, 4. canceled, 5. failed. See the section entitled [Status Values](https://www.twilio.com/docs/api/phone-numbers/hosted-number-authorization-documents#status-values) for more information on each of these statuses. </param>
        /// <param name="phoneNumber"> An E164 formatted phone number hosted by this HostedNumberOrder. </param>
        /// <param name="incomingPhoneNumberSid"> A 34 character string that uniquely identifies the IncomingPhoneNumber resource created by this HostedNumberOrder. </param>
        /// <param name="friendlyName"> A human readable description of this resource, up to 128 characters. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DependentHostedNumberOrder </returns>
        public static ResourceSet<DependentHostedNumberOrderResource> Read(
                                                     string pathSigningDocumentSid,
                                                     DependentHostedNumberOrderResource.StatusEnum status = null,
                                                     Types.PhoneNumber phoneNumber = null,
                                                     string incomingPhoneNumberSid = null,
                                                     string friendlyName = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadDependentHostedNumberOrderOptions(pathSigningDocumentSid){ Status = status, PhoneNumber = phoneNumber, IncomingPhoneNumberSid = incomingPhoneNumberSid, FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of dependent HostedNumberOrders belonging to the AuthorizationDocument. </summary>
        /// <param name="pathSigningDocumentSid"> A 34 character string that uniquely identifies the LOA document associated with this HostedNumberOrder. </param>
        /// <param name="status"> Status of an instance resource. It can hold one of the values: 1. opened 2. signing, 3. signed LOA, 4. canceled, 5. failed. See the section entitled [Status Values](https://www.twilio.com/docs/api/phone-numbers/hosted-number-authorization-documents#status-values) for more information on each of these statuses. </param>
        /// <param name="phoneNumber"> An E164 formatted phone number hosted by this HostedNumberOrder. </param>
        /// <param name="incomingPhoneNumberSid"> A 34 character string that uniquely identifies the IncomingPhoneNumber resource created by this HostedNumberOrder. </param>
        /// <param name="friendlyName"> A human readable description of this resource, up to 128 characters. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DependentHostedNumberOrder </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DependentHostedNumberOrderResource>> ReadAsync(
                                                                                             string pathSigningDocumentSid,
                                                                                             DependentHostedNumberOrderResource.StatusEnum status = null,
                                                                                             Types.PhoneNumber phoneNumber = null,
                                                                                             string incomingPhoneNumberSid = null,
                                                                                             string friendlyName = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadDependentHostedNumberOrderOptions(pathSigningDocumentSid){ Status = status, PhoneNumber = phoneNumber, IncomingPhoneNumberSid = incomingPhoneNumberSid, FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<DependentHostedNumberOrderResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<DependentHostedNumberOrderResource>.FromJson("items", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<DependentHostedNumberOrderResource> NextPage(Page<DependentHostedNumberOrderResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<DependentHostedNumberOrderResource>.FromJson("items", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<DependentHostedNumberOrderResource> PreviousPage(Page<DependentHostedNumberOrderResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<DependentHostedNumberOrderResource>.FromJson("items", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a DependentHostedNumberOrderResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DependentHostedNumberOrderResource object represented by the provided JSON </returns>
        public static DependentHostedNumberOrderResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<DependentHostedNumberOrderResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> A 34 character string that uniquely identifies this Authorization Document </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies the bulk hosting request associated with this HostedNumberOrder. </summary> 
        [JsonProperty("bulk_hosting_request_sid")]
        public string BulkHostingRequestSid { get; private set; }

        ///<summary> The next step you need to take to complete the hosted number order and request it successfully. </summary> 
        [JsonProperty("next_step")]
        public string NextStep { get; private set; }

        ///<summary> The unique SID identifier of the Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies the IncomingPhoneNumber resource created by this HostedNumberOrder. </summary> 
        [JsonProperty("incoming_phone_number_sid")]
        public string IncomingPhoneNumberSid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies the Address resource that represents the address of the owner of this phone number. </summary> 
        [JsonProperty("address_sid")]
        public string AddressSid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies the LOA document associated with this HostedNumberOrder. </summary> 
        [JsonProperty("signing_document_sid")]
        public string SigningDocumentSid { get; private set; }

        ///<summary> An E164 formatted phone number hosted by this HostedNumberOrder. </summary> 
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }

        ///<summary> The capabilities </summary> 
        [JsonProperty("capabilities")]
        public PhoneNumberCapabilities Capabilities { get; private set; }

        ///<summary> A human readable description of this resource, up to 128 characters. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        
        [JsonProperty("status")]
        public DependentHostedNumberOrderResource.StatusEnum Status { get; private set; }

        ///<summary> A message that explains why a hosted_number_order went to status \"action-required\" </summary> 
        [JsonProperty("failure_reason")]
        public string FailureReason { get; private set; }

        ///<summary> The date this resource was created, given as [GMT RFC 2822](http://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this resource was updated, given as [GMT RFC 2822](http://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> Email of the owner of this phone number that is being hosted. </summary> 
        [JsonProperty("email")]
        public string Email { get; private set; }

        ///<summary> Email recipients who will be informed when an Authorization Document has been sent and signed </summary> 
        [JsonProperty("cc_emails")]
        public List<string> CcEmails { get; private set; }

        ///<summary> The title of the person authorized to sign the Authorization Document for this phone number. </summary> 
        [JsonProperty("contact_title")]
        public string ContactTitle { get; private set; }

        ///<summary> The contact phone number of the person authorized to sign the Authorization Document. </summary> 
        [JsonProperty("contact_phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber ContactPhoneNumber { get; private set; }



        private DependentHostedNumberOrderResource() {

        }
    }
}
