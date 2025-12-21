int numberOfApples = 12;
decimal pricePerApple = 0.35M;
decimal totalPrice = pricePerApple * numberOfApples;

//WriteLine(
//    format: "{0} apples cost {1:C}",
//    arg0: numberOfApples,
//    arg1: pricePerApple * numberOfApples);

//string formatted = string.Format(
//    format: "{0} apples cost {1:C}",
//    arg0: numberOfApples,
//    arg1: pricePerApple * numberOfApples);

//WriteLine(formatted);

//string formatted2 = string.Format($"{numberOfApples} apples cost {totalPrice:C}");

//WriteLine(formatted2);

//WriteLine("{0} {1} lived in {2}.",
//    arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");

//WriteLine("{0} lives in {1} and his favorite team is {2}. {2} will be champions in {3}!",
//    "John", "São Paulo", "Corinthians", 2026);

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);