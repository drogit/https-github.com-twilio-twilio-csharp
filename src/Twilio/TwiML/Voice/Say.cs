/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.Types;

namespace Twilio.TwiML.Voice
{

    /// <summary>
    /// Say TwiML Verb
    /// </summary>
    public class Say : TwiML
    {
        public sealed class VoiceEnum : StringEnum
        {
            private VoiceEnum(string value) : base(value) {}
            public VoiceEnum() {}
            public static implicit operator VoiceEnum(string value)
            {
                return new VoiceEnum(value);
            }

            public static readonly VoiceEnum Man = new VoiceEnum("man");
            public static readonly VoiceEnum Woman = new VoiceEnum("woman");
            public static readonly VoiceEnum Alice = new VoiceEnum("alice");
            public static readonly VoiceEnum PollyAditi = new VoiceEnum("Polly.Aditi");
            public static readonly VoiceEnum PollyAmy = new VoiceEnum("Polly.Amy");
            public static readonly VoiceEnum PollyAstrid = new VoiceEnum("Polly.Astrid");
            public static readonly VoiceEnum PollyBianca = new VoiceEnum("Polly.Bianca");
            public static readonly VoiceEnum PollyBrian = new VoiceEnum("Polly.Brian");
            public static readonly VoiceEnum PollyCamila = new VoiceEnum("Polly.Camila");
            public static readonly VoiceEnum PollyCarla = new VoiceEnum("Polly.Carla");
            public static readonly VoiceEnum PollyCarmen = new VoiceEnum("Polly.Carmen");
            public static readonly VoiceEnum PollyCeline = new VoiceEnum("Polly.Celine");
            public static readonly VoiceEnum PollyChantal = new VoiceEnum("Polly.Chantal");
            public static readonly VoiceEnum PollyConchita = new VoiceEnum("Polly.Conchita");
            public static readonly VoiceEnum PollyCristiano = new VoiceEnum("Polly.Cristiano");
            public static readonly VoiceEnum PollyDora = new VoiceEnum("Polly.Dora");
            public static readonly VoiceEnum PollyEmma = new VoiceEnum("Polly.Emma");
            public static readonly VoiceEnum PollyEnrique = new VoiceEnum("Polly.Enrique");
            public static readonly VoiceEnum PollyEwa = new VoiceEnum("Polly.Ewa");
            public static readonly VoiceEnum PollyFiliz = new VoiceEnum("Polly.Filiz");
            public static readonly VoiceEnum PollyGeraint = new VoiceEnum("Polly.Geraint");
            public static readonly VoiceEnum PollyGiorgio = new VoiceEnum("Polly.Giorgio");
            public static readonly VoiceEnum PollyGwyneth = new VoiceEnum("Polly.Gwyneth");
            public static readonly VoiceEnum PollyHans = new VoiceEnum("Polly.Hans");
            public static readonly VoiceEnum PollyInes = new VoiceEnum("Polly.Ines");
            public static readonly VoiceEnum PollyIvy = new VoiceEnum("Polly.Ivy");
            public static readonly VoiceEnum PollyJacek = new VoiceEnum("Polly.Jacek");
            public static readonly VoiceEnum PollyJan = new VoiceEnum("Polly.Jan");
            public static readonly VoiceEnum PollyJoanna = new VoiceEnum("Polly.Joanna");
            public static readonly VoiceEnum PollyJoey = new VoiceEnum("Polly.Joey");
            public static readonly VoiceEnum PollyJustin = new VoiceEnum("Polly.Justin");
            public static readonly VoiceEnum PollyKarl = new VoiceEnum("Polly.Karl");
            public static readonly VoiceEnum PollyKendra = new VoiceEnum("Polly.Kendra");
            public static readonly VoiceEnum PollyKimberly = new VoiceEnum("Polly.Kimberly");
            public static readonly VoiceEnum PollyLea = new VoiceEnum("Polly.Lea");
            public static readonly VoiceEnum PollyLiv = new VoiceEnum("Polly.Liv");
            public static readonly VoiceEnum PollyLotte = new VoiceEnum("Polly.Lotte");
            public static readonly VoiceEnum PollyLucia = new VoiceEnum("Polly.Lucia");
            public static readonly VoiceEnum PollyLupe = new VoiceEnum("Polly.Lupe");
            public static readonly VoiceEnum PollyMads = new VoiceEnum("Polly.Mads");
            public static readonly VoiceEnum PollyMaja = new VoiceEnum("Polly.Maja");
            public static readonly VoiceEnum PollyMarlene = new VoiceEnum("Polly.Marlene");
            public static readonly VoiceEnum PollyMathieu = new VoiceEnum("Polly.Mathieu");
            public static readonly VoiceEnum PollyMatthew = new VoiceEnum("Polly.Matthew");
            public static readonly VoiceEnum PollyMaxim = new VoiceEnum("Polly.Maxim");
            public static readonly VoiceEnum PollyMia = new VoiceEnum("Polly.Mia");
            public static readonly VoiceEnum PollyMiguel = new VoiceEnum("Polly.Miguel");
            public static readonly VoiceEnum PollyMizuki = new VoiceEnum("Polly.Mizuki");
            public static readonly VoiceEnum PollyNaja = new VoiceEnum("Polly.Naja");
            public static readonly VoiceEnum PollyNicole = new VoiceEnum("Polly.Nicole");
            public static readonly VoiceEnum PollyPenelope = new VoiceEnum("Polly.Penelope");
            public static readonly VoiceEnum PollyRaveena = new VoiceEnum("Polly.Raveena");
            public static readonly VoiceEnum PollyRicardo = new VoiceEnum("Polly.Ricardo");
            public static readonly VoiceEnum PollyRuben = new VoiceEnum("Polly.Ruben");
            public static readonly VoiceEnum PollyRussell = new VoiceEnum("Polly.Russell");
            public static readonly VoiceEnum PollySalli = new VoiceEnum("Polly.Salli");
            public static readonly VoiceEnum PollySeoyeon = new VoiceEnum("Polly.Seoyeon");
            public static readonly VoiceEnum PollyTakumi = new VoiceEnum("Polly.Takumi");
            public static readonly VoiceEnum PollyTatyana = new VoiceEnum("Polly.Tatyana");
            public static readonly VoiceEnum PollyVicki = new VoiceEnum("Polly.Vicki");
            public static readonly VoiceEnum PollyVitoria = new VoiceEnum("Polly.Vitoria");
            public static readonly VoiceEnum PollyZeina = new VoiceEnum("Polly.Zeina");
            public static readonly VoiceEnum PollyZhiyu = new VoiceEnum("Polly.Zhiyu");
            public static readonly VoiceEnum PollyAmyNeural = new VoiceEnum("Polly.Amy-Neural");
            public static readonly VoiceEnum PollyEmmaNeural = new VoiceEnum("Polly.Emma-Neural");
            public static readonly VoiceEnum PollyBrianNeural = new VoiceEnum("Polly.Brian-Neural");
            public static readonly VoiceEnum PollySalliNeural = new VoiceEnum("Polly.Salli-Neural");
            public static readonly VoiceEnum PollyIvyNeural = new VoiceEnum("Polly.Ivy-Neural");
            public static readonly VoiceEnum PollyJoannaNeural = new VoiceEnum("Polly.Joanna-Neural");
            public static readonly VoiceEnum PollyKendraNeural = new VoiceEnum("Polly.Kendra-Neural");
            public static readonly VoiceEnum PollyKimberlyNeural = new VoiceEnum("Polly.Kimberly-Neural");
            public static readonly VoiceEnum PollyJoeyNeural = new VoiceEnum("Polly.Joey-Neural");
            public static readonly VoiceEnum PollyJustinNeural = new VoiceEnum("Polly.Justin-Neural");
            public static readonly VoiceEnum PollyMatthewNeural = new VoiceEnum("Polly.Matthew-Neural");
            public static readonly VoiceEnum PollyCamilaNeural = new VoiceEnum("Polly.Camila-Neural");
            public static readonly VoiceEnum PollyLupeNeural = new VoiceEnum("Polly.Lupe-Neural");
            public static readonly VoiceEnum PollyOliviaNeural = new VoiceEnum("Polly.Olivia-Neural");
            public static readonly VoiceEnum PollyKevinNeural = new VoiceEnum("Polly.Kevin-Neural");
            public static readonly VoiceEnum PollyAriaNeural = new VoiceEnum("Polly.Aria-Neural");
            public static readonly VoiceEnum PollyAyandaNeural = new VoiceEnum("Polly.Ayanda-Neural");
            public static readonly VoiceEnum PollyGabrielleNeural = new VoiceEnum("Polly.Gabrielle-Neural");
            public static readonly VoiceEnum PollyLeaNeural = new VoiceEnum("Polly.Lea-Neural");
            public static readonly VoiceEnum PollyVickiNeural = new VoiceEnum("Polly.Vicki-Neural");
            public static readonly VoiceEnum PollyBiancaNeural = new VoiceEnum("Polly.Bianca-Neural");
            public static readonly VoiceEnum PollyTakumiNeural = new VoiceEnum("Polly.Takumi-Neural");
            public static readonly VoiceEnum PollySeoyeonNeural = new VoiceEnum("Polly.Seoyeon-Neural");
            public static readonly VoiceEnum PollyLuciaNeural = new VoiceEnum("Polly.Lucia-Neural");
        }

        public sealed class LanguageEnum : StringEnum
        {
            private LanguageEnum(string value) : base(value) {}
            public LanguageEnum() {}
            public static implicit operator LanguageEnum(string value)
            {
                return new LanguageEnum(value);
            }

            public static readonly LanguageEnum Arb = new LanguageEnum("arb");
            public static readonly LanguageEnum CaEs = new LanguageEnum("ca-ES");
            public static readonly LanguageEnum CyGb = new LanguageEnum("cy-GB");
            public static readonly LanguageEnum DaDk = new LanguageEnum("da-DK");
            public static readonly LanguageEnum DeDe = new LanguageEnum("de-DE");
            public static readonly LanguageEnum EnAu = new LanguageEnum("en-AU");
            public static readonly LanguageEnum EnCa = new LanguageEnum("en-CA");
            public static readonly LanguageEnum EnGb = new LanguageEnum("en-GB");
            public static readonly LanguageEnum EnGbWls = new LanguageEnum("en-GB-WLS");
            public static readonly LanguageEnum EnIn = new LanguageEnum("en-IN");
            public static readonly LanguageEnum EnNz = new LanguageEnum("en-NZ");
            public static readonly LanguageEnum EnZa = new LanguageEnum("en-ZA");
            public static readonly LanguageEnum EnUs = new LanguageEnum("en-US");
            public static readonly LanguageEnum EsEs = new LanguageEnum("es-ES");
            public static readonly LanguageEnum EsMx = new LanguageEnum("es-MX");
            public static readonly LanguageEnum EsUs = new LanguageEnum("es-US");
            public static readonly LanguageEnum FiFi = new LanguageEnum("fi-FI");
            public static readonly LanguageEnum FrCa = new LanguageEnum("fr-CA");
            public static readonly LanguageEnum FrFr = new LanguageEnum("fr-FR");
            public static readonly LanguageEnum HiIn = new LanguageEnum("hi-IN");
            public static readonly LanguageEnum IsIs = new LanguageEnum("is-IS");
            public static readonly LanguageEnum ItIt = new LanguageEnum("it-IT");
            public static readonly LanguageEnum JaJp = new LanguageEnum("ja-JP");
            public static readonly LanguageEnum KoKr = new LanguageEnum("ko-KR");
            public static readonly LanguageEnum NbNo = new LanguageEnum("nb-NO");
            public static readonly LanguageEnum NlNl = new LanguageEnum("nl-NL");
            public static readonly LanguageEnum PlPl = new LanguageEnum("pl-PL");
            public static readonly LanguageEnum PtBr = new LanguageEnum("pt-BR");
            public static readonly LanguageEnum PtPt = new LanguageEnum("pt-PT");
            public static readonly LanguageEnum RoRo = new LanguageEnum("ro-RO");
            public static readonly LanguageEnum RuRu = new LanguageEnum("ru-RU");
            public static readonly LanguageEnum SvSe = new LanguageEnum("sv-SE");
            public static readonly LanguageEnum TrTr = new LanguageEnum("tr-TR");
            public static readonly LanguageEnum ZhCn = new LanguageEnum("zh-CN");
            public static readonly LanguageEnum ZhHk = new LanguageEnum("zh-HK");
            public static readonly LanguageEnum ZhTw = new LanguageEnum("zh-TW");
        }

        /// <summary>
        /// Message to say
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Voice to use
        /// </summary>
        public Say.VoiceEnum Voice { get; set; }
        /// <summary>
        /// Times to loop message
        /// </summary>
        public int? Loop { get; set; }
        /// <summary>
        /// Message langauge
        /// </summary>
        public Say.LanguageEnum Language { get; set; }

        /// <summary>
        /// Create a new Say
        /// </summary>
        /// <param name="message"> Message to say, the body of the TwiML Element. </param>
        /// <param name="voice"> Voice to use </param>
        /// <param name="loop"> Times to loop message </param>
        /// <param name="language"> Message langauge </param>
        public Say(string message = null,
                   Say.VoiceEnum voice = null,
                   int? loop = null,
                   Say.LanguageEnum language = null) : base("Say")
        {
            this.Message = message;
            this.Voice = voice;
            this.Loop = loop;
            this.Language = language;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Message != null ? this.Message : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Voice != null)
            {
                attributes.Add(new XAttribute("voice", this.Voice.ToString()));
            }
            if (this.Loop != null)
            {
                attributes.Add(new XAttribute("loop", this.Loop.ToString()));
            }
            if (this.Language != null)
            {
                attributes.Add(new XAttribute("language", this.Language.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Create a new <Break/> element and append it as a child of this element.
        /// </summary>
        /// <param name="strength"> Set a pause based on strength </param>
        /// <param name="time"> Set a pause to a specific length of time in seconds or milliseconds, available values:
        ///            [number]s, [number]ms </param>
        public Say Break(SsmlBreak.StrengthEnum strength = null, string time = null)
        {
            var newChild = new SsmlBreak(strength, time);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Break/> element as a child of this element
        /// </summary>
        /// <param name="ssmlBreak"> A SsmlBreak instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Say SsmlBreak(SsmlBreak ssmlBreak)
        {
            this.Append(ssmlBreak);
            return this;
        }

        /// <summary>
        /// Create a new <Break/> element and append it as a child of this element.
        /// </summary>
        /// <param name="strength"> Set a pause based on strength </param>
        /// <param name="time"> Set a pause to a specific length of time in seconds or milliseconds, available values:
        ///            [number]s, [number]ms </param>
        [System.Obsolete("This method is deprecated, use .Break() instead.")]
        public Say SsmlBreak(SsmlBreak.StrengthEnum strength = null, string time = null)
        {
            return Break(strength, time);
        }

        /// <summary>
        /// Create a new <Emphasis/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to emphasize, the body of the TwiML Element. </param>
        /// <param name="level"> Specify the degree of emphasis </param>
        public Say Emphasis(string words = null, SsmlEmphasis.LevelEnum level = null)
        {
            var newChild = new SsmlEmphasis(words, level);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Emphasis/> element as a child of this element
        /// </summary>
        /// <param name="ssmlEmphasis"> A SsmlEmphasis instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Say SsmlEmphasis(SsmlEmphasis ssmlEmphasis)
        {
            this.Append(ssmlEmphasis);
            return this;
        }

        /// <summary>
        /// Create a new <Emphasis/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to emphasize, the body of the TwiML Element. </param>
        /// <param name="level"> Specify the degree of emphasis </param>
        [System.Obsolete("This method is deprecated, use .Emphasis() instead.")]
        public Say SsmlEmphasis(string words = null, SsmlEmphasis.LevelEnum level = null)
        {
            return Emphasis(words, level);
        }

        /// <summary>
        /// Create a new <Lang/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="xml:Lang"> Specify the language </param>
        public Say Lang(string words = null, SsmlLang.XmlLangEnum xmlLang = null)
        {
            var newChild = new SsmlLang(words, xmlLang);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Lang/> element as a child of this element
        /// </summary>
        /// <param name="ssmlLang"> A SsmlLang instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Say SsmlLang(SsmlLang ssmlLang)
        {
            this.Append(ssmlLang);
            return this;
        }

        /// <summary>
        /// Create a new <Lang/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="xml:Lang"> Specify the language </param>
        [System.Obsolete("This method is deprecated, use .Lang() instead.")]
        public Say SsmlLang(string words = null, SsmlLang.XmlLangEnum xmlLang = null)
        {
            return Lang(words, xmlLang);
        }

        /// <summary>
        /// Create a new <P/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        public Say P(string words = null)
        {
            var newChild = new SsmlP(words);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <P/> element as a child of this element
        /// </summary>
        /// <param name="ssmlP"> A SsmlP instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Say SsmlP(SsmlP ssmlP)
        {
            this.Append(ssmlP);
            return this;
        }

        /// <summary>
        /// Create a new <P/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        [System.Obsolete("This method is deprecated, use .P() instead.")]
        public Say SsmlP(string words = null)
        {
            return P(words);
        }

        /// <summary>
        /// Create a new <Phoneme/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="alphabet"> Specify the phonetic alphabet </param>
        /// <param name="ph"> Specifiy the phonetic symbols for pronunciation </param>
        public Say Phoneme(string words = null, SsmlPhoneme.AlphabetEnum alphabet = null, string ph = null)
        {
            var newChild = new SsmlPhoneme(words, alphabet, ph);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Phoneme/> element as a child of this element
        /// </summary>
        /// <param name="ssmlPhoneme"> A SsmlPhoneme instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Say SsmlPhoneme(SsmlPhoneme ssmlPhoneme)
        {
            this.Append(ssmlPhoneme);
            return this;
        }

        /// <summary>
        /// Create a new <Phoneme/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="alphabet"> Specify the phonetic alphabet </param>
        /// <param name="ph"> Specifiy the phonetic symbols for pronunciation </param>
        [System.Obsolete("This method is deprecated, use .Phoneme() instead.")]
        public Say SsmlPhoneme(string words = null, SsmlPhoneme.AlphabetEnum alphabet = null, string ph = null)
        {
            return Phoneme(words, alphabet, ph);
        }

        /// <summary>
        /// Create a new <Prosody/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="volume"> Specify the volume, available values: default, silent, x-soft, soft, medium, loud, x-loud,
        ///              +ndB, -ndB </param>
        /// <param name="rate"> Specify the rate, available values: x-slow, slow, medium, fast, x-fast, n% </param>
        /// <param name="pitch"> Specify the pitch, available values: default, x-low, low, medium, high, x-high, +n%, -n%
        ///             </param>
        public Say Prosody(string words = null, string volume = null, string rate = null, string pitch = null)
        {
            var newChild = new SsmlProsody(words, volume, rate, pitch);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Prosody/> element as a child of this element
        /// </summary>
        /// <param name="ssmlProsody"> A SsmlProsody instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Say SsmlProsody(SsmlProsody ssmlProsody)
        {
            this.Append(ssmlProsody);
            return this;
        }

        /// <summary>
        /// Create a new <Prosody/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="volume"> Specify the volume, available values: default, silent, x-soft, soft, medium, loud, x-loud,
        ///              +ndB, -ndB </param>
        /// <param name="rate"> Specify the rate, available values: x-slow, slow, medium, fast, x-fast, n% </param>
        /// <param name="pitch"> Specify the pitch, available values: default, x-low, low, medium, high, x-high, +n%, -n%
        ///             </param>
        [System.Obsolete("This method is deprecated, use .Prosody() instead.")]
        public Say SsmlProsody(string words = null, string volume = null, string rate = null, string pitch = null)
        {
            return Prosody(words, volume, rate, pitch);
        }

        /// <summary>
        /// Create a new <S/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        public Say S(string words = null)
        {
            var newChild = new SsmlS(words);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <S/> element as a child of this element
        /// </summary>
        /// <param name="ssmlS"> A SsmlS instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Say SsmlS(SsmlS ssmlS)
        {
            this.Append(ssmlS);
            return this;
        }

        /// <summary>
        /// Create a new <S/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        [System.Obsolete("This method is deprecated, use .S() instead.")]
        public Say SsmlS(string words = null)
        {
            return S(words);
        }

        /// <summary>
        /// Create a new <Say-As/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to be interpreted, the body of the TwiML Element. </param>
        /// <param name="interpret-As"> Specify the type of words are spoken </param>
        /// <param name="role"> Specify the format of the date when interpret-as is set to date </param>
        public Say SayAs(string words = null, SsmlSayAs.InterpretAsEnum interpretAs = null, SsmlSayAs.RoleEnum role = null)
        {
            var newChild = new SsmlSayAs(words, interpretAs, role);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Say-As/> element as a child of this element
        /// </summary>
        /// <param name="ssmlSayAs"> A SsmlSayAs instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Say SsmlSayAs(SsmlSayAs ssmlSayAs)
        {
            this.Append(ssmlSayAs);
            return this;
        }

        /// <summary>
        /// Create a new <Say-As/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to be interpreted, the body of the TwiML Element. </param>
        /// <param name="interpret-As"> Specify the type of words are spoken </param>
        /// <param name="role"> Specify the format of the date when interpret-as is set to date </param>
        [System.Obsolete("This method is deprecated, use .SayAs() instead.")]
        public Say SsmlSayAs(string words = null,
                             SsmlSayAs.InterpretAsEnum interpretAs = null,
                             SsmlSayAs.RoleEnum role = null)
        {
            return SayAs(words, interpretAs, role);
        }

        /// <summary>
        /// Create a new <Sub/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to be substituted, the body of the TwiML Element. </param>
        /// <param name="alias"> Substitute a different word (or pronunciation) for selected text such as an acronym or
        ///             abbreviation </param>
        public Say Sub(string words = null, string alias = null)
        {
            var newChild = new SsmlSub(words, alias);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Sub/> element as a child of this element
        /// </summary>
        /// <param name="ssmlSub"> A SsmlSub instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Say SsmlSub(SsmlSub ssmlSub)
        {
            this.Append(ssmlSub);
            return this;
        }

        /// <summary>
        /// Create a new <Sub/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to be substituted, the body of the TwiML Element. </param>
        /// <param name="alias"> Substitute a different word (or pronunciation) for selected text such as an acronym or
        ///             abbreviation </param>
        [System.Obsolete("This method is deprecated, use .Sub() instead.")]
        public Say SsmlSub(string words = null, string alias = null)
        {
            return Sub(words, alias);
        }

        /// <summary>
        /// Create a new <W/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="role"> Customize the pronunciation of words by specifying the word’s part of speech or alternate
        ///            meaning </param>
        public Say W(string words = null, string role = null)
        {
            var newChild = new SsmlW(words, role);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <W/> element as a child of this element
        /// </summary>
        /// <param name="ssmlW"> A SsmlW instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Say SsmlW(SsmlW ssmlW)
        {
            this.Append(ssmlW);
            return this;
        }

        /// <summary>
        /// Create a new <W/> element and append it as a child of this element.
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="role"> Customize the pronunciation of words by specifying the word’s part of speech or alternate
        ///            meaning </param>
        [System.Obsolete("This method is deprecated, use .W() instead.")]
        public Say SsmlW(string words = null, string role = null)
        {
            return W(words, role);
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Say Append(TwiML childElem)
        {
            return (Say) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Say SetOption(string key, object value)
        {
            return (Say) base.SetOption(key, value);
        }
    }

}