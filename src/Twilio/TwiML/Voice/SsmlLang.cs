// This code was generated by
// \ / _    _  _|   _  _
//  | (_)\/(_)(_|\/| |(/_  v1.0.0
//       /       /

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.Types;

namespace Twilio.TwiML.Voice
{

    /// <summary>Specifying Another Language for Specific Words in Say</summary>
    public class SsmlLang : TwiML
    {
        public sealed class XmlLangEnum : StringEnum
        {
            private XmlLangEnum(string value) : base(value) {}
            public XmlLangEnum() {}
            public static implicit operator XmlLangEnum(string value)
            {
                return new XmlLangEnum(value);
            }

            public static readonly XmlLangEnum Arb = new XmlLangEnum("arb");
            public static readonly XmlLangEnum ArAe = new XmlLangEnum("ar-AE");
            public static readonly XmlLangEnum CaEs = new XmlLangEnum("ca-ES");
            public static readonly XmlLangEnum CmnCn = new XmlLangEnum("cmn-CN");
            public static readonly XmlLangEnum CyGb = new XmlLangEnum("cy-GB");
            public static readonly XmlLangEnum DaDk = new XmlLangEnum("da-DK");
            public static readonly XmlLangEnum DeDe = new XmlLangEnum("de-DE");
            public static readonly XmlLangEnum DeAt = new XmlLangEnum("de-AT");
            public static readonly XmlLangEnum EnAu = new XmlLangEnum("en-AU");
            public static readonly XmlLangEnum EnGb = new XmlLangEnum("en-GB");
            public static readonly XmlLangEnum EnGbWls = new XmlLangEnum("en-GB-WLS");
            public static readonly XmlLangEnum EnIn = new XmlLangEnum("en-IN");
            public static readonly XmlLangEnum EnNz = new XmlLangEnum("en-NZ");
            public static readonly XmlLangEnum EnUs = new XmlLangEnum("en-US");
            public static readonly XmlLangEnum EnZa = new XmlLangEnum("en-ZA");
            public static readonly XmlLangEnum EsEs = new XmlLangEnum("es-ES");
            public static readonly XmlLangEnum EsMx = new XmlLangEnum("es-MX");
            public static readonly XmlLangEnum EsUs = new XmlLangEnum("es-US");
            public static readonly XmlLangEnum FiFi = new XmlLangEnum("fi-FI");
            public static readonly XmlLangEnum FrCa = new XmlLangEnum("fr-CA");
            public static readonly XmlLangEnum FrFr = new XmlLangEnum("fr-FR");
            public static readonly XmlLangEnum HiIn = new XmlLangEnum("hi-IN");
            public static readonly XmlLangEnum IsIs = new XmlLangEnum("is-IS");
            public static readonly XmlLangEnum ItIt = new XmlLangEnum("it-IT");
            public static readonly XmlLangEnum JaJp = new XmlLangEnum("ja-JP");
            public static readonly XmlLangEnum KoKr = new XmlLangEnum("ko-KR");
            public static readonly XmlLangEnum NbNo = new XmlLangEnum("nb-NO");
            public static readonly XmlLangEnum NlNl = new XmlLangEnum("nl-NL");
            public static readonly XmlLangEnum PlPl = new XmlLangEnum("pl-PL");
            public static readonly XmlLangEnum PtBr = new XmlLangEnum("pt-BR");
            public static readonly XmlLangEnum PtPt = new XmlLangEnum("pt-PT");
            public static readonly XmlLangEnum RoRo = new XmlLangEnum("ro-RO");
            public static readonly XmlLangEnum RuRu = new XmlLangEnum("ru-RU");
            public static readonly XmlLangEnum SvSe = new XmlLangEnum("sv-SE");
            public static readonly XmlLangEnum TrTr = new XmlLangEnum("tr-TR");
            public static readonly XmlLangEnum YueCn = new XmlLangEnum("yue-CN");
        }

        /// <summary>Words to speak</summary>
        public string Words { get; set; }

        /// <summary>Specify the language</summary>
        public SsmlLang.XmlLangEnum XmlLang { get; set; }

        /// <summary>Create a new SsmlLang</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        /// <param name="xmlLang">Specify the language</param>
        public SsmlLang(string words = null, SsmlLang.XmlLangEnum xmlLang = null) : base("lang")
        {
            this.Words = words;
            this.XmlLang = xmlLang;
        }

        /// <summary>Return the body of the TwiML tag</summary>
        protected override string GetElementBody()
        {
            return this.Words != null ? this.Words : string.Empty;
        }

        /// <summary>Return the attributes of the TwiML tag</summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.XmlLang != null)
            {
                attributes.Add(new XAttribute(XNamespace.Xml + "lang", this.XmlLang.ToString()));
            }
            return attributes;
        }

        /// <summary>Create a new &lt;Break/&gt; element and append it as a child of this element.</summary>
        /// <param name="strength">Set a pause based on strength</param>
        /// <param name="time">
        /// Set a pause to a specific length of time in seconds or milliseconds, available values: [number]s, [number]ms
        /// </param>
        public SsmlLang Break(SsmlBreak.StrengthEnum strength = null, string time = null)
        {
            var newChild = new SsmlBreak(strength, time);
            this.Append(newChild);
            return this;
        }

        /// <summary>Append a &lt;Break/&gt; element as a child of this element</summary>
        /// <param name="ssmlBreak">A SsmlBreak instance.</param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlLang SsmlBreak(SsmlBreak ssmlBreak)
        {
            this.Append(ssmlBreak);
            return this;
        }

        /// <summary>Create a new &lt;Break/&gt; element and append it as a child of this element.</summary>
        /// <param name="strength">Set a pause based on strength</param>
        /// <param name="time">
        /// Set a pause to a specific length of time in seconds or milliseconds, available values: [number]s, [number]ms
        /// </param>
        [System.Obsolete("This method is deprecated, use .Break() instead.")]
        public SsmlLang SsmlBreak(SsmlBreak.StrengthEnum strength = null, string time = null)
        {
            return Break(strength, time);
        }

        /// <summary>Create a new &lt;Emphasis/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to emphasize, the body of the TwiML Element.</param>
        /// <param name="level">Specify the degree of emphasis</param>
        public SsmlLang Emphasis(string words = null, SsmlEmphasis.LevelEnum level = null)
        {
            var newChild = new SsmlEmphasis(words, level);
            this.Append(newChild);
            return this;
        }

        /// <summary>Append a &lt;Emphasis/&gt; element as a child of this element</summary>
        /// <param name="ssmlEmphasis">A SsmlEmphasis instance.</param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlLang SsmlEmphasis(SsmlEmphasis ssmlEmphasis)
        {
            this.Append(ssmlEmphasis);
            return this;
        }

        /// <summary>Create a new &lt;Emphasis/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to emphasize, the body of the TwiML Element.</param>
        /// <param name="level">Specify the degree of emphasis</param>
        [System.Obsolete("This method is deprecated, use .Emphasis() instead.")]
        public SsmlLang SsmlEmphasis(string words = null, SsmlEmphasis.LevelEnum level = null)
        {
            return Emphasis(words, level);
        }

        /// <summary>Create a new &lt;Lang/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        /// <param name="xmlLang">Specify the language</param>
        public SsmlLang Lang(string words = null, SsmlLang.XmlLangEnum xmlLang = null)
        {
            var newChild = new SsmlLang(words, xmlLang);
            this.Append(newChild);
            return this;
        }

        /// <summary>Append a &lt;Lang/&gt; element as a child of this element</summary>
        /// <param name="ssmlLang">A SsmlLang instance.</param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlLang AppendSsmlLang(SsmlLang ssmlLang)
        {
            this.Append(ssmlLang);
            return this;
        }

        /// <summary>Create a new &lt;Lang/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        /// <param name="xmlLang">Specify the language</param>
        [System.Obsolete("This method is deprecated, use .Lang() instead.")]
        public SsmlLang AppendSsmlLang(string words = null, SsmlLang.XmlLangEnum xmlLang = null)
        {
            return Lang(words, xmlLang);
        }

        /// <summary>Create a new &lt;P/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        public SsmlLang P(string words = null)
        {
            var newChild = new SsmlP(words);
            this.Append(newChild);
            return this;
        }

        /// <summary>Append a &lt;P/&gt; element as a child of this element</summary>
        /// <param name="ssmlP">A SsmlP instance.</param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlLang SsmlP(SsmlP ssmlP)
        {
            this.Append(ssmlP);
            return this;
        }

        /// <summary>Create a new &lt;P/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        [System.Obsolete("This method is deprecated, use .P() instead.")]
        public SsmlLang SsmlP(string words = null)
        {
            return P(words);
        }

        /// <summary>Create a new &lt;Phoneme/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        /// <param name="alphabet">Specify the phonetic alphabet</param>
        /// <param name="ph">Specifiy the phonetic symbols for pronunciation</param>
        public SsmlLang Phoneme(string words = null, SsmlPhoneme.AlphabetEnum alphabet = null, string ph = null)
        {
            var newChild = new SsmlPhoneme(words, alphabet, ph);
            this.Append(newChild);
            return this;
        }

        /// <summary>Append a &lt;Phoneme/&gt; element as a child of this element</summary>
        /// <param name="ssmlPhoneme">A SsmlPhoneme instance.</param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlLang SsmlPhoneme(SsmlPhoneme ssmlPhoneme)
        {
            this.Append(ssmlPhoneme);
            return this;
        }

        /// <summary>Create a new &lt;Phoneme/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        /// <param name="alphabet">Specify the phonetic alphabet</param>
        /// <param name="ph">Specifiy the phonetic symbols for pronunciation</param>
        [System.Obsolete("This method is deprecated, use .Phoneme() instead.")]
        public SsmlLang SsmlPhoneme(string words = null, SsmlPhoneme.AlphabetEnum alphabet = null, string ph = null)
        {
            return Phoneme(words, alphabet, ph);
        }

        /// <summary>Create a new &lt;Prosody/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        /// <param name="volume">
        /// Specify the volume, available values: default, silent, x-soft, soft, medium, loud, x-loud, +ndB, -ndB
        /// </param>
        /// <param name="rate">Specify the rate, available values: x-slow, slow, medium, fast, x-fast, n%</param>
        /// <param name="pitch">Specify the pitch, available values: default, x-low, low, medium, high, x-high, +n%, -n%</param>
        public SsmlLang Prosody(string words = null, string volume = null, string rate = null, string pitch = null)
        {
            var newChild = new SsmlProsody(words, volume, rate, pitch);
            this.Append(newChild);
            return this;
        }

        /// <summary>Append a &lt;Prosody/&gt; element as a child of this element</summary>
        /// <param name="ssmlProsody">A SsmlProsody instance.</param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlLang SsmlProsody(SsmlProsody ssmlProsody)
        {
            this.Append(ssmlProsody);
            return this;
        }

        /// <summary>Create a new &lt;Prosody/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        /// <param name="volume">
        /// Specify the volume, available values: default, silent, x-soft, soft, medium, loud, x-loud, +ndB, -ndB
        /// </param>
        /// <param name="rate">Specify the rate, available values: x-slow, slow, medium, fast, x-fast, n%</param>
        /// <param name="pitch">Specify the pitch, available values: default, x-low, low, medium, high, x-high, +n%, -n%</param>
        [System.Obsolete("This method is deprecated, use .Prosody() instead.")]
        public SsmlLang SsmlProsody(string words = null, string volume = null, string rate = null, string pitch = null)
        {
            return Prosody(words, volume, rate, pitch);
        }

        /// <summary>Create a new &lt;S/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        public SsmlLang S(string words = null)
        {
            var newChild = new SsmlS(words);
            this.Append(newChild);
            return this;
        }

        /// <summary>Append a &lt;S/&gt; element as a child of this element</summary>
        /// <param name="ssmlS">A SsmlS instance.</param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlLang SsmlS(SsmlS ssmlS)
        {
            this.Append(ssmlS);
            return this;
        }

        /// <summary>Create a new &lt;S/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        [System.Obsolete("This method is deprecated, use .S() instead.")]
        public SsmlLang SsmlS(string words = null)
        {
            return S(words);
        }

        /// <summary>Create a new &lt;Say-As/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to be interpreted, the body of the TwiML Element.</param>
        /// <param name="interpretAs">Specify the type of words are spoken</param>
        /// <param name="format">Specify the format of the date when interpret-as is set to date</param>
        public SsmlLang SayAs(string words = null,
                              SsmlSayAs.InterpretAsEnum interpretAs = null,
                              SsmlSayAs.FormatEnum format = null)
        {
            var newChild = new SsmlSayAs(words, interpretAs, format);
            this.Append(newChild);
            return this;
        }

        /// <summary>Append a &lt;Say-As/&gt; element as a child of this element</summary>
        /// <param name="ssmlSayAs">A SsmlSayAs instance.</param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlLang SsmlSayAs(SsmlSayAs ssmlSayAs)
        {
            this.Append(ssmlSayAs);
            return this;
        }

        /// <summary>Create a new &lt;Say-As/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to be interpreted, the body of the TwiML Element.</param>
        /// <param name="interpretAs">Specify the type of words are spoken</param>
        /// <param name="format">Specify the format of the date when interpret-as is set to date</param>
        [System.Obsolete("This method is deprecated, use .SayAs() instead.")]
        public SsmlLang SsmlSayAs(string words = null,
                                  SsmlSayAs.InterpretAsEnum interpretAs = null,
                                  SsmlSayAs.FormatEnum format = null)
        {
            return SayAs(words, interpretAs, format);
        }

        /// <summary>Create a new &lt;Sub/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to be substituted, the body of the TwiML Element.</param>
        /// <param name="alias">
        /// Substitute a different word (or pronunciation) for selected text such as an acronym or abbreviation
        /// </param>
        public SsmlLang Sub(string words = null, string alias = null)
        {
            var newChild = new SsmlSub(words, alias);
            this.Append(newChild);
            return this;
        }

        /// <summary>Append a &lt;Sub/&gt; element as a child of this element</summary>
        /// <param name="ssmlSub">A SsmlSub instance.</param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlLang SsmlSub(SsmlSub ssmlSub)
        {
            this.Append(ssmlSub);
            return this;
        }

        /// <summary>Create a new &lt;Sub/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to be substituted, the body of the TwiML Element.</param>
        /// <param name="alias">
        /// Substitute a different word (or pronunciation) for selected text such as an acronym or abbreviation
        /// </param>
        [System.Obsolete("This method is deprecated, use .Sub() instead.")]
        public SsmlLang SsmlSub(string words = null, string alias = null)
        {
            return Sub(words, alias);
        }

        /// <summary>Create a new &lt;W/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        /// <param name="role">
        /// Customize the pronunciation of words by specifying the word’s part of speech or alternate meaning
        /// </param>
        public SsmlLang W(string words = null, string role = null)
        {
            var newChild = new SsmlW(words, role);
            this.Append(newChild);
            return this;
        }

        /// <summary>Append a &lt;W/&gt; element as a child of this element</summary>
        /// <param name="ssmlW">A SsmlW instance.</param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public SsmlLang SsmlW(SsmlW ssmlW)
        {
            this.Append(ssmlW);
            return this;
        }

        /// <summary>Create a new &lt;W/&gt; element and append it as a child of this element.</summary>
        /// <param name="words">Words to speak, the body of the TwiML Element.</param>
        /// <param name="role">
        /// Customize the pronunciation of words by specifying the word’s part of speech or alternate meaning
        /// </param>
        [System.Obsolete("This method is deprecated, use .W() instead.")]
        public SsmlLang SsmlW(string words = null, string role = null)
        {
            return W(words, role);
        }

        /// <summary>Append a child TwiML element to this element returning this element to allow chaining.</summary>
        /// <param name="childElem">Child TwiML element to add</param>
        public new SsmlLang Append(TwiML childElem)
        {
            return (SsmlLang) base.Append(childElem);
        }

        /// <summary>Add freeform key-value attributes to the generated xml</summary>
        /// <param name="key">Option key</param>
        /// <param name="value">Option value</param>
        public new SsmlLang SetOption(string key, object value)
        {
            return (SsmlLang) base.SetOption(key, value);
        }
    }

}