string word = Console.ReadLine();

while (word != "end")
{
    string reversedWord = ReverseWord(word);
    Console.WriteLine($"{word} = {reversedWord}");

    word = Console.ReadLine();
}

static string ReverseWord (string word)
{
    char[] wordArr = word.ToCharArray();
    Array.Reverse(wordArr);

    return new string(wordArr);
}