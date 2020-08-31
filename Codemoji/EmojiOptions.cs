namespace Codemoji {
    public class EmojiOptions {
        public EmojiOptions() {
            UseCustomNames = false;
        }

        public EmojiOptions(string dictionary) {
            Dictionary = new EmojiDictionary(dictionary);
            UseCustomNames = true;
        }

        public EmojiOptions(EmojiDictionary emojiDictionary) {
            Dictionary = emojiDictionary;
            UseCustomNames = true;
        }

        public EmojiDictionary Dictionary { get; set; }
        internal bool UseCustomNames { get; set; }
    }
}
