﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace FYPUrduCompiler
{
    class Translator
    {
        #region Properties

        /// <summary>
        /// Gets the supported languages.
        /// </summary>
        public static IEnumerable<string> Languages
        {
            get
            {
                Translator.EnsureInitialized();
                return Translator._languageModeMap.Keys.OrderBy(p => p);
            }
        }

        /// <summary>
        /// Gets the time taken to perform the translation.
        /// </summary>
        public TimeSpan TranslationTime
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the url used to speak the translation.
        /// </summary>
        /// <value>The url used to speak the translation.</value>
        public string TranslationSpeechUrl
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the error.
        /// </summary>
        public Exception Error
        {
            get;
            private set;
        }

        #endregion

        #region Public methods

 
        public string Translate (string sourceText)
        {
            // Initialize
            this.Error = null;
            this.TranslationSpeechUrl = null;
            this.TranslationTime = TimeSpan.Zero;
            DateTime tmStart = DateTime.Now;
            string translation = string.Empty;

            try
            {
                // Download translation
                string url = string.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                                            Translator.LanguageEnumToIdentifier("Urdu"),
                                            Translator.LanguageEnumToIdentifier("English"),
                                            HttpUtility.UrlEncode(sourceText));

                string outputFile = Path.GetTempFileName();
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    wc.DownloadFile(url, outputFile);
                }

                // Get translated text
                if (File.Exists(outputFile))
                {

                    // Get phrase collection
                    string text = File.ReadAllText(outputFile);
                    int index = text.IndexOf(string.Format(",,\"{0}\"", Translator.LanguageEnumToIdentifier("Urdu")));
                    if (index == -1)
                    {
                        // Translation of single word
                        int startQuote = text.IndexOf('\"');
                        if (startQuote != -1)
                        {
                            int endQuote = text.IndexOf('\"', startQuote + 1);
                            if (endQuote != -1)
                            {
                                translation = text.Substring(startQuote + 1, endQuote - startQuote - 1);
                            }
                        }
                    }
                    else
                    {
                        // Translation of phrase
                        text = text.Substring(0, index);
                        text = text.Replace("],[", ",");
                        text = text.Replace("]", string.Empty);
                        text = text.Replace("[", string.Empty);
                        text = text.Replace("\",\"", "\"");

                        // Get translated phrases
                        string[] phrases = text.Split(new[] { '\"' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; (i < phrases.Count()); i += 2)
                        {
                            string translatedPhrase = phrases[i];
                            if (translatedPhrase.StartsWith(",,"))
                            {
                                i--;
                                continue;
                            }
                            translation += translatedPhrase + "  ";
                        }
                    }

                    // Fix up translation
                    translation = translation.Trim();
                    translation = translation.Replace(" ?", "?");
                    translation = translation.Replace(" !", "!");
                    translation = translation.Replace(" ,", ",");
                    translation = translation.Replace(" .", ".");
                    translation = translation.Replace(" ;", ";");

                    // And translation speech URL
                    //this.TranslationSpeechUrl = string.Format("https://translate.googleapis.com/translate_tts?ie=UTF-8&q={0}&tl={1}&total=1&idx=0&textlen={2}&client=gtx",
                    //                                       HttpUtility.UrlEncode(translation), Translator.LanguageEnumToIdentifier("English"), translation.Length);
                }
            }
            catch (Exception ex)
            {
                this.Error = ex;
            }

            // Return result
            this.TranslationTime = DateTime.Now - tmStart;
            return translation;
        }

        #endregion

        #region Private methods

       
        private static string LanguageEnumToIdentifier
            (string language)
        {
            string mode = string.Empty;
            Translator.EnsureInitialized();
            Translator._languageModeMap.TryGetValue(language, out mode);
            return mode;
        }

     
        private static void EnsureInitialized()
        {
            if (Translator._languageModeMap == null)
            {
                Translator._languageModeMap = new Dictionary<string, string>();
                Translator._languageModeMap.Add("English", "en");
                Translator._languageModeMap.Add("Urdu", "ur");

            }
        }

        #endregion

        #region Fields

        /// <summary>
        /// The language to translation mode map.
        /// </summary>
        private static Dictionary<string, string> _languageModeMap;

        #endregion
    }
}
