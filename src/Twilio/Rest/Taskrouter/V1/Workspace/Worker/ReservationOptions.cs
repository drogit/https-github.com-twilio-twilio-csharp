using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker 
{

    public class ReadReservationOptions : ReadOptions<ReservationResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string WorkspaceSid { get; }
        /// <summary>
        /// The worker_sid
        /// </summary>
        public string WorkerSid { get; }
        /// <summary>
        /// The reservation_status
        /// </summary>
        public ReservationResource.StatusEnum ReservationStatus { get; set; }
    
        /// <summary>
        /// Construct a new ReadReservationOptions
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        public ReadReservationOptions(string workspaceSid, string workerSid)
        {
            WorkspaceSid = workspaceSid;
            WorkerSid = workerSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (ReservationStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationStatus", ReservationStatus.ToString()));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    public class FetchReservationOptions : IOptions<ReservationResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string WorkspaceSid { get; }
        /// <summary>
        /// The worker_sid
        /// </summary>
        public string WorkerSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchReservationOptions
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <param name="sid"> The sid </param>
        public FetchReservationOptions(string workspaceSid, string workerSid, string sid)
        {
            WorkspaceSid = workspaceSid;
            WorkerSid = workerSid;
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

    public class UpdateReservationOptions : IOptions<ReservationResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string WorkspaceSid { get; }
        /// <summary>
        /// The worker_sid
        /// </summary>
        public string WorkerSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
        /// <summary>
        /// The reservation_status
        /// </summary>
        public ReservationResource.StatusEnum ReservationStatus { get; set; }
        /// <summary>
        /// The worker_activity_sid
        /// </summary>
        public string WorkerActivitySid { get; set; }
        /// <summary>
        /// The instruction
        /// </summary>
        public string Instruction { get; set; }
        /// <summary>
        /// The dequeue_post_work_activity_sid
        /// </summary>
        public string DequeuePostWorkActivitySid { get; set; }
        /// <summary>
        /// The dequeue_from
        /// </summary>
        public string DequeueFrom { get; set; }
        /// <summary>
        /// The dequeue_record
        /// </summary>
        public string DequeueRecord { get; set; }
        /// <summary>
        /// The dequeue_timeout
        /// </summary>
        public int? DequeueTimeout { get; set; }
        /// <summary>
        /// The dequeue_to
        /// </summary>
        public string DequeueTo { get; set; }
        /// <summary>
        /// The dequeue_status_callback_url
        /// </summary>
        public Uri DequeueStatusCallbackUrl { get; set; }
        /// <summary>
        /// The call_from
        /// </summary>
        public string CallFrom { get; set; }
        /// <summary>
        /// The call_record
        /// </summary>
        public string CallRecord { get; set; }
        /// <summary>
        /// The call_timeout
        /// </summary>
        public int? CallTimeout { get; set; }
        /// <summary>
        /// The call_to
        /// </summary>
        public string CallTo { get; set; }
        /// <summary>
        /// The call_url
        /// </summary>
        public Uri CallUrl { get; set; }
        /// <summary>
        /// The call_status_callback_url
        /// </summary>
        public Uri CallStatusCallbackUrl { get; set; }
        /// <summary>
        /// The call_accept
        /// </summary>
        public bool? CallAccept { get; set; }
        /// <summary>
        /// The redirect_call_sid
        /// </summary>
        public string RedirectCallSid { get; set; }
        /// <summary>
        /// The redirect_accept
        /// </summary>
        public bool? RedirectAccept { get; set; }
        /// <summary>
        /// The redirect_url
        /// </summary>
        public Uri RedirectUrl { get; set; }
    
        /// <summary>
        /// Construct a new UpdateReservationOptions
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workerSid"> The worker_sid </param>
        /// <param name="sid"> The sid </param>
        public UpdateReservationOptions(string workspaceSid, string workerSid, string sid)
        {
            WorkspaceSid = workspaceSid;
            WorkerSid = workerSid;
            Sid = sid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (ReservationStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationStatus", ReservationStatus.ToString()));
            }
            
            if (WorkerActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkerActivitySid", WorkerActivitySid.ToString()));
            }
            
            if (Instruction != null)
            {
                p.Add(new KeyValuePair<string, string>("Instruction", Instruction));
            }
            
            if (DequeuePostWorkActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeuePostWorkActivitySid", DequeuePostWorkActivitySid.ToString()));
            }
            
            if (DequeueFrom != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueFrom", DequeueFrom));
            }
            
            if (DequeueRecord != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueRecord", DequeueRecord));
            }
            
            if (DequeueTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueTimeout", DequeueTimeout.Value.ToString()));
            }
            
            if (DequeueTo != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueTo", DequeueTo));
            }
            
            if (DequeueStatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueStatusCallbackUrl", DequeueStatusCallbackUrl.ToString()));
            }
            
            if (CallFrom != null)
            {
                p.Add(new KeyValuePair<string, string>("CallFrom", CallFrom));
            }
            
            if (CallRecord != null)
            {
                p.Add(new KeyValuePair<string, string>("CallRecord", CallRecord));
            }
            
            if (CallTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("CallTimeout", CallTimeout.Value.ToString()));
            }
            
            if (CallTo != null)
            {
                p.Add(new KeyValuePair<string, string>("CallTo", CallTo));
            }
            
            if (CallUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallUrl", CallUrl.ToString()));
            }
            
            if (CallStatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallStatusCallbackUrl", CallStatusCallbackUrl.ToString()));
            }
            
            if (CallAccept != null)
            {
                p.Add(new KeyValuePair<string, string>("CallAccept", CallAccept.Value.ToString()));
            }
            
            if (RedirectCallSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RedirectCallSid", RedirectCallSid.ToString()));
            }
            
            if (RedirectAccept != null)
            {
                p.Add(new KeyValuePair<string, string>("RedirectAccept", RedirectAccept.Value.ToString()));
            }
            
            if (RedirectUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("RedirectUrl", RedirectUrl.ToString()));
            }
            
            return p;
        }
    }

}