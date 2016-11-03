using System;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Rest.Api.V2010.Account 
{

    public class ConferenceReader : Reader<ConferenceResource> 
    {
        public string accountSid { get; set; }
        public DateTime? dateCreated { get; set; }
        public DateTime? dateCreatedAfter { get; set; }
        public DateTime? dateCreatedBefore { get; set; }
        public DateTime? dateUpdated { get; set; }
        public DateTime? dateUpdatedAfter { get; set; }
        public DateTime? dateUpdatedBefore { get; set; }
        public string friendlyName { get; set; }
        public ConferenceResource.Status status { get; set; }
    
        #if NET40
        /// <summary>
        /// Make the request to the Twilio API to perform the read
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> ConferenceResource ResourceSet </returns> 
        public override Task<ResourceSet<ConferenceResource>> ReadAsync(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.GET,
                Domains.API,
                "/2010-04-01/Accounts/" + (accountSid ?? client.GetAccountSid()) + "/Conferences.json"
            );
            AddQueryParams(request);
            
            var page = PageForRequest(client, request);
            
            return System.Threading.Tasks.Task.FromResult(new ResourceSet<ConferenceResource>(this, client, page));
        }
        #endif
    
        /// <summary>
        /// Make the request to the Twilio API to perform the read
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> ConferenceResource ResourceSet </returns> 
        public override ResourceSet<ConferenceResource> Read(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.GET,
                Domains.API,
                "/2010-04-01/Accounts/" + (accountSid ?? client.GetAccountSid()) + "/Conferences.json"
            );
            
            AddQueryParams(request);
            var page = PageForRequest(client, request);
            
            return new ResourceSet<ConferenceResource>(this, client, page);
        }
    
        /// <summary>
        /// Retrieve the next page from the Twilio API
        /// </summary>
        ///
        /// <param name="page"> current page of results </param>
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Next Page </returns> 
        public override Page<ConferenceResource> NextPage(Page<ConferenceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.GET,
                page.GetNextPageUrl(
                    Domains.API
                )
            );
            
            return PageForRequest(client, request);
        }
    
        /// <summary>
        /// Generate a Page of ConferenceResource Resources for a given request
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <param name="request"> Request to generate a page for </param>
        /// <returns> Page for the Request </returns> 
        protected Page<ConferenceResource> PageForRequest(ITwilioRestClient client, Request request)
        {
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("ConferenceResource read failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to read records, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return Page<ConferenceResource>.FromJson("conferences", response.Content);
        }
    
        /// <summary>
        /// Add the requested query string arguments to the Request
        /// </summary>
        ///
        /// <param name="request"> Request to add query string arguments to </param>
        private void AddQueryParams(Request request)
        {
            if (dateCreated != null)
            {
                request.AddQueryParam("DateCreated", dateCreated.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                if (dateCreatedBefore != null)
                {
                    request.AddQueryParam("DateCreated<", dateCreatedBefore.Value.ToString("yyyy-MM-dd"));
                }
                if (dateCreatedAfter != null)
                {
                    request.AddQueryParam("DateCreated>", dateCreatedAfter.Value.ToString("yyyy-MM-dd"));
                }
            }
            
            if (dateUpdated != null)
            {
                request.AddQueryParam("DateUpdated", dateUpdated.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                if (dateUpdatedBefore != null)
                {
                    request.AddQueryParam("DateUpdated<", dateUpdatedBefore.Value.ToString("yyyy-MM-dd"));
                }
                if (dateUpdatedAfter != null)
                {
                    request.AddQueryParam("DateUpdated>", dateUpdatedAfter.Value.ToString("yyyy-MM-dd"));
                }
            }
            
            if (friendlyName != null)
            {
                request.AddQueryParam("FriendlyName", friendlyName);
            }
            
            if (status != null)
            {
                request.AddQueryParam("Status", status.ToString());
            }
            
            if (PageSize != null)
            {
                request.AddQueryParam("PageSize", PageSize.ToString());
            }
        }
    }
}