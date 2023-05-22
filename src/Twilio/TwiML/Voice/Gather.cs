/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Twilio.Converters;
using Twilio.Types;

namespace Twilio.TwiML.Voice
{

    /// <summary>
    /// Gather TwiML Verb
    /// </summary>
    public class Gather : TwiML
    {
        public sealed class InputEnum : StringEnum
        {
            private InputEnum(string value) : base(value) {}
            public InputEnum() {}
            public static implicit operator InputEnum(string value)
            {
                return new InputEnum(value);
            }

            public static readonly InputEnum Dtmf = new InputEnum("dtmf");
            public static readonly InputEnum Speech = new InputEnum("speech");
        }

        public sealed class LanguageEnum : StringEnum
        {
            private LanguageEnum(string value) : base(value) {}
            public LanguageEnum() {}
            public static implicit operator LanguageEnum(string value)
            {
                return new LanguageEnum(value);
            }

            public static readonly LanguageEnum AfZa = new LanguageEnum("af-ZA");
            public static readonly LanguageEnum AmEt = new LanguageEnum("am-ET");
            public static readonly LanguageEnum ArAe = new LanguageEnum("ar-AE");
            public static readonly LanguageEnum ArBh = new LanguageEnum("ar-BH");
            public static readonly LanguageEnum ArDz = new LanguageEnum("ar-DZ");
            public static readonly LanguageEnum ArEg = new LanguageEnum("ar-EG");
            public static readonly LanguageEnum ArIl = new LanguageEnum("ar-IL");
            public static readonly LanguageEnum ArIq = new LanguageEnum("ar-IQ");
            public static readonly LanguageEnum ArJo = new LanguageEnum("ar-JO");
            public static readonly LanguageEnum ArKw = new LanguageEnum("ar-KW");
            public static readonly LanguageEnum ArLb = new LanguageEnum("ar-LB");
            public static readonly LanguageEnum ArMa = new LanguageEnum("ar-MA");
            public static readonly LanguageEnum ArOm = new LanguageEnum("ar-OM");
            public static readonly LanguageEnum ArPs = new LanguageEnum("ar-PS");
            public static readonly LanguageEnum ArQa = new LanguageEnum("ar-QA");
            public static readonly LanguageEnum ArSa = new LanguageEnum("ar-SA");
            public static readonly LanguageEnum ArTn = new LanguageEnum("ar-TN");
            public static readonly LanguageEnum AzAz = new LanguageEnum("az-AZ");
            public static readonly LanguageEnum BgBg = new LanguageEnum("bg-BG");
            public static readonly LanguageEnum BnBd = new LanguageEnum("bn-BD");
            public static readonly LanguageEnum BnIn = new LanguageEnum("bn-IN");
            public static readonly LanguageEnum CaEs = new LanguageEnum("ca-ES");
            public static readonly LanguageEnum CsCz = new LanguageEnum("cs-CZ");
            public static readonly LanguageEnum DaDk = new LanguageEnum("da-DK");
            public static readonly LanguageEnum DeDe = new LanguageEnum("de-DE");
            public static readonly LanguageEnum ElGr = new LanguageEnum("el-GR");
            public static readonly LanguageEnum EnAu = new LanguageEnum("en-AU");
            public static readonly LanguageEnum EnCa = new LanguageEnum("en-CA");
            public static readonly LanguageEnum EnGb = new LanguageEnum("en-GB");
            public static readonly LanguageEnum EnGh = new LanguageEnum("en-GH");
            public static readonly LanguageEnum EnIe = new LanguageEnum("en-IE");
            public static readonly LanguageEnum EnIn = new LanguageEnum("en-IN");
            public static readonly LanguageEnum EnKe = new LanguageEnum("en-KE");
            public static readonly LanguageEnum EnNg = new LanguageEnum("en-NG");
            public static readonly LanguageEnum EnNz = new LanguageEnum("en-NZ");
            public static readonly LanguageEnum EnPh = new LanguageEnum("en-PH");
            public static readonly LanguageEnum EnSg = new LanguageEnum("en-SG");
            public static readonly LanguageEnum EnTz = new LanguageEnum("en-TZ");
            public static readonly LanguageEnum EnUs = new LanguageEnum("en-US");
            public static readonly LanguageEnum EnZa = new LanguageEnum("en-ZA");
            public static readonly LanguageEnum EsAr = new LanguageEnum("es-AR");
            public static readonly LanguageEnum EsBo = new LanguageEnum("es-BO");
            public static readonly LanguageEnum EsCl = new LanguageEnum("es-CL");
            public static readonly LanguageEnum EsCo = new LanguageEnum("es-CO");
            public static readonly LanguageEnum EsCr = new LanguageEnum("es-CR");
            public static readonly LanguageEnum EsDo = new LanguageEnum("es-DO");
            public static readonly LanguageEnum EsEc = new LanguageEnum("es-EC");
            public static readonly LanguageEnum EsEs = new LanguageEnum("es-ES");
            public static readonly LanguageEnum EsGt = new LanguageEnum("es-GT");
            public static readonly LanguageEnum EsHn = new LanguageEnum("es-HN");
            public static readonly LanguageEnum EsMx = new LanguageEnum("es-MX");
            public static readonly LanguageEnum EsNi = new LanguageEnum("es-NI");
            public static readonly LanguageEnum EsPa = new LanguageEnum("es-PA");
            public static readonly LanguageEnum EsPe = new LanguageEnum("es-PE");
            public static readonly LanguageEnum EsPr = new LanguageEnum("es-PR");
            public static readonly LanguageEnum EsPy = new LanguageEnum("es-PY");
            public static readonly LanguageEnum EsSv = new LanguageEnum("es-SV");
            public static readonly LanguageEnum EsUs = new LanguageEnum("es-US");
            public static readonly LanguageEnum EsUy = new LanguageEnum("es-UY");
            public static readonly LanguageEnum EsVe = new LanguageEnum("es-VE");
            public static readonly LanguageEnum EtEe = new LanguageEnum("et-EE");
            public static readonly LanguageEnum EuEs = new LanguageEnum("eu-ES");
            public static readonly LanguageEnum FaIr = new LanguageEnum("fa-IR");
            public static readonly LanguageEnum FiFi = new LanguageEnum("fi-FI");
            public static readonly LanguageEnum FilPh = new LanguageEnum("fil-PH");
            public static readonly LanguageEnum FrCa = new LanguageEnum("fr-CA");
            public static readonly LanguageEnum FrFr = new LanguageEnum("fr-FR");
            public static readonly LanguageEnum GlEs = new LanguageEnum("gl-ES");
            public static readonly LanguageEnum GuIn = new LanguageEnum("gu-IN");
            public static readonly LanguageEnum HeIl = new LanguageEnum("he-IL");
            public static readonly LanguageEnum HiIn = new LanguageEnum("hi-IN");
            public static readonly LanguageEnum HrHr = new LanguageEnum("hr-HR");
            public static readonly LanguageEnum HuHu = new LanguageEnum("hu-HU");
            public static readonly LanguageEnum HyAm = new LanguageEnum("hy-AM");
            public static readonly LanguageEnum IdId = new LanguageEnum("id-ID");
            public static readonly LanguageEnum IsIs = new LanguageEnum("is-IS");
            public static readonly LanguageEnum ItIt = new LanguageEnum("it-IT");
            public static readonly LanguageEnum JaJp = new LanguageEnum("ja-JP");
            public static readonly LanguageEnum JvId = new LanguageEnum("jv-ID");
            public static readonly LanguageEnum KaGe = new LanguageEnum("ka-GE");
            public static readonly LanguageEnum KmKh = new LanguageEnum("km-KH");
            public static readonly LanguageEnum KnIn = new LanguageEnum("kn-IN");
            public static readonly LanguageEnum KoKr = new LanguageEnum("ko-KR");
            public static readonly LanguageEnum LoLa = new LanguageEnum("lo-LA");
            public static readonly LanguageEnum LtLt = new LanguageEnum("lt-LT");
            public static readonly LanguageEnum LvLv = new LanguageEnum("lv-LV");
            public static readonly LanguageEnum MkMk = new LanguageEnum("mk-MK");
            public static readonly LanguageEnum MlIn = new LanguageEnum("ml-IN");
            public static readonly LanguageEnum MnMn = new LanguageEnum("mn-MN");
            public static readonly LanguageEnum MrIn = new LanguageEnum("mr-IN");
            public static readonly LanguageEnum MsMy = new LanguageEnum("ms-MY");
            public static readonly LanguageEnum MyMm = new LanguageEnum("my-MM");
            public static readonly LanguageEnum NarIq = new LanguageEnum("nar-IQ");
            public static readonly LanguageEnum NbNo = new LanguageEnum("nb-NO");
            public static readonly LanguageEnum NeNp = new LanguageEnum("ne-NP");
            public static readonly LanguageEnum NlBe = new LanguageEnum("nl-BE");
            public static readonly LanguageEnum NlNl = new LanguageEnum("nl-NL");
            public static readonly LanguageEnum PaGuruIn = new LanguageEnum("pa-guru-IN");
            public static readonly LanguageEnum PlPl = new LanguageEnum("pl-PL");
            public static readonly LanguageEnum PtBr = new LanguageEnum("pt-BR");
            public static readonly LanguageEnum PtPt = new LanguageEnum("pt-PT");
            public static readonly LanguageEnum RoRo = new LanguageEnum("ro-RO");
            public static readonly LanguageEnum RuRu = new LanguageEnum("ru-RU");
            public static readonly LanguageEnum SiLk = new LanguageEnum("si-LK");
            public static readonly LanguageEnum SkSk = new LanguageEnum("sk-SK");
            public static readonly LanguageEnum SlSi = new LanguageEnum("sl-SI");
            public static readonly LanguageEnum SqAl = new LanguageEnum("sq-AL");
            public static readonly LanguageEnum SrRs = new LanguageEnum("sr-RS");
            public static readonly LanguageEnum SuId = new LanguageEnum("su-ID");
            public static readonly LanguageEnum SvSe = new LanguageEnum("sv-SE");
            public static readonly LanguageEnum SwKe = new LanguageEnum("sw-KE");
            public static readonly LanguageEnum SwTz = new LanguageEnum("sw-TZ");
            public static readonly LanguageEnum TaIn = new LanguageEnum("ta-IN");
            public static readonly LanguageEnum TaLk = new LanguageEnum("ta-LK");
            public static readonly LanguageEnum TaMy = new LanguageEnum("ta-MY");
            public static readonly LanguageEnum TaSg = new LanguageEnum("ta-SG");
            public static readonly LanguageEnum TeIn = new LanguageEnum("te-IN");
            public static readonly LanguageEnum ThTh = new LanguageEnum("th-TH");
            public static readonly LanguageEnum TrTr = new LanguageEnum("tr-TR");
            public static readonly LanguageEnum UkUa = new LanguageEnum("uk-UA");
            public static readonly LanguageEnum UrIn = new LanguageEnum("ur-IN");
            public static readonly LanguageEnum UrPk = new LanguageEnum("ur-PK");
            public static readonly LanguageEnum UzUz = new LanguageEnum("uz-UZ");
            public static readonly LanguageEnum ViVn = new LanguageEnum("vi-VN");
            public static readonly LanguageEnum YueHantHk = new LanguageEnum("yue-Hant-HK");
            public static readonly LanguageEnum Zh = new LanguageEnum("zh");
            public static readonly LanguageEnum CmnHansCn = new LanguageEnum("cmn-Hans-CN");
            public static readonly LanguageEnum ZhTw = new LanguageEnum("zh-TW");
            public static readonly LanguageEnum CmnHantTw = new LanguageEnum("cmn-Hant-TW");
            public static readonly LanguageEnum ZuZa = new LanguageEnum("zu-ZA");
        }

        public sealed class SpeechModelEnum : StringEnum
        {
            private SpeechModelEnum(string value) : base(value) {}
            public SpeechModelEnum() {}
            public static implicit operator SpeechModelEnum(string value)
            {
                return new SpeechModelEnum(value);
            }

            public static readonly SpeechModelEnum Default = new SpeechModelEnum("default");
            public static readonly SpeechModelEnum NumbersAndCommands = new SpeechModelEnum("numbers_and_commands");
            public static readonly SpeechModelEnum PhoneCall = new SpeechModelEnum("phone_call");
            public static readonly SpeechModelEnum ExperimentalConversations = new SpeechModelEnum("experimental_conversations");
            public static readonly SpeechModelEnum ExperimentalUtterances = new SpeechModelEnum("experimental_utterances");
        }

        /// <summary>
        /// Input type Twilio should accept
        /// </summary>
        public IEnumerable<Gather.InputEnum> Input { get; set; }
        /// <summary>
        /// Action URL
        /// </summary>
        public Uri Action { get; set; }
        /// <summary>
        /// Action URL method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Time to wait to gather input
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// Time to wait to gather speech input and it should be either auto or a positive integer.
        /// </summary>
        public string SpeechTimeout { get; set; }
        /// <summary>
        /// Max allowed time for speech input
        /// </summary>
        public int? MaxSpeechTime { get; set; }
        /// <summary>
        /// Profanity Filter on speech
        /// </summary>
        public bool? ProfanityFilter { get; set; }
        /// <summary>
        /// Finish gather on key
        /// </summary>
        public string FinishOnKey { get; set; }
        /// <summary>
        /// Number of digits to collect
        /// </summary>
        public int? NumDigits { get; set; }
        /// <summary>
        /// Partial result callback URL
        /// </summary>
        public Uri PartialResultCallback { get; set; }
        /// <summary>
        /// Partial result callback URL method
        /// </summary>
        public Twilio.Http.HttpMethod PartialResultCallbackMethod { get; set; }
        /// <summary>
        /// Language to use
        /// </summary>
        public Gather.LanguageEnum Language { get; set; }
        /// <summary>
        /// Speech recognition hints
        /// </summary>
        public string Hints { get; set; }
        /// <summary>
        /// Stop playing media upon speech
        /// </summary>
        public bool? BargeIn { get; set; }
        /// <summary>
        /// Allow debug for gather
        /// </summary>
        public bool? Debug { get; set; }
        /// <summary>
        /// Force webhook to the action URL event if there is no input
        /// </summary>
        public bool? ActionOnEmptyResult { get; set; }
        /// <summary>
        /// Specify the model that is best suited for your use case
        /// </summary>
        public Gather.SpeechModelEnum SpeechModel { get; set; }
        /// <summary>
        /// Use enhanced speech model
        /// </summary>
        public bool? Enhanced { get; set; }

        /// <summary>
        /// Create a new Gather
        /// </summary>
        /// <param name="input"> Input type Twilio should accept </param>
        /// <param name="action"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        /// <param name="timeout"> Time to wait to gather input </param>
        /// <param name="speechTimeout"> Time to wait to gather speech input and it should be either auto or a positive
        ///                     integer. </param>
        /// <param name="maxSpeechTime"> Max allowed time for speech input </param>
        /// <param name="profanityFilter"> Profanity Filter on speech </param>
        /// <param name="finishOnKey"> Finish gather on key </param>
        /// <param name="numDigits"> Number of digits to collect </param>
        /// <param name="partialResultCallback"> Partial result callback URL </param>
        /// <param name="partialResultCallbackMethod"> Partial result callback URL method </param>
        /// <param name="language"> Language to use </param>
        /// <param name="hints"> Speech recognition hints </param>
        /// <param name="bargeIn"> Stop playing media upon speech </param>
        /// <param name="debug"> Allow debug for gather </param>
        /// <param name="actionOnEmptyResult"> Force webhook to the action URL event if there is no input </param>
        /// <param name="speechModel"> Specify the model that is best suited for your use case </param>
        /// <param name="enhanced"> Use enhanced speech model </param>
        public Gather(IEnumerable<Gather.InputEnum> input = null,
                      Uri action = null,
                      Twilio.Http.HttpMethod method = null,
                      int? timeout = null,
                      string speechTimeout = null,
                      int? maxSpeechTime = null,
                      bool? profanityFilter = null,
                      string finishOnKey = null,
                      int? numDigits = null,
                      Uri partialResultCallback = null,
                      Twilio.Http.HttpMethod partialResultCallbackMethod = null,
                      Gather.LanguageEnum language = null,
                      string hints = null,
                      bool? bargeIn = null,
                      bool? debug = null,
                      bool? actionOnEmptyResult = null,
                      Gather.SpeechModelEnum speechModel = null,
                      bool? enhanced = null) : base("Gather")
        {
            this.Input = input;
            this.Action = action;
            this.Method = method;
            this.Timeout = timeout;
            this.SpeechTimeout = speechTimeout;
            this.MaxSpeechTime = maxSpeechTime;
            this.ProfanityFilter = profanityFilter;
            this.FinishOnKey = finishOnKey;
            this.NumDigits = numDigits;
            this.PartialResultCallback = partialResultCallback;
            this.PartialResultCallbackMethod = partialResultCallbackMethod;
            this.Language = language;
            this.Hints = hints;
            this.BargeIn = bargeIn;
            this.Debug = debug;
            this.ActionOnEmptyResult = actionOnEmptyResult;
            this.SpeechModel = speechModel;
            this.Enhanced = enhanced;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override IEnumerable<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Input != null)
            {
                attributes.Add(new XAttribute("input", String.Join(" ", this.Input.Select(e => e.ToString()).ToArray())));
            }
            if (this.Action != null)
            {
                attributes.Add(new XAttribute("action", Serializers.Url(this.Action)));
            }
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            if (this.Timeout != null)
            {
                attributes.Add(new XAttribute("timeout", this.Timeout.ToString()));
            }
            if (this.SpeechTimeout != null)
            {
                attributes.Add(new XAttribute("speechTimeout", this.SpeechTimeout));
            }
            if (this.MaxSpeechTime != null)
            {
                attributes.Add(new XAttribute("maxSpeechTime", this.MaxSpeechTime.ToString()));
            }
            if (this.ProfanityFilter != null)
            {
                attributes.Add(new XAttribute("profanityFilter", this.ProfanityFilter.Value.ToString().ToLower()));
            }
            if (this.FinishOnKey != null)
            {
                attributes.Add(new XAttribute("finishOnKey", this.FinishOnKey));
            }
            if (this.NumDigits != null)
            {
                attributes.Add(new XAttribute("numDigits", this.NumDigits.ToString()));
            }
            if (this.PartialResultCallback != null)
            {
                attributes.Add(new XAttribute("partialResultCallback", Serializers.Url(this.PartialResultCallback)));
            }
            if (this.PartialResultCallbackMethod != null)
            {
                attributes.Add(new XAttribute("partialResultCallbackMethod", this.PartialResultCallbackMethod.ToString()));
            }
            if (this.Language != null)
            {
                attributes.Add(new XAttribute("language", this.Language.ToString()));
            }
            if (this.Hints != null)
            {
                attributes.Add(new XAttribute("hints", this.Hints));
            }
            if (this.BargeIn != null)
            {
                attributes.Add(new XAttribute("bargeIn", this.BargeIn.Value.ToString().ToLower()));
            }
            if (this.Debug != null)
            {
                attributes.Add(new XAttribute("debug", this.Debug.Value.ToString().ToLower()));
            }
            if (this.ActionOnEmptyResult != null)
            {
                attributes.Add(new XAttribute("actionOnEmptyResult", this.ActionOnEmptyResult.Value.ToString().ToLower()));
            }
            if (this.SpeechModel != null)
            {
                attributes.Add(new XAttribute("speechModel", this.SpeechModel.ToString()));
            }
            if (this.Enhanced != null)
            {
                attributes.Add(new XAttribute("enhanced", this.Enhanced.Value.ToString().ToLower()));
            }
            return attributes;
        }

        /// <summary>
        /// Create a new <Say/> element and append it as a child of this element.
        /// </summary>
        /// <param name="message"> Message to say, the body of the TwiML Element. </param>
        /// <param name="voice"> Voice to use </param>
        /// <param name="loop"> Times to loop message </param>
        /// <param name="language"> Message language </param>
        public Gather Say(string message = null,
                          Say.VoiceEnum voice = null,
                          int? loop = null,
                          Say.LanguageEnum language = null)
        {
            var newChild = new Say(message, voice, loop, language);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Say/> element as a child of this element
        /// </summary>
        /// <param name="say"> A Say instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Gather Say(Say say)
        {
            this.Append(say);
            return this;
        }

        /// <summary>
        /// Create a new <Pause/> element and append it as a child of this element.
        /// </summary>
        /// <param name="length"> Length in seconds to pause </param>
        public Gather Pause(int? length = null)
        {
            var newChild = new Pause(length);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Pause/> element as a child of this element
        /// </summary>
        /// <param name="pause"> A Pause instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Gather Pause(Pause pause)
        {
            this.Append(pause);
            return this;
        }

        /// <summary>
        /// Create a new <Play/> element and append it as a child of this element.
        /// </summary>
        /// <param name="url"> Media URL, the body of the TwiML Element. </param>
        /// <param name="loop"> Times to loop media </param>
        /// <param name="digits"> Play DTMF tones for digits </param>
        public Gather Play(Uri url = null, int? loop = null, string digits = null)
        {
            var newChild = new Play(url, loop, digits);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Play/> element as a child of this element
        /// </summary>
        /// <param name="play"> A Play instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Gather Play(Play play)
        {
            this.Append(play);
            return this;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Gather Append(TwiML childElem)
        {
            return (Gather) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Gather SetOption(string key, object value)
        {
            return (Gather) base.SetOption(key, value);
        }
    }

}