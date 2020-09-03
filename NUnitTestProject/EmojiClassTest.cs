using System;
using NUnit.Framework;
using Codemoji;

namespace NUnitTestProject {
    public class EmojiTests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void EmojiUse_SingleValidName_Emoji(
            [Values("grinning_face", "upside_down_face", "eye_in_speech_bubble")]string name) {
            // Acts
            var emoji = Emoji.Use(name);
            Console.WriteLine(emoji);
            
            // Asserts
            Assert.IsNotNull(emoji);
        }
        
        [Test]
        public void EmojiUse_SingleInvalidName_Null(
            [Values("invalid_name", "hello")] string invalidName) {
            // Acts
            var nullEmoji = Emoji.Use(invalidName);
            
            // Asserts
            Assert.IsNull(nullEmoji);
        }
    }
}