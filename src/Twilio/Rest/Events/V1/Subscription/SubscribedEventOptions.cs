/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Events.V1.Subscription
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a list of all Subscribed Event types for a Subscription.
    /// </summary>
    public class ReadSubscribedEventOptions : ReadOptions<SubscribedEventResource>
    {
        /// <summary>
        /// Subscription SID.
        /// </summary>
        public string PathSubscriptionSid { get; }

        /// <summary>
        /// Construct a new ReadSubscribedEventOptions
        /// </summary>
        /// <param name="pathSubscriptionSid"> Subscription SID. </param>
        public ReadSubscribedEventOptions(string pathSubscriptionSid)
        {
            PathSubscriptionSid = pathSubscriptionSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}