/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Taskrouter
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




namespace Twilio.Rest.Taskrouter.V1.Workspace
{
    /// <summary> fetch </summary>
    public class FetchEventOptions : IOptions<EventResource>
    {
    
        ///<summary> The SID of the Workspace with the Event to fetch. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Event resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchEventOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Event to fetch. </param>
        /// <param name="pathSid"> The SID of the Event resource to fetch. </param>
        public FetchEventOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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
    public class ReadEventOptions : ReadOptions<EventResource>
    {
    
        ///<summary> The SID of the Workspace with the Events to read. Returns only the Events that pertain to the specified Workspace. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> Only include Events that occurred on or before this date, specified in GMT as an [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date-time. </summary> 
        public DateTime? EndDate { get; set; }

        ///<summary> The type of Events to read. Returns only Events of the type specified. </summary> 
        public string EventType { get; set; }

        ///<summary> The period of events to read in minutes. Returns only Events that occurred since this many minutes in the past. The default is `15` minutes. Task Attributes for Events occuring more 43,200 minutes ago will be redacted. </summary> 
        public int? Minutes { get; set; }

        ///<summary> The SID of the Reservation with the Events to read. Returns only Events that pertain to the specified Reservation. </summary> 
        public string ReservationSid { get; set; }

        ///<summary> Only include Events from on or after this date and time, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. Task Attributes for Events older than 30 days will be redacted. </summary> 
        public DateTime? StartDate { get; set; }

        ///<summary> The SID of the TaskQueue with the Events to read. Returns only the Events that pertain to the specified TaskQueue. </summary> 
        public string TaskQueueSid { get; set; }

        ///<summary> The SID of the Task with the Events to read. Returns only the Events that pertain to the specified Task. </summary> 
        public string TaskSid { get; set; }

        ///<summary> The SID of the Worker with the Events to read. Returns only the Events that pertain to the specified Worker. </summary> 
        public string WorkerSid { get; set; }

        ///<summary> The SID of the Workflow with the Events to read. Returns only the Events that pertain to the specified Workflow. </summary> 
        public string WorkflowSid { get; set; }

        ///<summary> The TaskChannel with the Events to read. Returns only the Events that pertain to the specified TaskChannel. </summary> 
        public string TaskChannel { get; set; }

        ///<summary> The SID of the Event resource to read. </summary> 
        public string Sid { get; set; }



        /// <summary> Construct a new ListEventOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Events to read. Returns only the Events that pertain to the specified Workspace. </param>
        public ReadEventOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", Serializers.DateTimeIso8601(EndDate)));
            }
            if (EventType != null)
            {
                p.Add(new KeyValuePair<string, string>("EventType", EventType));
            }
            if (Minutes != null)
            {
                p.Add(new KeyValuePair<string, string>("Minutes", Minutes.ToString()));
            }
            if (ReservationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationSid", ReservationSid));
            }
            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", Serializers.DateTimeIso8601(StartDate)));
            }
            if (TaskQueueSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskQueueSid", TaskQueueSid));
            }
            if (TaskSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskSid", TaskSid));
            }
            if (WorkerSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkerSid", WorkerSid));
            }
            if (WorkflowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkflowSid", WorkflowSid));
            }
            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }
            if (Sid != null)
            {
                p.Add(new KeyValuePair<string, string>("Sid", Sid));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

}

