using System;
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
            var returnString = "";

            foreach (var name in names) {
                var unicode = Resources.ResourceManager.GetString($"emoji_{name}");
                if (unicode is null) continue; // skip if null
                
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