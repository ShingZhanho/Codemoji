using System.IO;

namespace Codemoji {
    public class EmojiDictionary {
        public EmojiDictionary(string file) {
            if (!File.Exists(file))
                throw new FileNotFoundException(file);
        }

        internal string GetOriginalName(string customName) {
            // TODO: Finds original name here

            return null; // If name not found, return null
        }
    }
}
