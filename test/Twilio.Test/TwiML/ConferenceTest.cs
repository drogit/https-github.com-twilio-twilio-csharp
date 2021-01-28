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
    public class ConferenceTest : TwilioTest
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Conference();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Conference></Conference>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new Conference(
                "name",
                true,
                Conference.BeepEnum.True,
                true,
                true,
                new Uri("https://example.com"),
                Twilio.Http.HttpMethod.Get,
                1,
                Conference.RecordEnum.DoNotRecord,
                Conference.RegionEnum.Us1,
                "CAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                Conference.TrimEnum.TrimSilence,
                Promoter.ListOfOne(Conference.EventEnum.Start),
                new Uri("https://example.com"),
                Twilio.Http.HttpMethod.Get,
                new Uri("https://example.com"),
                Twilio.Http.HttpMethod.Get,
                Promoter.ListOfOne(Conference.RecordingEventEnum.InProgress),
                new Uri("https://example.com"),
                Conference.JitterBufferSizeEnum.Large,
                "participant_label"
            );
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Conference muted=\"true\" beep=\"true\" startConferenceOnEnter=\"true\" endConferenceOnExit=\"true\" waitUrl=\"https://example.com\" waitMethod=\"GET\" maxParticipants=\"1\" record=\"do-not-record\" region=\"us1\" coach=\"CAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\" trim=\"trim-silence\" statusCallbackEvent=\"start\" statusCallback=\"https://example.com\" statusCallbackMethod=\"GET\" recordingStatusCallback=\"https://example.com\" recordingStatusCallbackMethod=\"GET\" recordingStatusCallbackEvent=\"in-progress\" eventCallbackUrl=\"https://example.com\" jitterBufferSize=\"large\" participantLabel=\"participant_label\">name</Conference>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Conference();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Conference newParam1=\"value\" newParam2=\"1\"></Conference>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new Conference();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Conference>Here is the content</Conference>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Conference();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Conference>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Conference>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new Conference();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Conference>before<Child>content</Child>after</Conference>",
                elem.ToString()
            );
        }
    }

}