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
            Assert.AreEqual(1, emoji.Length);
        }
    }
}