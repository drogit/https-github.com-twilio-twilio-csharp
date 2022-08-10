/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Routes.V2
{

    /// <summary>
    /// Assign an Inbound Processing Region to a SIP Trunk
    /// </summary>
    public class CreateTrunkOptions : IOptions<TrunkResource>
    {
        /// <summary>
        /// The SIP Trunk
        /// </summary>
        public string PathSipTrunkDomain { get; }
        /// <summary>
        /// The Inbound Processing Region used for this SIP Trunk for voice
        /// </summary>
        public string VoiceRegion { get; set; }
        /// <summary>
        /// A human readable description of this resource.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new CreateTrunkOptions
        /// </summary>
        /// <param name="pathSipTrunkDomain"> The SIP Trunk </param>
        public CreateTrunkOptions(string pathSipTrunkDomain)
        {
            PathSipTrunkDomain = pathSipTrunkDomain;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (VoiceRegion != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceRegion", VoiceRegion));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// Assign an Inbound Processing Region to a SIP Trunk
    /// </summary>
    public class UpdateTrunkOptions : IOptions<TrunkResource>
    {
        /// <summary>
        /// The SIP Trunk
        /// </summary>
        public string PathSipTrunkDomain { get; }
        /// <summary>
        /// The Inbound Processing Region used for this SIP Trunk for voice
        /// </summary>
        public string VoiceRegion { get; set; }
        /// <summary>
        /// A human readable description of this resource.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new UpdateTrunkOptions
        /// </summary>
        /// <param name="pathSipTrunkDomain"> The SIP Trunk </param>
        public UpdateTrunkOptions(string pathSipTrunkDomain)
        {
            PathSipTrunkDomain = pathSipTrunkDomain;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (VoiceRegion != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceRegion", VoiceRegion));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// Fetch the Inbound Processing Region assigned to a SIP Trunk.
    /// </summary>
    public class FetchTrunkOptions : IOptions<TrunkResource>
    {
        /// <summary>
        /// The SIP Trunk
        /// </summary>
        public string PathSipTrunkDomain { get; }

        /// <summary>
        /// Construct a new FetchTrunkOptions
        /// </summary>
        /// <param name="pathSipTrunkDomain"> The SIP Trunk </param>
        public FetchTrunkOptions(string pathSipTrunkDomain)
        {
            PathSipTrunkDomain = pathSipTrunkDomain;
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