/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Serverless.V1.Service.Build
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Retrieve a specific Build resource.
    /// </summary>
    public class FetchBuildStatusOptions : IOptions<BuildStatusResource>
    {
        /// <summary>
        /// The SID of the Service to fetch the Build resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Build resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchBuildStatusOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Build resource from </param>
        /// <param name="pathSid"> The SID of the Build resource to fetch </param>
        public FetchBuildStatusOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
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