/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.Converters;

namespace Twilio.TwiML.Voice
{

    /// <summary>
    /// Redirect TwiML Verb
    /// </summary>
    public class Redirect : TwiML
    {
        /// <summary>
        /// Redirect URL
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// Redirect URL method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }

        /// <summary>
        /// Create a new Redirect
        /// </summary>
        /// <param name="url"> Redirect URL, the body of the TwiML Element. </param>
        /// <param name="method"> Redirect URL method </param>
        public Redirect(Uri url = null, Twilio.Http.HttpMethod method = null) : base("Redirect")
        {
            this.Url = url;
            this.Method = method;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Url != null ? Serializers.Url(this.Url) : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override IEnumerable<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Redirect Append(TwiML childElem)
        {
            return (Redirect) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Redirect SetOption(string key, object value)
        {
            return (Redirect) base.SetOption(key, value);
        }
    }

}