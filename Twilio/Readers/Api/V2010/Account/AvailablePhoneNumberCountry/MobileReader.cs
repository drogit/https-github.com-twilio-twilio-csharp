using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Readers;
using Twilio.Resources;
using Twilio.Resources.Api.V2010.Account.AvailablePhoneNumberCountry;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Readers.Api.V2010.Account.AvailablePhoneNumberCountry {

    public class MobileReader : Reader<MobileResource> {
        private string accountSid;
        private string countryCode;
        private int? areaCode;
        private string contains;
        private bool? smsEnabled;
        private bool? mmsEnabled;
        private bool? voiceEnabled;
        private bool? excludeAllAddressRequired;
        private bool? excludeLocalAddressRequired;
        private bool? excludeForeignAddressRequired;
        private bool? beta;
    
        /**
         * Construct a new MobileReader.
         * 
         * @param countryCode The country_code
         */
        public MobileReader(string countryCode) {
            this.countryCode = countryCode;
        }
    
        /**
         * Construct a new MobileReader
         * 
         * @param accountSid The account_sid
         * @param countryCode The country_code
         */
        public MobileReader(string accountSid, string countryCode) {
            this.accountSid = accountSid;
            this.countryCode = countryCode;
        }
    
        /**
         * The area_code
         * 
         * @param areaCode The area_code
         * @return this
         */
        public MobileReader ByAreaCode(int? areaCode) {
            this.areaCode = areaCode;
            return this;
        }
    
        /**
         * The contains
         * 
         * @param contains The contains
         * @return this
         */
        public MobileReader ByContains(string contains) {
            this.contains = contains;
            return this;
        }
    
        /**
         * The sms_enabled
         * 
         * @param smsEnabled The sms_enabled
         * @return this
         */
        public MobileReader BySmsEnabled(bool? smsEnabled) {
            this.smsEnabled = smsEnabled;
            return this;
        }
    
        /**
         * The mms_enabled
         * 
         * @param mmsEnabled The mms_enabled
         * @return this
         */
        public MobileReader ByMmsEnabled(bool? mmsEnabled) {
            this.mmsEnabled = mmsEnabled;
            return this;
        }
    
        /**
         * The voice_enabled
         * 
         * @param voiceEnabled The voice_enabled
         * @return this
         */
        public MobileReader ByVoiceEnabled(bool? voiceEnabled) {
            this.voiceEnabled = voiceEnabled;
            return this;
        }
    
        /**
         * The exclude_all_address_required
         * 
         * @param excludeAllAddressRequired The exclude_all_address_required
         * @return this
         */
        public MobileReader ByExcludeAllAddressRequired(bool? excludeAllAddressRequired) {
            this.excludeAllAddressRequired = excludeAllAddressRequired;
            return this;
        }
    
        /**
         * The exclude_local_address_required
         * 
         * @param excludeLocalAddressRequired The exclude_local_address_required
         * @return this
         */
        public MobileReader ByExcludeLocalAddressRequired(bool? excludeLocalAddressRequired) {
            this.excludeLocalAddressRequired = excludeLocalAddressRequired;
            return this;
        }
    
        /**
         * The exclude_foreign_address_required
         * 
         * @param excludeForeignAddressRequired The exclude_foreign_address_required
         * @return this
         */
        public MobileReader ByExcludeForeignAddressRequired(bool? excludeForeignAddressRequired) {
            this.excludeForeignAddressRequired = excludeForeignAddressRequired;
            return this;
        }
    
        /**
         * The beta
         * 
         * @param beta The beta
         * @return this
         */
        public MobileReader ByBeta(bool? beta) {
            this.beta = beta;
            return this;
        }
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the read
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return MobileResource ResourceSet
         */
        public override Task<ResourceSet<MobileResource>> ExecuteAsync(ITwilioRestClient client) {
            Request request = new Request(
                Twilio.Http.HttpMethod.GET,
                Domains.API,
                "/2010-04-01/Accounts/" + (this.accountSid != null ? this.accountSid : client.GetAccountSid()) + "/AvailablePhoneNumbers/" + this.countryCode + "/Mobile.json"
            );
            
            AddQueryParams(request);
            
            Page<MobileResource> page = PageForRequest(client, request);
            
            return System.Threading.Tasks.Task.FromResult(
                    new ResourceSet<MobileResource>(this, client, page));
        }
        #endif
    
        /**
         * Make the request to the Twilio API to perform the read
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return MobileResource ResourceSet
         */
        public override ResourceSet<MobileResource> Execute(ITwilioRestClient client) {
            Request request = new Request(
                Twilio.Http.HttpMethod.GET,
                Domains.API,
                "/2010-04-01/Accounts/" + (this.accountSid != null ? this.accountSid : client.GetAccountSid()) + "/AvailablePhoneNumbers/" + this.countryCode + "/Mobile.json"
            );
            
            AddQueryParams(request);
            
            Page<MobileResource> page = PageForRequest(client, request);
            
            return new ResourceSet<MobileResource>(this, client, page);
        }
    
        /**
         * Retrieve the next page from the Twilio API
         * 
         * @param nextPageUri URI from which to retrieve the next page
         * @param client ITwilioRestClient with which to make the request
         * @return Next Page
         */
        public override Page<MobileResource> NextPage(string nextPageUri, ITwilioRestClient client) {
            Request request = new Request(
                Twilio.Http.HttpMethod.GET,
                nextPageUri
            );
            
            var result = PageForRequest(client, request);
            
            return result;
        }
    
        /**
         * Generate a Page of MobileResource Resources for a given request
         * 
         * @param client ITwilioRestClient with which to make the request
         * @param request Request to generate a page for
         * @return Page for the Request
         */
        protected Page<MobileResource> PageForRequest(ITwilioRestClient client, Request request) {
            Response response = client.Request(request);
            
            if (response == null) {
                throw new ApiConnectionException("MobileResource read failed: Unable to connect to server");
            } else if (response.GetStatusCode() < System.Net.HttpStatusCode.OK || response.GetStatusCode() > System.Net.HttpStatusCode.NoContent) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            Page<MobileResource> result = new Page<MobileResource>();
            result.deserialize("available_phone_numbers", response.GetContent());
            
            return result;
        }
    
        /**
         * Add the requested query string arguments to the Request
         * 
         * @param request Request to add query string arguments to
         */
        private void AddQueryParams(Request request) {
            if (areaCode != null) {
                request.AddQueryParam("AreaCode", areaCode.ToString());
            }
            
            if (contains != null) {
                request.AddQueryParam("Contains", contains);
            }
            
            if (smsEnabled != null) {
                request.AddQueryParam("SmsEnabled", smsEnabled.ToString());
            }
            
            if (mmsEnabled != null) {
                request.AddQueryParam("MmsEnabled", mmsEnabled.ToString());
            }
            
            if (voiceEnabled != null) {
                request.AddQueryParam("VoiceEnabled", voiceEnabled.ToString());
            }
            
            if (excludeAllAddressRequired != null) {
                request.AddQueryParam("ExcludeAllAddressRequired", excludeAllAddressRequired.ToString());
            }
            
            if (excludeLocalAddressRequired != null) {
                request.AddQueryParam("ExcludeLocalAddressRequired", excludeLocalAddressRequired.ToString());
            }
            
            if (excludeForeignAddressRequired != null) {
                request.AddQueryParam("ExcludeForeignAddressRequired", excludeForeignAddressRequired.ToString());
            }
            
            if (beta != null) {
                request.AddQueryParam("Beta", beta.ToString());
            }
            
            request.AddQueryParam("PageSize", GetPageSize().ToString());
        }
    }
}