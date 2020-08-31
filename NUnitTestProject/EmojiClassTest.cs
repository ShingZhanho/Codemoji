using NUnit.Framework;
using Codemoji;

namespace NUnitTestProject {
    public class EmojiTests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void EmojiUse_SingleValidName_Emoji(
            [Values("grinning_face")]string name) {
            // Acts
            var emoji = Emoji.Use(name);
            
            // Asserts
            Assert.IsNotNull(emoji);
            Assert.AreEqual(2, emoji.Length);
        }
        
        [Test]
        public void EmojiUse_SingleInvalidName_Null(
            [Values("invalid_name")] string invalidName) {
            // Acts
            var nullEmoji = Emoji.Use(invalidName);
            
            // Asserts
            Assert.IsNull(nullEmoji);
        }
    }
}