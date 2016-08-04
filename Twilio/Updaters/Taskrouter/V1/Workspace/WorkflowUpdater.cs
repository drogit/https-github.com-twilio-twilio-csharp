using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Taskrouter.V1.Workspace;
using Twilio.Updaters;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Updaters.Taskrouter.V1.Workspace {

    public class WorkflowUpdater : Updater<WorkflowResource> {
        private string workspaceSid;
        private string sid;
        private string friendlyName;
        private string assignmentCallbackUrl;
        private string fallbackAssignmentCallbackUrl;
        private string configuration;
        private int? taskReservationTimeout;
    
        /**
         * Construct a new WorkflowUpdater
         * 
         * @param workspaceSid The workspace_sid
         * @param sid The sid
         */
        public WorkflowUpdater(string workspaceSid, string sid) {
            this.workspaceSid = workspaceSid;
            this.sid = sid;
        }
    
        /**
         * The friendly_name
         * 
         * @param friendlyName The friendly_name
         * @return this
         */
        public WorkflowUpdater setFriendlyName(string friendlyName) {
            this.friendlyName = friendlyName;
            return this;
        }
    
        /**
         * The assignment_callback_url
         * 
         * @param assignmentCallbackUrl The assignment_callback_url
         * @return this
         */
        public WorkflowUpdater setAssignmentCallbackUrl(string assignmentCallbackUrl) {
            this.assignmentCallbackUrl = assignmentCallbackUrl;
            return this;
        }
    
        /**
         * The fallback_assignment_callback_url
         * 
         * @param fallbackAssignmentCallbackUrl The fallback_assignment_callback_url
         * @return this
         */
        public WorkflowUpdater setFallbackAssignmentCallbackUrl(string fallbackAssignmentCallbackUrl) {
            this.fallbackAssignmentCallbackUrl = fallbackAssignmentCallbackUrl;
            return this;
        }
    
        /**
         * The configuration
         * 
         * @param configuration The configuration
         * @return this
         */
        public WorkflowUpdater setConfiguration(string configuration) {
            this.configuration = configuration;
            return this;
        }
    
        /**
         * The task_reservation_timeout
         * 
         * @param taskReservationTimeout The task_reservation_timeout
         * @return this
         */
        public WorkflowUpdater setTaskReservationTimeout(int? taskReservationTimeout) {
            this.taskReservationTimeout = taskReservationTimeout;
            return this;
        }
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the update
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Updated WorkflowResource
         */
        public override async Task<WorkflowResource> ExecuteAsync(ITwilioRestClient client) {
            Request request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.TASKROUTER,
                "/v1/Workspaces/" + this.workspaceSid + "/Workflows/" + this.sid + ""
            );
            
            addPostParams(request);
            Response response = await client.RequestAsync(request);
            
            if (response == null) {
                throw new ApiConnectionException("WorkflowResource update failed: Unable to connect to server");
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
            
            return WorkflowResource.FromJson(response.GetContent());
        }
        #endif
    
        /**
         * Make the request to the Twilio API to perform the update
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Updated WorkflowResource
         */
        public override WorkflowResource Execute(ITwilioRestClient client) {
            Request request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.TASKROUTER,
                "/v1/Workspaces/" + this.workspaceSid + "/Workflows/" + this.sid + ""
            );
            
            addPostParams(request);
            Response response = client.Request(request);
            
            if (response == null) {
                throw new ApiConnectionException("WorkflowResource update failed: Unable to connect to server");
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
            
            return WorkflowResource.FromJson(response.GetContent());
        }
    
        /**
         * Add the requested post parameters to the Request
         * 
         * @param request Request to add post params to
         */
        private void addPostParams(Request request) {
            if (friendlyName != null) {
                request.AddPostParam("FriendlyName", friendlyName);
            }
            
            if (assignmentCallbackUrl != null) {
                request.AddPostParam("AssignmentCallbackUrl", assignmentCallbackUrl);
            }
            
            if (fallbackAssignmentCallbackUrl != null) {
                request.AddPostParam("FallbackAssignmentCallbackUrl", fallbackAssignmentCallbackUrl);
            }
            
            if (configuration != null) {
                request.AddPostParam("Configuration", configuration);
            }
            
            if (taskReservationTimeout != null) {
                request.AddPostParam("TaskReservationTimeout", taskReservationTimeout.ToString());
            }
        }
    }
}