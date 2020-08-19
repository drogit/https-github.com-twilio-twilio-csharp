/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Proxy.V1.Service.Session
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Fetch a specific Participant.
    /// </summary>
    public class FetchParticipantOptions : IOptions<ParticipantResource>
    {
        /// <summary>
        /// The SID of the parent Service of the resource to fetch
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the parent Session of the resource to fetch
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchParticipantOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the parent Service of the resource to fetch </param>
        /// <param name="pathSessionSid"> The SID of the parent Session of the resource to fetch </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchParticipantOptions(string pathServiceSid, string pathSessionSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
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

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Retrieve a list of all Participants in a Session.
    /// </summary>
    public class ReadParticipantOptions : ReadOptions<ParticipantResource>
    {
        /// <summary>
        /// The SID of the parent Service of the resource to read
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the parent Session of the resource to read
        /// </summary>
        public string PathSessionSid { get; }

        /// <summary>
        /// Construct a new ReadParticipantOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the parent Service of the resource to read </param>
        /// <param name="pathSessionSid"> The SID of the parent Session of the resource to read </param>
        public ReadParticipantOptions(string pathServiceSid, string pathSessionSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
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

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Add a new Participant to the Session
    /// </summary>
    public class CreateParticipantOptions : IOptions<ParticipantResource>
    {
        /// <summary>
        /// The SID of the parent Service resource
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the parent Session resource
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// The phone number of the Participant
        /// </summary>
        public string Identifier { get; }
        /// <summary>
        /// The string that you assigned to describe the participant
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The proxy phone number to use for the Participant
        /// </summary>
        public string ProxyIdentifier { get; set; }
        /// <summary>
        /// The Proxy Identifier Sid
        /// </summary>
        public string ProxyIdentifierSid { get; set; }
        /// <summary>
        /// An experimental flag that instructs Proxy to reject a Participant create request when it detects a conflict.
        /// </summary>
        public bool? FailOnParticipantConflict { get; set; }

        /// <summary>
        /// Construct a new CreateParticipantOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the parent Service resource </param>
        /// <param name="pathSessionSid"> The SID of the parent Session resource </param>
        /// <param name="identifier"> The phone number of the Participant </param>
        public CreateParticipantOptions(string pathServiceSid, string pathSessionSid, string identifier)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            Identifier = identifier;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identifier != null)
            {
                p.Add(new KeyValuePair<string, string>("Identifier", Identifier));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (ProxyIdentifier != null)
            {
                p.Add(new KeyValuePair<string, string>("ProxyIdentifier", ProxyIdentifier));
            }

            if (ProxyIdentifierSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ProxyIdentifierSid", ProxyIdentifierSid.ToString()));
            }

            if (FailOnParticipantConflict != null)
            {
                p.Add(new KeyValuePair<string, string>("FailOnParticipantConflict", FailOnParticipantConflict.Value.ToString().ToLower()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Delete a specific Participant. This is a soft-delete. The participant remains associated with the session and cannot
    /// be re-added. Participants are only permanently deleted when the
    /// [Session](https://www.twilio.com/docs/proxy/api/session) is deleted.
    /// </summary>
    public class DeleteParticipantOptions : IOptions<ParticipantResource>
    {
        /// <summary>
        /// The SID of the parent Service of the resource to delete
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the parent Session of the resource to delete
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteParticipantOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the parent Service of the resource to delete </param>
        /// <param name="pathSessionSid"> The SID of the parent Session of the resource to delete </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteParticipantOptions(string pathServiceSid, string pathSessionSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
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