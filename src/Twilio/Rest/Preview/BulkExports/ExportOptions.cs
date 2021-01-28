/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.BulkExports
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Fetch a specific Export.
    /// </summary>
    public class FetchExportOptions : IOptions<ExportResource>
    {
        /// <summary>
        /// The type of communication – Messages, Calls, Conferences, and Participants
        /// </summary>
        public string PathResourceType { get; }

        /// <summary>
        /// Construct a new FetchExportOptions
        /// </summary>
        /// <param name="pathResourceType"> The type of communication – Messages, Calls, Conferences, and Participants </param>
        public FetchExportOptions(string pathResourceType)
        {
            PathResourceType = pathResourceType;
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

}