namespace Codemoji {
    public class EmojiOptions {
        
        private EmojiDictionary _dictionary;
        public EmojiDictionary Dictionary {
            get => _dictionary;

            set {
                _dictionary = value;
                UseCustomNames = true;
            }
        }

        internal bool UseCustomNames { get; private set; }
        
        /// <summary>
        /// Gets or sets whether replace all hyphens to underscores or not.
        /// </summary>
        public bool UseHyphens { get; set; }
    }
}
