/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// FaxResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Fax.V1
{

    public class FaxResource : Resource
    {
        public sealed class DirectionEnum : StringEnum
        {
            private DirectionEnum(string value) : base(value) {}
            public DirectionEnum() {}
            public static implicit operator DirectionEnum(string value)
            {
                return new DirectionEnum(value);
            }

            public static readonly DirectionEnum Inbound = new DirectionEnum("inbound");
            public static readonly DirectionEnum Outbound = new DirectionEnum("outbound");
        }

        public sealed class QualityEnum : StringEnum
        {
            private QualityEnum(string value) : base(value) {}
            public QualityEnum() {}
            public static implicit operator QualityEnum(string value)
            {
                return new QualityEnum(value);
            }

            public static readonly QualityEnum Standard = new QualityEnum("standard");
            public static readonly QualityEnum Fine = new QualityEnum("fine");
            public static readonly QualityEnum Superfine = new QualityEnum("superfine");
        }

        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Queued = new StatusEnum("queued");
            public static readonly StatusEnum Processing = new StatusEnum("processing");
            public static readonly StatusEnum Sending = new StatusEnum("sending");
            public static readonly StatusEnum Delivered = new StatusEnum("delivered");
            public static readonly StatusEnum Receiving = new StatusEnum("receiving");
            public static readonly StatusEnum Received = new StatusEnum("received");
            public static readonly StatusEnum NoAnswer = new StatusEnum("no-answer");
            public static readonly StatusEnum Busy = new StatusEnum("busy");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
            public static readonly StatusEnum Canceled = new StatusEnum("canceled");
        }

        public sealed class UpdateStatusEnum : StringEnum
        {
            private UpdateStatusEnum(string value) : base(value) {}
            public UpdateStatusEnum() {}
            public static implicit operator UpdateStatusEnum(string value)
            {
                return new UpdateStatusEnum(value);
            }

            public static readonly UpdateStatusEnum Canceled = new UpdateStatusEnum("canceled");
        }

        private static Request BuildFetchRequest(FetchFaxOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Fax,
                "/v1/Faxes/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Fetch a specific fax.
        /// </summary>
        /// <param name="options"> Fetch Fax parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fax </returns>
        public static FaxResource Fetch(FetchFaxOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific fax.
        /// </summary>
        /// <param name="options"> Fetch Fax parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fax </returns>
        public static async System.Threading.Tasks.Task<FaxResource> FetchAsync(FetchFaxOptions options,
                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific fax.
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fax </returns>
        public static FaxResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchFaxOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific fax.
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fax </returns>
        public static async System.Threading.Tasks.Task<FaxResource> FetchAsync(string pathSid,
                                                                                ITwilioRestClient client = null)
        {
            var options = new FetchFaxOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadFaxOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Fax,
                "/v1/Faxes",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Retrieve a list of all faxes.
        /// </summary>
        /// <param name="options"> Read Fax parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fax </returns>
        public static ResourceSet<FaxResource> Read(ReadFaxOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<FaxResource>.FromJson("faxes", response.Content);
            return new ResourceSet<FaxResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all faxes.
        /// </summary>
        /// <param name="options"> Read Fax parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fax </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FaxResource>> ReadAsync(ReadFaxOptions options,
                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FaxResource>.FromJson("faxes", response.Content);
            return new ResourceSet<FaxResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all faxes.
        /// </summary>
        /// <param name="from"> Retrieve only those faxes sent from this phone number </param>
        /// <param name="to"> Retrieve only those faxes sent to this phone number </param>
        /// <param name="dateCreatedOnOrBefore"> Retrieve only faxes created on or before this date </param>
        /// <param name="dateCreatedAfter"> Retrieve only faxes created after this date </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fax </returns>
        public static ResourceSet<FaxResource> Read(string from = null,
                                                    string to = null,
                                                    DateTime? dateCreatedOnOrBefore = null,
                                                    DateTime? dateCreatedAfter = null,
                                                    int? pageSize = null,
                                                    long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadFaxOptions(){From = from, To = to, DateCreatedOnOrBefore = dateCreatedOnOrBefore, DateCreatedAfter = dateCreatedAfter, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all faxes.
        /// </summary>
        /// <param name="from"> Retrieve only those faxes sent from this phone number </param>
        /// <param name="to"> Retrieve only those faxes sent to this phone number </param>
        /// <param name="dateCreatedOnOrBefore"> Retrieve only faxes created on or before this date </param>
        /// <param name="dateCreatedAfter"> Retrieve only faxes created after this date </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fax </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FaxResource>> ReadAsync(string from = null,
                                                                                            string to = null,
                                                                                            DateTime? dateCreatedOnOrBefore = null,
                                                                                            DateTime? dateCreatedAfter = null,
                                                                                            int? pageSize = null,
                                                                                            long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadFaxOptions(){From = from, To = to, DateCreatedOnOrBefore = dateCreatedOnOrBefore, DateCreatedAfter = dateCreatedAfter, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<FaxResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FaxResource>.FromJson("faxes", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<FaxResource> NextPage(Page<FaxResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Fax)
            );

            var response = client.Request(request);
            return Page<FaxResource>.FromJson("faxes", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<FaxResource> PreviousPage(Page<FaxResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Fax)
            );

            var response = client.Request(request);
            return Page<FaxResource>.FromJson("faxes", response.Content);
        }

        private static Request BuildDeleteRequest(DeleteFaxOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Fax,
                "/v1/Faxes/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Delete a specific fax and its associated media.
        /// </summary>
        /// <param name="options"> Delete Fax parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fax </returns>
        public static bool Delete(DeleteFaxOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a specific fax and its associated media.
        /// </summary>
        /// <param name="options"> Delete Fax parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fax </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteFaxOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a specific fax and its associated media.
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fax </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteFaxOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a specific fax and its associated media.
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fax </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteFaxOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a FaxResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FaxResource object represented by the provided JSON </returns>
        public static FaxResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FaxResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The number the fax was sent from
        /// </summary>
        [JsonProperty("from")]
        public string From { get; private set; }
        /// <summary>
        /// The phone number that received the fax
        /// </summary>
        [JsonProperty("to")]
        public string To { get; private set; }
        /// <summary>
        /// The quality of the fax
        /// </summary>
        [JsonProperty("quality")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FaxResource.QualityEnum Quality { get; private set; }
        /// <summary>
        /// The SID of the FaxMedia resource that is associated with the Fax
        /// </summary>
        [JsonProperty("media_sid")]
        public string MediaSid { get; private set; }
        /// <summary>
        /// The Twilio-hosted URL that can be used to download fax media
        /// </summary>
        [JsonProperty("media_url")]
        public string MediaUrl { get; private set; }
        /// <summary>
        /// The number of pages contained in the fax document
        /// </summary>
        [JsonProperty("num_pages")]
        public int? NumPages { get; private set; }
        /// <summary>
        /// The time it took to transmit the fax
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; private set; }
        /// <summary>
        /// The status of the fax
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FaxResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The direction of the fax
        /// </summary>
        [JsonProperty("direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FaxResource.DirectionEnum Direction { get; private set; }
        /// <summary>
        /// The API version used to transmit the fax
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The fax transmission price
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; private set; }
        /// <summary>
        /// The ISO 4217 currency used for billing
        /// </summary>
        [JsonProperty("price_unit")]
        public string PriceUnit { get; private set; }
        /// <summary>
        /// The ISO 8601 formatted date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 formatted date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URLs of the fax's related resources
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
        /// <summary>
        /// The absolute URL of the fax resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private FaxResource()
        {

        }
    }

}