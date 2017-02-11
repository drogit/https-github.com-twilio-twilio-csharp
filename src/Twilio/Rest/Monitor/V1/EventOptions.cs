using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Monitor.V1 
{

    public class FetchEventOptions : IOptions<EventResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchEventOptions
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public FetchEventOptions(string sid)
        {
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

    public class ReadEventOptions : ReadOptions<EventResource> 
    {
        /// <summary>
        /// The actor_sid
        /// </summary>
        public string ActorSid { get; set; }
        /// <summary>
        /// The event_type
        /// </summary>
        public string EventType { get; set; }
        /// <summary>
        /// The resource_sid
        /// </summary>
        public string ResourceSid { get; set; }
        /// <summary>
        /// The source_ip_address
        /// </summary>
        public string SourceIpAddress { get; set; }
        /// <summary>
        /// The start_date
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// The end_date
        /// </summary>
        public DateTime? EndDate { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (ActorSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ActorSid", ActorSid.ToString()));
            }
            
            if (EventType != null)
            {
                p.Add(new KeyValuePair<string, string>("EventType", EventType));
            }
            
            if (ResourceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ResourceSid", ResourceSid.ToString()));
            }
            
            if (SourceIpAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("SourceIpAddress", SourceIpAddress));
            }
            
            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", StartDate.Value.ToString("yyyy-MM-dd")));
            }
            
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", EndDate.Value.ToString("yyyy-MM-dd")));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

}