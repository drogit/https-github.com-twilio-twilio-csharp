/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Sync.V1.Service
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// FetchDocumentOptions
    /// </summary>
    public class FetchDocumentOptions : IOptions<DocumentResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Document resource to fetch
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Document resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchDocumentOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Document resource to fetch </param>
        /// <param name="pathSid"> The SID of the Document resource to fetch </param>
        public FetchDocumentOptions(string pathServiceSid, string pathSid)
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

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// DeleteDocumentOptions
    /// </summary>
    public class DeleteDocumentOptions : IOptions<DocumentResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Document resource to delete
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Document resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteDocumentOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Document resource to delete </param>
        /// <param name="pathSid"> The SID of the Document resource to delete </param>
        public DeleteDocumentOptions(string pathServiceSid, string pathSid)
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

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// CreateDocumentOptions
    /// </summary>
    public class CreateDocumentOptions : IOptions<DocumentResource>
    {
        /// <summary>
        /// The SID of the Sync Service to associate the Document resource to create with
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// An application-defined string that uniquely identifies the Sync Document
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// A JSON string that represents an arbitrary, schema-less object that the Sync Document stores
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// How long, in seconds, before the Sync Document expires and is deleted
        /// </summary>
        public int? Ttl { get; set; }

        /// <summary>
        /// Construct a new CreateDocumentOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service to associate the Document resource to create with </param>
        public CreateDocumentOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// ReadDocumentOptions
    /// </summary>
    public class ReadDocumentOptions : ReadOptions<DocumentResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Document resources to read
        /// </summary>
        public string PathServiceSid { get; }

        /// <summary>
        /// Construct a new ReadDocumentOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Document resources to read </param>
        public ReadDocumentOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
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
    /// UpdateDocumentOptions
    /// </summary>
    public class UpdateDocumentOptions : IOptions<DocumentResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Document resource to update
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Document resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A JSON string that represents an arbitrary, schema-less object that the Sync Document stores
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// How long, in seconds, before the Document resource expires and is deleted
        /// </summary>
        public int? Ttl { get; set; }

        /// <summary>
        /// Construct a new UpdateDocumentOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Document resource to update </param>
        /// <param name="pathSid"> The SID of the Document resource to update </param>
        public UpdateDocumentOptions(string pathServiceSid, string pathSid)
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
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }

            return p;
        }
    }

}