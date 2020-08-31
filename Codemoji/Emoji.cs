using System;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using Codemoji.Properties;

namespace Codemoji {
    public class Emoji {

        /// <summary>
        /// Use emojis by their names.
        /// </summary>
        /// <param name="names">Names of emojis</param>
        /// <returns>Corresponding emojis, if emoji not found, it will be automatically skipped.</returns>
        public static string Use(params string[] names) {
            return Use(options:null, names);
        }

        public static string Use(EmojiDictionary emojiDictionary, params string[] names) {
            return Use(new EmojiOptions(emojiDictionary), names);
        }

        public static string Use(EmojiOptions options, params string[] names) {
            string returnString = null;
            var _options = options ?? new EmojiOptions();

            foreach (var name in names) {
                var unicode = Resources.ResourceManager.GetString(_options.UseCustomNames
                    ? $"emoji_{_options.Dictionary.GetOriginalName(name)}" // Get original name if dictionary exists
                    : $"emoji_{name}"); // Get from resources
                if (unicode is null) {
                    if (_options.UseCustomNames) { // Name not found in dictionary
                        unicode = Resources.ResourceManager.GetString($"emoji_{name}");
                        if (unicode is null) continue; // Still not exist, skip
                    } 
                    else continue; // If no dictionary and name not found, skip
                }
                
                // Encode each 8-digit unicode
                foreach (var codePoint in unicode.Split(',')) {
                    if (codePoint.Length != 8) continue; // Code pont must be in 8 digits
                    returnString += ConvertFromCodePoint(codePoint);
                }
            }

            return returnString;
        }

        private static string ConvertFromCodePoint(string codePoint) {
            string encoded;
            try {
                encoded = char.ConvertFromUtf32(int.Parse(codePoint, System.Globalization.NumberStyles.HexNumber));
            }
            catch {
                return "";
            }

            return encoded;
        }
    }
}