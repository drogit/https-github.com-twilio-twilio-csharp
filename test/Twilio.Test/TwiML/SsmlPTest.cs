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
    public class SsmlPTest : TwilioTest
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new SsmlP();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<p />",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new SsmlP("words");
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<p>words</p>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new SsmlP();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<p newParam1=\"value\" newParam2=\"1\" />",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithChildren()
        {
            var elem = new SsmlP();

            elem.Break(SsmlBreak.StrengthEnum.None, "time");

            elem.Emphasis("words", SsmlEmphasis.LevelEnum.Strong);

            elem.Lang("words", SsmlLang.XmlLangEnum.Arb);

            elem.Phoneme("words", SsmlPhoneme.AlphabetEnum.Ipa, "ph");

            elem.Prosody("words", "volume", "rate", "pitch");

            elem.S("words");

            elem.SayAs("words", SsmlSayAs.InterpretAsEnum.Characters, SsmlSayAs.FormatEnum.Mdy);

            elem.Sub("words", "alias");

            elem.W("words", "role");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<p>" + Environment.NewLine +
                "  <break strength=\"none\" time=\"time\" />" + Environment.NewLine +
                "  <emphasis level=\"strong\">words</emphasis>" + Environment.NewLine +
                "  <lang xml:lang=\"arb\">words</lang>" + Environment.NewLine +
                "  <phoneme alphabet=\"ipa\" ph=\"ph\">words</phoneme>" + Environment.NewLine +
                "  <prosody volume=\"volume\" rate=\"rate\" pitch=\"pitch\">words</prosody>" + Environment.NewLine +
                "  <s>words</s>" + Environment.NewLine +
                "  <say-as interpret-as=\"characters\" format=\"mdy\">words</say-as>" + Environment.NewLine +
                "  <sub alias=\"alias\">words</sub>" + Environment.NewLine +
                "  <w role=\"role\">words</w>" + Environment.NewLine +
                "</p>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new SsmlP();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<p>Here is the content</p>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new SsmlP();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<p>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</p>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildrenOfChildNodes()
        {
            var elem = new SsmlP();
            var child = new SsmlBreak();
            elem.Nest(child).AddChild("generic-tag").SetOption("tag", true).AddText("Content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<p>" + Environment.NewLine +
                "  <break>" + Environment.NewLine +
                "    <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "  </break>" + Environment.NewLine +
                "</p>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new SsmlP();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<p>before<Child>content</Child>after</p>",
                elem.ToString()
            );
        }
    }

}