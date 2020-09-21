/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Conversations.V1
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// CreateCredentialOptions
    /// </summary>
    public class CreateCredentialOptions : IOptions<CredentialResource>
    {
        /// <summary>
        /// The type of push-notification service the credential is for.
        /// </summary>
        public CredentialResource.PushTypeEnum Type { get; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// [APN only] The URL encoded representation of the certificate.
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// [APN only] The URL encoded representation of the private key.
        /// </summary>
        public string PrivateKey { get; set; }
        /// <summary>
        /// [APN only] Whether to send the credential to sandbox APNs.
        /// </summary>
        public bool? Sandbox { get; set; }
        /// <summary>
        /// [GCM only] The API key for the project that was obtained from the Google Developer console for your GCM Service application credential.
        /// </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// [FCM only] The Server key of your project from Firebase console.
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Construct a new CreateCredentialOptions
        /// </summary>
        /// <param name="type"> The type of push-notification service the credential is for. </param>
        public CreateCredentialOptions(CredentialResource.PushTypeEnum type)
        {
            Type = type;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Certificate != null)
            {
                p.Add(new KeyValuePair<string, string>("Certificate", Certificate));
            }

            if (PrivateKey != null)
            {
                p.Add(new KeyValuePair<string, string>("PrivateKey", PrivateKey));
            }

            if (Sandbox != null)
            {
                p.Add(new KeyValuePair<string, string>("Sandbox", Sandbox.Value.ToString().ToLower()));
            }

            if (ApiKey != null)
            {
                p.Add(new KeyValuePair<string, string>("ApiKey", ApiKey));
            }

            if (Secret != null)
            {
                p.Add(new KeyValuePair<string, string>("Secret", Secret));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// UpdateCredentialOptions
    /// </summary>
    public class UpdateCredentialOptions : IOptions<CredentialResource>
    {
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The type of push-notification service the credential is for.
        /// </summary>
        public CredentialResource.PushTypeEnum Type { get; set; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// [APN only] The URL encoded representation of the certificate.
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// [APN only] The URL encoded representation of the private key.
        /// </summary>
        public string PrivateKey { get; set; }
        /// <summary>
        /// [APN only] Whether to send the credential to sandbox APNs.
        /// </summary>
        public bool? Sandbox { get; set; }
        /// <summary>
        /// [GCM only] The API key for the project that was obtained from the Google Developer console for your GCM Service application credential.
        /// </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// [FCM only] The Server key of your project from Firebase console.
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Construct a new UpdateCredentialOptions
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public UpdateCredentialOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Certificate != null)
            {
                p.Add(new KeyValuePair<string, string>("Certificate", Certificate));
            }

            if (PrivateKey != null)
            {
                p.Add(new KeyValuePair<string, string>("PrivateKey", PrivateKey));
            }

            if (Sandbox != null)
            {
                p.Add(new KeyValuePair<string, string>("Sandbox", Sandbox.Value.ToString().ToLower()));
            }

            if (ApiKey != null)
            {
                p.Add(new KeyValuePair<string, string>("ApiKey", ApiKey));
            }

            if (Secret != null)
            {
                p.Add(new KeyValuePair<string, string>("Secret", Secret));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// DeleteCredentialOptions
    /// </summary>
    public class DeleteCredentialOptions : IOptions<CredentialResource>
    {
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteCredentialOptions
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public DeleteCredentialOptions(string pathSid)
        {
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
    /// FetchCredentialOptions
    /// </summary>
    public class FetchCredentialOptions : IOptions<CredentialResource>
    {
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchCredentialOptions
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchCredentialOptions(string pathSid)
        {
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
    /// ReadCredentialOptions
    /// </summary>
    public class ReadCredentialOptions : ReadOptions<CredentialResource>
    {
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