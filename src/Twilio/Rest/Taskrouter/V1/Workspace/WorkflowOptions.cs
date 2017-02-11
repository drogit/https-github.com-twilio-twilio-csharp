using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    public class FetchWorkflowOptions : IOptions<WorkflowResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string WorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchWorkflowOptions
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        public FetchWorkflowOptions(string workspaceSid, string sid)
        {
            WorkspaceSid = workspaceSid;
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    public class UpdateWorkflowOptions : IOptions<WorkflowResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string WorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The assignment_callback_url
        /// </summary>
        public Uri AssignmentCallbackUrl { get; set; }
        /// <summary>
        /// The fallback_assignment_callback_url
        /// </summary>
        public Uri FallbackAssignmentCallbackUrl { get; set; }
        /// <summary>
        /// The configuration
        /// </summary>
        public string Configuration { get; set; }
        /// <summary>
        /// The task_reservation_timeout
        /// </summary>
        public int? TaskReservationTimeout { get; set; }
    
        /// <summary>
        /// Construct a new UpdateWorkflowOptions
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        public UpdateWorkflowOptions(string workspaceSid, string sid)
        {
            WorkspaceSid = workspaceSid;
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (AssignmentCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentCallbackUrl", AssignmentCallbackUrl.ToString()));
            }
            
            if (FallbackAssignmentCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackAssignmentCallbackUrl", FallbackAssignmentCallbackUrl.ToString()));
            }
            
            if (Configuration != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration", Configuration));
            }
            
            if (TaskReservationTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskReservationTimeout", TaskReservationTimeout.Value.ToString()));
            }
            
            return p;
        }
    }

    public class DeleteWorkflowOptions : IOptions<WorkflowResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string WorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new DeleteWorkflowOptions
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        public DeleteWorkflowOptions(string workspaceSid, string sid)
        {
            WorkspaceSid = workspaceSid;
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    public class ReadWorkflowOptions : ReadOptions<WorkflowResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string WorkspaceSid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
    
        /// <summary>
        /// Construct a new ReadWorkflowOptions
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        public ReadWorkflowOptions(string workspaceSid)
        {
            WorkspaceSid = workspaceSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    public class CreateWorkflowOptions : IOptions<WorkflowResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string WorkspaceSid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The configuration
        /// </summary>
        public string Configuration { get; }
        /// <summary>
        /// The assignment_callback_url
        /// </summary>
        public Uri AssignmentCallbackUrl { get; set; }
        /// <summary>
        /// The fallback_assignment_callback_url
        /// </summary>
        public Uri FallbackAssignmentCallbackUrl { get; set; }
        /// <summary>
        /// The task_reservation_timeout
        /// </summary>
        public int? TaskReservationTimeout { get; set; }
    
        /// <summary>
        /// Construct a new CreateWorkflowOptions
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="configuration"> The configuration </param>
        public CreateWorkflowOptions(string workspaceSid, string friendlyName, string configuration)
        {
            WorkspaceSid = workspaceSid;
            FriendlyName = friendlyName;
            Configuration = configuration;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (Configuration != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration", Configuration));
            }
            
            if (AssignmentCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentCallbackUrl", AssignmentCallbackUrl.ToString()));
            }
            
            if (FallbackAssignmentCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackAssignmentCallbackUrl", FallbackAssignmentCallbackUrl.ToString()));
            }
            
            if (TaskReservationTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskReservationTimeout", TaskReservationTimeout.Value.ToString()));
            }
            
            return p;
        }
    }

}