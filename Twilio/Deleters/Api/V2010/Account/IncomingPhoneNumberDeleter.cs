using Twilio.Clients;
using Twilio.Deleters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Api.V2010.Account;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Deleters.Api.V2010.Account {

    public class IncomingPhoneNumberDeleter : Deleter<IncomingPhoneNumberResource> {
        private string ownerAccountSid;
        private string sid;
    
        /**
         * Construct a new IncomingPhoneNumberDeleter.
         * 
         * @param sid Delete by unique phone-number Sid
         */
        public IncomingPhoneNumberDeleter(string sid) {
            this.sid = sid;
        }
    
        /**
         * Construct a new IncomingPhoneNumberDeleter
         * 
         * @param ownerAccountSid The owner_account_sid
         * @param sid Delete by unique phone-number Sid
         */
        public IncomingPhoneNumberDeleter(string ownerAccountSid, string sid) {
            this.ownerAccountSid = ownerAccountSid;
            this.sid = sid;
        }
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the delete
         * 
         * @param client ITwilioRestClient with which to make the request
         */
        public override async Task ExecuteAsync(ITwilioRestClient client) {
            Request request = new Request(
                Twilio.Http.HttpMethod.DELETE,
                Domains.API,
                "/2010-04-01/Accounts/" + (this.ownerAccountSid != null ? this.ownerAccountSid : client.GetAccountSid()) + "/IncomingPhoneNumbers/" + this.sid + ".json"
            );
            
            Response response = await client.RequestAsync(request);
            
            if (response == null) {
                throw new ApiConnectionException("IncomingPhoneNumberResource delete failed: Unable to connect to server");
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
            
            return;
        }
        #endif
    
        /**
         * Make the request to the Twilio API to perform the delete
         * 
         * @param client ITwilioRestClient with which to make the request
         */
        public override void Execute(ITwilioRestClient client) {
            Request request = new Request(
                Twilio.Http.HttpMethod.DELETE,
                Domains.API,
                "/2010-04-01/Accounts/" + (this.ownerAccountSid != null ? this.ownerAccountSid : client.GetAccountSid()) + "/IncomingPhoneNumbers/" + this.sid + ".json"
            );
            
            Response response = client.Request(request);
            
            if (response == null) {
                throw new ApiConnectionException("IncomingPhoneNumberResource delete failed: Unable to connect to server");
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
            
            return;
        }
    }
}