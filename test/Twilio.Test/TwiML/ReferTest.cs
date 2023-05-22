/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NUnit.Framework;
using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;

namespace Twilio.Tests.TwiML
{

    [TestFixture]
    public class ReferTest : TwilioTest
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Refer();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Refer />",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new Refer(new Uri("https://example.com"), Twilio.Http.HttpMethod.Get);
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Refer action=\"https://example.com\" method=\"GET\" />",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Refer();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Refer newParam1=\"value\" newParam2=\"1\" />",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithChildren()
        {
            var elem = new Refer();

            elem.Sip(new Uri("https://example.com"));

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Refer>" + Environment.NewLine +
                "  <Sip>https://example.com</Sip>" + Environment.NewLine +
                "</Refer>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new Refer();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Refer>Here is the content</Refer>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Refer();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Refer>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Refer>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildrenOfChildNodes()
        {
            var elem = new Refer();
            var child = new ReferSip();
            elem.Nest(child).AddChild("generic-tag").SetOption("tag", true).AddText("Content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Refer>" + Environment.NewLine +
                "  <Sip>" + Environment.NewLine +
                "    <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "  </Sip>" + Environment.NewLine +
                "</Refer>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new Refer();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Refer>before<Child>content</Child>after</Refer>",
                elem.ToString()
            );
        }
    }

}