string input = Console.ReadLine();

string numbersInString = string.Empty;
string lettersInString = string.Empty;
string othersInString = string.Empty;

for (int i = 0; i < input.Length; i++)
{
    if (Char.IsDigit(input[i]))
    {
        numbersInString += input[i];
    }
    else if (Char.IsLetter(input[i]))
    {
        lettersInString += input[i];
    }
    else
    {
        othersInString += input[i];
    }
}

Console.WriteLine(numbersInString);
Console.WriteLine(lettersInString);
Console.WriteLine(othersInString);