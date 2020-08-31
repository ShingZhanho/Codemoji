<p>
<h1 align="center">😍😎 Codemoji 🙈🥧</h1>
<p align="center">Use emoji in your code without handling Unicode :smile: !</p>
</p>

## What ❓

Codemoji is a library based on C# which allows you to use emoji in your code without handling Unicode 😎.

## How ❓

Simply use the Emoji class with the emoji's name like below :arrow_down: :

```c#
Console.WriteLine("Hello World! {0}", Emoji.Use("smiley"));

/*
 * Output:
 * Hello World! 😃
 */
```

Or you can use more than one emojis as the following code:

```c#
Console.WriteLine("Number emojis: {0}", Emoji.Use("one", "two", "three"));

/*
 * Output:
 * Number emojis: 1️⃣2️⃣3️⃣
 */
```

## 🤮 The names you provided suck, I want to use my own names

No problem 😋! Create a plain text file, add something with the following format:

```
{original_name}>{your_cool_name}
```

like:

```
{heavy_check_mark}>{tick_symbol}
{smile}>{face_i_really_dont_like}
```

And in your code:

```c#
// Load your custom naming rules:
var dict = new EmojiDictionary("./path/to/your/file.txt");

// Use your naming rules
Console.WriteLine("Now I feels really great! {0}", Emoji.Use(dict, "tick_symbol"));
```

## You said you want to contribute? 😍

Thank you 😘! If you are adding emojis to resources file, please visit [this page](./Contribute/AddingEmojis.md) first.
